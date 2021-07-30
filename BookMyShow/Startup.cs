using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SimpleInjector;
using BookMyShow.Services;
using PetaPoco.NetCore;
using BookMyShow.Entities;
using BookMyShow.Services.Repositories.Interfaces;
using BookMyShow.Services.Repositories.Mock;
using BookMyShow.Services.AutoMapperProfiles;
using BookMyShow.Services;

namespace BookMyShow
{
    public class Startup
    {
        private readonly Container container = new Container();
        public Startup(IConfiguration configuration)
        {
            container.Options.ResolveUnregisteredConcreteTypes = false;

            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddScoped<DBContext>(x => {
                var options = new System.Data.SqlClient.SqlConnection(Configuration.GetConnectionString("BookMyShowConnection"));
                return new DBContext(options);
            });


            //MockRespository
            services.AddScoped<ILocationRepository, MockLocationRepository>();

            //Automapper DI
            services.AddAutoMapper(typeof(LocationProfile));

            //RegisterServices
            services.AddScoped<LocationService>();

            //services.AddCors();

            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });

            services.AddSimpleInjector(container, options =>
            {
                options.AddAspNetCore();
            });

            //InitializeContainer();
        }

        private void InitializeContainer()
        {
            //container.Register<ILocationRepository, LocationRepository>(Lifestyle.Scoped);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            /* app.UseCors(options => {
                options.WithOrigins("http://localhost:63402").AllowAnyMethod().AllowAnyHeader();
            }); */
            app.UseSimpleInjector(container);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            if (!env.IsDevelopment())
            {
                app.UseSpaStaticFiles();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "WebClient";

                if (env.IsDevelopment())
                {
                    spa.UseAngularCliServer(npmScript: "start");
                }
            });

            container.Verify();
        }
    }
}
