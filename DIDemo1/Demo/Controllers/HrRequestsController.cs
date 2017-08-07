using System.Web.Http;
using Demo.Models;
using Demo.Services;

namespace Demo.Controllers
{
    public class HrRequestsController : ApiController
    {
        private IDbContext db = new HrContext();
        
        public IHttpActionResult Post(HrRequest hrRequest)
        {
            var hrRequestService = new HrRequestService();
            hrRequest.AssignedTo = hrRequestService.AssignHrManager();

            db.HrRequests.Add(hrRequest);
            db.SaveChanges();

            return Ok(hrRequest);
        }
    }
}