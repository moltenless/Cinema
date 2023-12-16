using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;


namespace DAL.EF
{
    public partial class CinemaContext : DbContext
    {
        public CinemaContext() : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost; database=cinema; UID=root; password=myfuckingsql", ServerVersion.Create(1, 0, 0, ServerType.MySql));
        }

        public virtual DbSet<Hall> Hall { get; set; }
        public virtual DbSet<Seat> Seat { get; set; }
        public virtual DbSet<Session> Session { get; set; }
        public virtual DbSet<Reservation> Reservation { get; set; }
        public virtual DbSet<Visitor> Visitor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
