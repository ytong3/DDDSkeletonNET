using DDDSkeleton.Portal.Domain.Customer;
using DDDSkeletonNET.Portal.ApplicationServices.Implementations;
using DDDSkeletonNET.Portal.ApplicationServices.Interfaces;
using DDDSkeletonNET.Portal.Repository.Memroy;
using DDDSkeletonNET.Portal.Repository.Memroy.Database;
using DDDSkeletonNET.Portal.Repository.Memroy.Repositories;
using DDDSkeletonNET.Portal.Repository.Memroy.UnitOfWork;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace DDDSkeletonNET.Portal.WebService
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddMvc(
                    config => { config.Filters.Add(typeof(DDSExceptionFilter)); }
                ).SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                        .AddJsonOptions(options =>
                        {
                            options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
                        });

            services.AddScoped<IUnitOfWork, InMemoryUnitOfWork>();
            services.AddScoped<IObjectContextFactory, LazySingletonObjectContextFactory>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ICustomerService, CustomerService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
