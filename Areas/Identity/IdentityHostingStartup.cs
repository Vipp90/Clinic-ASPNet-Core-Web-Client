using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Strona.Areas.Identity.Data;
using Strona.Data;

[assembly: HostingStartup(typeof(Strona.Areas.Identity.IdentityHostingStartup))]
namespace Strona.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<DBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DBContextConnection")));

                services.AddDefaultIdentity<Patient_account>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<DBContext>();
            });
        }
    }
}