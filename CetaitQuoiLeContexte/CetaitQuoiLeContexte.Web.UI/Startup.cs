using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using CetaitQuoiLeContexte.Core.DependanceInjection;
using Boissonnot.Framework.Core.Interfaces.Data;

namespace CetaitQuoiLeContexte.Web.UI
{
    public class Startup
    {
        #region Fields
        private IDatabaseInitializer _dbInitializer = new Core.Data.DbInitializer();
        #endregion

        #region Constructors
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }
        #endregion

        #region Properties
        public IConfigurationRoot Configuration { get; }
        #endregion

        #region Public methods
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();

            services.AddDbContext<Core.Data.DataDbContext>(options =>
                                                           options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.Configure();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,
                              ILoggerFactory loggerFactory, IServiceProvider serviceProvider,
                              Core.Data.DataDbContext context)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            this._dbInitializer = serviceProvider.GetService<IDatabaseInitializer>();
            this._dbInitializer.Initialize(context);

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
        #endregion
    }
}
