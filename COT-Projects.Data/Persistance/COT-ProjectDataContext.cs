using COT_Projects.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace COT_Projects.Data.Persistance
{
    public partial class COT_ProjectDataContext : IdentityDbContext
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
    }
}
