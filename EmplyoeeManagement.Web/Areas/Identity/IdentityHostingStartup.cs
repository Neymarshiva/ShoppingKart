using System;
using EmplyoeeManagement.Web.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(EmplyoeeManagement.Web.Areas.Identity.IdentityHostingStartup))]
namespace EmplyoeeManagement.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<EmplyoeeManagementWebContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("EmplyoeeManagementWebContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<EmplyoeeManagementWebContext>();
            });
        }
    }
}