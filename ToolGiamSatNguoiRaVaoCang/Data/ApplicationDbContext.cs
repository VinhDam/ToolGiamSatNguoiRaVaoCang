using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ToolGiamSatNguoiRaVaoCang.Models;

namespace ToolGiamSatNguoiRaVaoCang.Data {
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options) {
        public DbSet<Company> Company { get; set; }
        public DbSet<Zone> Zone { get; set; }
        public DbSet<ZoneType> ZoneType { get; set; }
        public DbSet<Shift> Shift { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<IssuePriority> IssuePriority { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IssuePriority>().HasData(
                new IssuePriority { Id =1, Name="Cao" },
                new IssuePriority { Id =2, Name="Trung bình" },
                new IssuePriority { Id =3, Name="Thấp" }
            );
        }
    }
}