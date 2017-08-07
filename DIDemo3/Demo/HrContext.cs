using System.Data.Entity;
using Demo.Models;

namespace Demo
{
    public class HrContext : DbContext, IDbContext
    {
        public virtual DbSet<HrRequest> HrRequests { get; set; }
    }
}