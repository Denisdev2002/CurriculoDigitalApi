using CurriculoDigital.Domain.Entities.Base;
using CurriculoDigital.Domain.Entities.Midias;
using CurriculoDigital.Domain.Entities.Personal;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CurriculoDigital.Infra
{
    public class DatabaseContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public DatabaseContext(DbContextOptions<DatabaseContext> contextOptions, IConfiguration configuration) : base(contextOptions)
        {
            _configuration = configuration;
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _configuration.GetConnectionString("DefaultConnection");
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(connectionString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Experience>().ToTable("Experiencie");
            modelBuilder.Entity<SocialMedia>().ToTable("SocialMedia");
            modelBuilder.Entity<PersonalInformation>().ToTable("PersonalInformation");

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Experience> Experiences { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<PersonalInformation> PersonalInformations { get; set; }
    }
}
