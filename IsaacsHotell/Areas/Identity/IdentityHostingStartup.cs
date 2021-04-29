using System;
using IsaacsHotell.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(IsaacsHotell.Areas.Identity.IdentityHostingStartup))]
namespace IsaacsHotell.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {

                services.AddAuthorization(options =>
                {
                    options.AddPolicy("Cleaner",
                        builder => builder.RequireRole( "Admin", "Reception", "Cleaner"));
                    options.AddPolicy("Reception",
                        builder => builder.RequireRole("Admin", "Cleaner"));
                    options.AddPolicy("Admin",
                        builder => builder.RequireRole("Admin"));
                });
            });
        }
    }
}