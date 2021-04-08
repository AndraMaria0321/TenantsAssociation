using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WADproj.Models;

namespace ProjectWebApp.Models
{
    public class TenantsContext : DbContext
    {
        public TenantsContext(DbContextOptions<TenantsContext> options)
            : base(options)
        { }

        public DbSet<Apartment> Apartment { get; set; }

        public DbSet<Building> Building { get; set; }

        public DbSet<Invoice> Invoice { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<UserType> UserType { get; set; }

    }
}
