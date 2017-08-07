using System;
using NUnit.Framework;
using Demo.Controllers;
using Demo.Models;
using System.Web.Http.Results;
using NSubstitute;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Demo.Tests
{
    [TestFixture]
    public class HrRequestControllerTest
    {
        private HrRequestsController _hrRequestController;
        private HrContext _mockContext;
        private List<HrRequest> _fakeDataStorage;

        [SetUp]
        public void Initialize()
        {
            _fakeDataStorage = new List<HrRequest>() {
                new HrRequest() { Id = 1, AssignedTo = "Velin", Message = "Velin test" }
            };

            // Mock EF context using NSubstitute.
            _mockContext = Substitute.For<HrContext>();
            _mockContext.HrRequests.ReturnsForAnyArgs(x => CreateMockSetFrom(_fakeDataStorage));

            // Init new controller. Inject _mockContext.
            _hrRequestController = new HrRequestsController(_mockContext);
        }

        [Test]
        public void New_HrRequest_OkResult()
        {
            var hrRequest = new HrRequest();

            hrRequest.Message = "Test";
            hrRequest.Created = DateTime.UtcNow;
            hrRequest.AssignedTo = "John";

            var response = _hrRequestController.Post(hrRequest);

            Assert.IsInstanceOf<OkNegotiatedContentResult<HrRequest>>(response);
        }

        private IDbSet<T> CreateMockSetFrom<T>(List<T> list) where T : class
        {
            var mockSet = Substitute.For<DbSet<T>, IQueryable<T>>();
            ((IQueryable)mockSet).Provider.Returns(list.AsQueryable().Provider);
            ((IQueryable)mockSet).Expression.Returns(list.AsQueryable().Expression);
            ((IQueryable)mockSet).ElementType.Returns(list.AsQueryable().ElementType);
            ((IQueryable)mockSet).GetEnumerator().Returns(list.GetEnumerator());
            mockSet.When(x => x.Add(Arg.Any<T>())).Do(x => list.Add((T)x[0]));

            return mockSet;
        }
    }
}