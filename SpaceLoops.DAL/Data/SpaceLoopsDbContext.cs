using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SpaceLoops.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SpaceLoops.DAL.Data
{
    public class SpaceLoopsDbContext : IdentityDbContext
    {
        public SpaceLoopsDbContext(DbContextOptions<SpaceLoopsDbContext> options)
        : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Contact> Contacts { get; set; }
    }
}
