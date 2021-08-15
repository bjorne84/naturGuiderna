using Microsoft.EntityFrameworkCore;
using naturGuiderna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace naturGuiderna.Data
{
    public class NatureDbContext : DbContext
    {
        public NatureDbContext(DbContextOptions<NatureDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Experience_Activity>().HasKey(ea => new
            {
                ea.ExperienceId,
                ea.ActivityId
            });

            modelBuilder.Entity<Experience_Activity>().HasOne(a => a.Activity).WithMany(ea => ea.Experience_Activities).HasForeignKey(a => a.ActivityId);
         
            modelBuilder.Entity<Experience_Activity>().HasOne(a => a.Experience).WithMany(ea => ea.Experience_Activities).HasForeignKey(a => a.ExperienceId);
            
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Guide> Guides { get; set; }
    }
}
