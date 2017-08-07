using DIDemoCore.Models;
using Microsoft.EntityFrameworkCore;

namespace DIDemoCore
{
    public class HrContext : DbContext, IDbContext
    {
        public virtual DbSet<HrRequest> HrRequests { get; set; }
    }
}