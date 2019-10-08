using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CRUDTEST.Data;

namespace CRUDTEST.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CRUDTEST.Data.Departments> Departments { get; set; }
        public DbSet<CRUDTEST.Data.Employees> Employees { get; set; }
    }
}
