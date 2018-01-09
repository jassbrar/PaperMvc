namespace Paper2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=DefaultConnections")
        {
        }

        public virtual DbSet<FirstTable> FirstTables { get; set; }
        public virtual DbSet<SecondTable> SecondTables { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FirstTable>()
                .Property(e => e.ProductID)
                .IsFixedLength();

            modelBuilder.Entity<FirstTable>()
                .Property(e => e.Speed)
                .IsFixedLength();

            modelBuilder.Entity<SecondTable>()
                .Property(e => e.Milage)
                .IsFixedLength();
        }
    }
}
