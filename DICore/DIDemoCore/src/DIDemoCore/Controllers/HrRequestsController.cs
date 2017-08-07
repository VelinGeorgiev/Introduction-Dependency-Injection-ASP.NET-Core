using Microsoft.AspNetCore.Mvc;
using DIDemoCore.Models;

namespace DIDemoCore.Controllers
{
    public class HrRequestsController : Controller
    {
        private IDbContext _db;

        public HrRequestsController(IDbContext db)
        {
            _db = db;
        }

        [Route("api/[controller]")]
        public IActionResult Post(HrRequest hrRequest)
        {
            _db.HrRequests.Add(hrRequest);
            _db.SaveChanges();

            return Ok(hrRequest);
        }
    }
}
// https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?tabs=aspnet1x
// https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection