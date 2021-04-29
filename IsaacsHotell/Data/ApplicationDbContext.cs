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
            string ADMIN_ID = "02174cf0–9412–4cfe-afbf-59f706d72cf6"; //unika keys för varje användare
            string ADMINADMIN_ID = "02123cf0–9652–4cde-afaf-59f706c72cf6";
            string RECEPTION_ID =  "452349f0-da4s–5d6s-pqwe-59kmoldp78df6";
            string RECEPTIONRECEPTION_ID = "451029f0-da4s–5css-pawe-59kmolad21df6";
            string RECEPTIONRECEPTIONRECEPTION_ID = "446929f0-dv2s–5csr-aawe-59ktylad21df6";
            string CLEANER_ID = "569842f0-78dw–65ws-qwbf-59dafgqw345f6";
            string CLEANERCLEANER_ID = "569878f0-71bw–6hwq-qnmf-59dafgqg035f6";


            string ROLE_ID = "341743f0-asd2–42de-afbf-59kmkkmk72cf6";//admin rollen
            string ROLEROLE_ID = "334567f0-whj2–47de-atyf-59qbvcse96cf6";//reception rollen
            string ROLEROLEROLE_ID = "912345f0-hgd2–41ae-vnqf-59ghjknm72cf6";//lokalvårdar rollen

            //seed admin role

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "Admin",
                NormalizedName = "ADMIN",
                Id = ROLE_ID,
                ConcurrencyStamp = ROLE_ID
            },
            new IdentityRole
            {
                Name = "Reception",
                NormalizedName = "RECEPTION",
                Id = ROLEROLE_ID,
                ConcurrencyStamp = ROLEROLE_ID
            },
            new IdentityRole
            {
                Name = "Cleaner",
                NormalizedName = "CLEANER",
                Id = ROLEROLEROLE_ID,
                ConcurrencyStamp = ROLEROLEROLE_ID
            });


            //inlogg  mrwagner, mrswagner, algot, berit, ceasar, alva, bernard

            //create user
            var appUser = new List<Användare>
            { new Användare {
                Id = ADMIN_ID,
                Email = "Mrwagner@hotellet.se",
                NormalizedEmail = "mrwagner@HOTELLET.SE",
                EmailConfirmed = true,
                Namn = "Karl",
                Efternamn = "Wagner",
                UserName = "mrwagner@hotellet.se",
                NormalizedUserName = "MRWAGNER@HOTELLET.SE",
                PhoneNumber = "0713371337",
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
                },
                 new Användare {
                Id = ADMINADMIN_ID,
                Email = "Mrswagner@hotellet.se",
                NormalizedEmail = "mrswagner@HOTELLET.SE",
                EmailConfirmed = true,
                Namn = "Amanda",
                Efternamn = "Wagner",
                UserName = "mrswagner@hotellet.se",
                NormalizedUserName = "MRSWAGNER@HOTELLET.SE",
                PhoneNumber = "0713371338",
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
                },
                 new Användare {
                Id = RECEPTION_ID,
                Email = "Algot@hotellet.se",
                NormalizedEmail = "Algot@HOTELLET.SE",
                EmailConfirmed = true,
                Namn = "Algot",
                Efternamn = "Algotsson",
                UserName = "Algot@hotellet.se",
                NormalizedUserName = "ALGOT@HOTELLET.SE",
                PhoneNumber = "0784545884",
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
                },
                    new Användare {
                Id = RECEPTIONRECEPTION_ID,
                Email = "Berit@hotellet.se",
                NormalizedEmail = "BERIT@HOTELLET.SE",
                EmailConfirmed = true,
                Namn = "Berit",
                Efternamn = "Beritsson",
                UserName = "berit@hotellet.se",
                NormalizedUserName = "BERIT@HOTELLET.SE",
                PhoneNumber = "0784545884",
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
                },
                    new Användare {
                Id = RECEPTIONRECEPTIONRECEPTION_ID,
                Email = "Ceasar@hotellet.se",
                NormalizedEmail = "Ceasar@HOTELLET.SE",
                EmailConfirmed = true,
                Namn = "Ceasar",
                Efternamn = "Stark",
                UserName = "Ceasar@hotellet.se",
                NormalizedUserName = "CEASAR@HOTELLET.SE",
                PhoneNumber = "0784545884",
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
                },
                     new Användare {
                Id = CLEANER_ID,
                Email = "Bernard@hotellet.se",
                NormalizedEmail = "BERNARD@HOTELLET.SE",
                EmailConfirmed = true,
                Namn = "Bernard",
                Efternamn = "Ruskie",
                UserName = "Bernard@hotellet.se",
                NormalizedUserName = "BERNARD@HOTELLET.SE",
                PhoneNumber = "0748612345",
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
                },
                   new Användare {
                Id = CLEANERCLEANER_ID,
                Email = "Alva@hotellet.se",
                NormalizedEmail = "ALVA@HOTELLET.SE",
                EmailConfirmed = true,
                Namn = "Alva",
                Efternamn = "Lotr",
                UserName = "Alva@hotellet.se",
                NormalizedUserName = "ALVA@HOTELLET.SE",
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
            appUser[3].PasswordHash = ph.HashPassword(appUser[3], "QWEasd!1");
            appUser[4].PasswordHash = ph.HashPassword(appUser[4], "QWEasd!1");
            appUser[5].PasswordHash = ph.HashPassword(appUser[5], "QWEasd!1");
            appUser[6].PasswordHash = ph.HashPassword(appUser[5], "QWEasd!1");

            //seed user
            builder.Entity<Användare>().HasData(appUser);

            //context userkey to rolekey
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            },
            new IdentityUserRole<string>
            {
                RoleId = ROLEROLEROLE_ID,
                UserId = CLEANERCLEANER_ID
            }, 
            new IdentityUserRole<string>
            {
                RoleId = ROLEROLEROLE_ID,
                UserId = CLEANER_ID
            },
            new IdentityUserRole<string>
            {
                RoleId = ROLEROLE_ID,
                UserId = RECEPTIONRECEPTIONRECEPTION_ID
            },
            new IdentityUserRole<string>
            {
                RoleId = ROLEROLE_ID,
                UserId = RECEPTIONRECEPTION_ID
            },
            new IdentityUserRole<string>
            {
                RoleId = ROLEROLE_ID,
                UserId = RECEPTION_ID
            },
            new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMINADMIN_ID
            });



            //builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            //{
            //    RoleId = ROLE_ID,
            //    UserId = ADMIN_ID
            //});
            //builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            //{
            //    RoleId = ROLE_ID,
            //    UserId = ADMINADMIN_ID
            //});

            //builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            //{
            //    RoleId = ROLEROLE_ID,
            //    UserId = RECEPTION_ID
            //});
            //builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            //{
            //    RoleId = ROLEROLE_ID,
            //    UserId = RECEPTIONRECEPTION_ID
            //});
            //builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            //{
            //    RoleId = ROLEROLE_ID,
            //    UserId = RECEPTIONRECEPTIONRECEPTION_ID
            //});
            //builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            //{
            //    RoleId = ROLEROLEROLE_ID,
            //    UserId = CLEANER_ID
            //});
            //builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            //{
            //    RoleId = ROLEROLEROLE_ID,
            //    UserId = CLEANERCLEANER_ID
            //});
            //builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            //{
            //    RoleId = ROLEROLE_ID,
            //    UserId = RECEPTION_ID
            //});
            //builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            //{
            //    RoleId = ROLEROLEROLE_ID,
            //    UserId = CLEANER_ID
            //});


        }
    }
}

