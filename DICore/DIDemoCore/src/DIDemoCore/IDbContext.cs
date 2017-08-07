using DIDemoCore.Models;
using Microsoft.EntityFrameworkCore;

namespace DIDemoCore
{
    public interface IDbContext
    {
        DbSet<HrRequest> HrRequests { get; set; }
        int SaveChanges();
    }
}