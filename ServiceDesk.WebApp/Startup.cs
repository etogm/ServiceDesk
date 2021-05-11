using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ServiceDesk.WebApp
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;

    using ServiceDesk.Domain;
    using ServiceDesk.Domain.Repositories;
    using ServiceDesk.Domain.Repositories.Abstract;
    using ServiceDesk.Domain.Repositories.EntityFrameworkCore;

    public sealed class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureApplicationCookie(
                options => options.LoginPath = "/Home/Index");

            services.AddDbContext<ServiceDeskContext>(
                options => options.UseNpgsql(Configuration.GetConnectionString("ServiceDesk")));

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<ServiceDeskContext>()
                .AddDefaultTokenProviders();

            services.AddTransient<IReportRepository, EfReportRepository>();
            services.AddTransient<DataManager>();

            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints => endpoints.MapControllerRoute(
                "default",
                "{controller=Home}/{action=Index}/{id?}"));
        }
    }
}
