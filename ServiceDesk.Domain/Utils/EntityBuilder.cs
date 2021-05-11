namespace ServiceDesk.Domain.Utils
{
    using System;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;

    internal class EntityBuilder
    {
        private readonly ModelBuilder builder;

        public EntityBuilder(ModelBuilder builder) => this.builder = builder;

        internal void ChangeDefaultIdentityName()
        {
            builder.Entity<IdentityUser>().ToTable("Users");
            builder.Entity<IdentityRole>().ToTable("Roles");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
        }

        internal void UserBuild()
        {
            var adminId = Guid.NewGuid().ToString();
            var operatorsId = new string[]
                                  {
                                      Guid.NewGuid().ToString(),
                                      Guid.NewGuid().ToString(),
                                      Guid.NewGuid().ToString()
                                  };

            var operatorRoleId = Guid.NewGuid().ToString();
            var adminRoleId = Guid.NewGuid().ToString();

            builder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = adminId,
                    UserName = "Administrator",
                    NormalizedUserName = "ADMINISTRATOR",
                    Email = "administrator@test.ru",
                    NormalizedEmail = "ADMINISTRATOR@TEST.RU",
                    PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "password")
                });

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                    {
                        Id = operatorRoleId,
                        Name = "Operator",
                        NormalizedName = "OPERATOR"
                    });

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                    {
                        Id = adminRoleId,
                        Name = "Administrator",
                        NormalizedName = "ADMINISTRATOR"
                    });

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>() { RoleId = adminRoleId, UserId = adminId });

            for (int i = 0; i < operatorsId.Length; i++)
            {
                builder.Entity<IdentityUser>().HasData(
                    new IdentityUser
                    {
                        Id = operatorsId[i],
                        UserName = $"Operator{i}",
                        NormalizedUserName = $"OPERATOR{i}",
                        Email = $"operator{i}@test.ru",
                        NormalizedEmail = $"OPERATOR{i}@TEST.RU",
                        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, $"password{i}")
                    });

                builder.Entity<IdentityUserRole<string>>().HasData(
                    new IdentityUserRole<string>() { RoleId = operatorRoleId, UserId = operatorsId[i] });
            }
        }
    }
}