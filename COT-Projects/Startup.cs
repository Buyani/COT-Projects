using COT_Projects.Data.Persistance;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using COT_Projetcs.Service;
using AutoMapper;
using COT_Projects.Business.DataMappers;
using COT_Projetcs.Service.ReportService;
using COT_Projetcs.Service.CurrencyService;
using COT_Projects.Business.CurrencyBusiness;
using COT_Projects.Business.ReportBusiness;
using COT_Projects.Business.AccountBusiness;

namespace COT_Projects
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Register aoutomappers here
            services.AddAutoMapper(typeof(AutoMapping));
            //register services here
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<ICurrencyRepository, CurrencyRepository>();
            services.AddTransient<ICurrencyBusiness, CurrencyBusiness>();
            services.AddScoped<IReportRepository, ReportRepository>();
            services.AddScoped<IReportBusiness, ReportBusiness>();
            services.AddScoped<ILogInBusiness, LogInBusiness>();
            services.AddScoped<IRegisterBusiness, RegisterBusiness>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            //*

            services.AddDbContext<COT_ProjectDataContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("CotConnection")));
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<COT_ProjectDataContext>();

            services.Configure<PasswordHasherOptions>(options =>
                options.CompatibilityMode = PasswordHasherCompatibilityMode.IdentityV3);
            services.AddControllersWithViews();
            services.AddRazorPages();

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = $"/account/login";
                options.LogoutPath = $"/account/logout";
                options.AccessDeniedPath = $"/account/accessDenied";
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Currency}/{action=Reports}/{id?}");
            });
        }
    }
}
