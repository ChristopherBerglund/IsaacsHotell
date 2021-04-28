using IsaacsHotell.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsaacsHotell.Data
{
    public class ApplicationDbContext : IdentityDbContext<Användare>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            string ADMIN_ID = "02174cf0–9412–4cfe-afbf-59f706d72cf6";
            string ROLE_ID = "341743f0-asd2–42de-afbf-59kmkkmk72cf6";

            //seed admin role

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "Admin",
                NormalizedName = "ADMIN",
                Id = ROLE_ID,
                ConcurrencyStamp = ROLE_ID
            });

            //create user
            var appUser = new Användare
            {
                Id = ADMIN_ID,
                Email = "frankofoedu@gmail.com",
                NormalizedEmail = "FRANKOFOEDU@GMAIL.COM",
                EmailConfirmed = true,
                Namn = "Frank",
                Efternamn = "Ofoedu",
                UserName = "frankofoedu@gmail.com",
                NormalizedUserName = "FRANKOFOEDU@GMAIL.COM",
                PhoneNumber = "0784545454",
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            //set user password
            PasswordHasher<Användare> ph = new PasswordHasher<Användare>();
            appUser.PasswordHash = ph.HashPassword(appUser, "QWEasd!1");

            //seed user
            builder.Entity<Användare>().HasData(appUser);

            //set user role to admin
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });
            
        }
    }
}

