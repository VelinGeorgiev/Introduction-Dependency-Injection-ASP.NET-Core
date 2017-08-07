using System.Data.Entity;
using Demo.Models;

namespace Demo
{
    public interface IDbContext
    {
        DbSet<HrRequest> HrRequests { get; set; }
        int SaveChanges();
    }
}