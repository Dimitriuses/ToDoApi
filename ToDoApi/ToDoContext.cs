using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApi.Model;

namespace ToDoApi
{
    public class ToDoContext: DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options):base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Objective> Objectives { get; set; }
        public DbSet<Mark> Marks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var ww = builder.Entity<MarkObjective>();
            ww.HasKey(w => new { w.MarkId, w.ObjectiveId });

            ww.HasOne(w => w.Mark)
              .WithMany(wc => wc.Objectives)
              .HasForeignKey(w => w.MarkId);
            ww.HasOne(w => w.Objective)
              .WithMany(wc => wc.Marks)
              .HasForeignKey(w => w.ObjectiveId);
        }
    }
}
