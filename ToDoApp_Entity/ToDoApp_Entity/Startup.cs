using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using ToDo.App.DataAccess;
using ToDo.App.DataAccess.Repositories;
using ToDo.App.DataAccess.Repositories.EntityRepositories;
using ToDo.App.Domain;
using ToDo.App.Services.Helpers;
using ToDoApp.Services.Services;

namespace ToDo.App.Remastered.DataAccess
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

            services.AddMvc();
            var connection = @"Server=(localdb)\mssqllocaldb;Database=ToDoAppDbContext;Trusted_Connection=True";
            services.AddDbContext<ToDoAppDbContext>(options => options.UseSqlServer(connection));
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddScoped<IRepository<User>, UserEntityRepository>();
            services.AddScoped<IRepository<_Task_>, TaskEntityRepository>();

            DIRmodule.RegisterRepositories(services);
            //const string connectionString = "Server=.;Database=TaskDB;Trusted_Connection=True";

            //services.AddDbContext<ToDoAppDbContext>(options => options.UseSqlServer(connection, b => b.MigrationsAssembly(connectionString)));
            var connectionString = Configuration.GetValue<string>("ConnectionString");
            services.AddDbContext<ToDoAppDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
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
            }

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
