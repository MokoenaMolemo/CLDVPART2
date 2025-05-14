using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EVENTEASEN_5.Models
{
    public partial class EventEase5DB : DbContext
    {
        public EventEase5DB()
            : base("name=EventEase5DB")
        {
        }

        public virtual DbSet<Venue> Venues { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Venue>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<Venue>()
                .Property(e => e.Location)
                .IsUnicode(false);
        }
    }
}
