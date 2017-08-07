using System.Web.Http;
using Demo.Models;

namespace Demo.Controllers
{
    public class HrRequestsController : ApiController
    {
        private IDbContext _db;
        public HrRequestsController(IDbContext db)
        {
            _db = db;
        }

        public IHttpActionResult Post(HrRequest hrRequest)
        {
            // Database Logic.
            _db.HrRequests.Add(hrRequest);
            _db.SaveChanges();

            return Ok(hrRequest);
        }
    }
}