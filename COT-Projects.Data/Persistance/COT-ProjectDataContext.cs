using COT_Projects.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace COT_Projects.Data.Persistance
{
    public partial class COT_ProjectDataContext : IdentityDbContext<ApplicationUser>
    {

        public COT_ProjectDataContext()
        {
        }

        public COT_ProjectDataContext(DbContextOptions<COT_ProjectDataContext> options)
            : base(options)
        {
        }

        //Initialize entities
        public DbSet<Report> Reports{ get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
