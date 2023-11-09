using IQTest.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace IQTest.Repository
{
    public class AppDbContext:DbContext //DbContext ile EF den yararlanıyoruz.
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }

        public DbSet<Question> Questions { get; set; } //DB de Questions sütunu

        public DbSet<CorrectAnswer> CorrectAnswers { get; set; } //DB de CorrectAnswer sütunu

        public DbSet<WrongAnswer> WrongAnswers { get; set; } // DB de WrongAnswers sütunu

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // tüm configuration dosyalarını buluyor işliyor

            base.OnModelCreating(modelBuilder);
        }


    }
}
