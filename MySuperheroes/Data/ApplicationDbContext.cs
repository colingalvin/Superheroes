using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MySuperheroes.Models;

namespace MySuperheroes.Data
{
    // representation of database within app
    public class ApplicationDbContext : IdentityDbContext
    {
        // table respresentation in database
        public DbSet<Superhero> Superheroes { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
