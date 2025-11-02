using Microsoft.EntityFrameworkCore;
using VendorManagementAPI.Models;

namespace VendorManagementAPI.Data
{
    public class VendorContext : DbContext
    {
        public VendorContext(DbContextOptions<VendorContext> options) : base(options) { }
        public DbSet<Vendor> Vendors { get; set; }
    }
}
