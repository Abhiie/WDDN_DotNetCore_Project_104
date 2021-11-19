using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VotingCore.Models;
namespace VotingCore.AppDbContext
{
    public class EVotingDbContext: IdentityDbContext<ApplicationUser>

    {
        public EVotingDbContext(DbContextOptions<EVotingDbContext> options):
            base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Voters>()
                .HasIndex(u => u.PanNumber)
                .IsUnique();
            base.OnModelCreating(builder);
        }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Voters> Voters{ get; set; }
        public DbSet<Elections> Elections { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<VotedInfo> VotedInfos { get; set; }

    }
}
