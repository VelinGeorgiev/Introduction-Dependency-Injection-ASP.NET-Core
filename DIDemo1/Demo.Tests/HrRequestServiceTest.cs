using System;
using NUnit.Framework;
using NSubstitute;
using Demo.Services;

namespace Demo.Tests
{
    [TestFixture]
    public class HrRequestServiceTest
    {
        private HrRequestService _hrRequestService;

        [SetUp]
        public void Initialize()
        {
            _hrRequestService = new HrRequestService();
        }

        [Test]
        public void Assign_John()
        {
            var result = _hrRequestService.AssignHrManager();
            Assert.AreEqual(result, "John");
        }

        [Test]
        public void Assign_Ben()
        {
            var result = _hrRequestService.AssignHrManager();
            Assert.AreEqual(result, "Ben");
        }
    }
}
