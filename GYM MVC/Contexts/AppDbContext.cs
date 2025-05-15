using GYM_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace GYM_MVC.Contexts
{
    public class AppDbContext :DbContext
    {
        private readonly string _connectionString = @"Server=DESKTOP-GTVND9D\SQLEXPRESS;Database=GYMDB;Trusted_Connection=True;TrustserverCertificate=True;";
        public DbSet<ProgramModel> Programs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
            base.OnConfiguring(optionsBuilder);
        }


    }
}
