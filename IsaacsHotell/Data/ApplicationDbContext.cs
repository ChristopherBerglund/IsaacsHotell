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
            string ADMIN_ID =        "02174cf0–9412–4cfe-afbf-59f706d72cf6";
            string RECEPTION_ID =    "451089f0-da4s–5d6s-pqwe-59kmoldp78df6";
            string CLEANER_ID =      "569842f0-78dw–65ws-qwbf-59dafgqw345f6";
            string ROLE_ID =         "341743f0-asd2–42de-afbf-59kmkkmk72cf6";
            string ROLEROLE_ID =     "334567f0-whj2–47de-atyf-59qbvcse96cf6";
            string ROLEROLEROLE_ID = "912345f0-hgd2–41ae-vnqf-59ghjknm72cf6";

            //seed admin role

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "Admin",
                NormalizedName = "ADMIN",
                Id = ROLE_ID,
                ConcurrencyStamp = ROLE_ID
            },
            new IdentityRole {
                Name = "Reception",
                NormalizedName = "RECEPTION",
                Id = ROLEROLE_ID,
                ConcurrencyStamp = ROLEROLE_ID
            },
                new IdentityRole { 
                Name = "Cleaner",
                NormalizedName = "CLEANER",
                Id = ROLEROLEROLE_ID,
                ConcurrencyStamp = ROLEROLEROLE_ID
                });

            //create user
            var appUser = new List<Användare>
            { new Användare {
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
                },
                new Användare {
                Id = RECEPTION_ID,
                Email = "Abosolut@gmail.com",
                NormalizedEmail = "ABOSOLUT@GMAIL.COM",
                EmailConfirmed = true,
                Namn = "Absolut",
                Efternamn = "Vodka",
                UserName = "Abosolut@gmail.com",
                NormalizedUserName = "ABSOLUT@GMAIL.COM",
                PhoneNumber = "0784545884",
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
                },
                     new Användare {
                Id = CLEANER_ID,
                Email = "clean@gmail.com",
                NormalizedEmail = "CLEAN@GMAIL.COM",
                EmailConfirmed = true,
                Namn = "STÄD",
                Efternamn = "STÄD",
                UserName = "clean@gmail.com",
                NormalizedUserName = "CLEAN@GMAIL.COM",
                PhoneNumber = "0748612345",
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
                },
            }
            ;

            //set user password
            PasswordHasher<Användare> ph = new PasswordHasher<Användare>();
            appUser[0].PasswordHash = ph.HashPassword(appUser[0], "QWEasd!1");
            appUser[1].PasswordHash = ph.HashPassword(appUser[1], "QWEasd!1");
            appUser[2].PasswordHash = ph.HashPassword(appUser[2], "QWEasd!1");

            //seed user
            builder.Entity<Användare>().HasData(appUser);

            //set user role to admin
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLEROLE_ID,
                UserId = RECEPTION_ID
            });
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLEROLEROLE_ID,
                UserId = CLEANER_ID
            });


        }
    }
}

