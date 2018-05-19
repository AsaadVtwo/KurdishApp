using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using KurdishApp.Models;
using Kurdish.Models;

namespace KurdishApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public virtual DbSet<Schools> Schools { get; set; }
        public virtual DbSet<Teachers> Teachers { get; set; }
        public DbSet<Kurdish.Models.SchoolTeacher> SchoolTeacher { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.Entity<SchoolTeacher>()
                .HasKey(st => new { st.SchoolId, st.TeacherId });

            builder.Entity<Schools>()
                .HasKey(s => new { s.SchoolId });

            builder.Entity<Teachers>()
                .HasKey(t => new { t.TeacherId });

        }
    }
}
