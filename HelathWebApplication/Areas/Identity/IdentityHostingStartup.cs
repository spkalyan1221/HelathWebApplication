using System;
using HelathWebApplication.Areas.Identity.Data;
using HelathWebApplication.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(HelathWebApplication.Areas.Identity.IdentityHostingStartup))]
namespace HelathWebApplication.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<HelathDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("HelathDbContextConnection")));

                services.AddDefaultIdentity<HelathWebApplicationUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = true;
                    options.Password.RequireUppercase = true;
                })


                    .AddEntityFrameworkStores<HelathDbContext>();
            });
        }
    }
}