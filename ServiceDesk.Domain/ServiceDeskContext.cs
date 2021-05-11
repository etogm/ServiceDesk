namespace ServiceDesk.Domain
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using ServiceDesk.Domain.Entities;
    using ServiceDesk.Domain.Utils;

    public class ServiceDeskContext : IdentityDbContext<IdentityUser>
    {
        public ServiceDeskContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Report> Reports { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Report>(entity =>
                {
                    entity.Property(e => e.FullName)
                        .IsRequired()
                        .HasMaxLength(256);

                    entity.Property(e => e.Phone)
                        .HasMaxLength(11);

                    entity.Property(e => e.Text).HasMaxLength(1024);
                });

            EntityBuilder entityBuilder = new EntityBuilder(builder);

            entityBuilder.ChangeDefaultIdentityName();
            entityBuilder.UserBuild();
        }
    }
}