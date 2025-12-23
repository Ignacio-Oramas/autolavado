using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using mvcrud.Models;

namespace mvcrud.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
    {
        public DbSet<Empleado> Empleados { get; set; } = default! ;
        public DbSet<Client> Clients { get; set; } = default!;
        public DbSet<Service> Services { get; set; } = default!;
        public DbSet<Vehicle> Vehicles { get; set; } = default!;
        public DbSet<WashingOrder> WashingOrders { get; set; } = default!;
    }
}
