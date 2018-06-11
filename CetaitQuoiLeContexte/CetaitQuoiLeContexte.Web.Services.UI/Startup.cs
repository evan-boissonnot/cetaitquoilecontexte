using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Boissonnot.Framework.Core.Interfaces.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace CetaitQuoiLeContexte.Web.Services.UI
{
    public class Startup
    {
        #region Fields
        private IDatabaseInitializer _dbInitializer = null;
        #endregion

        #region Constructors
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        #endregion

        #region Public methods
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options =>
            {
                options.ModelBinderProviders.Insert(0, new Binders.ContextBinderProvider());
            });

            services.AddDbContext<Core.Data.DataDbContext>(options =>
                                                           options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddSingleton<IDatabaseInitializer, Core.Data.DbInitializer>();

            services.AddTransient<Core.Interfaces.Data.IPerson, Core.Data.Person>();
            services.AddTransient<Core.Interfaces.Data.IContext, Core.Data.Context>();

            services.AddTransient<Core.Interfaces.Business.IContextBusiness, Core.Business.ContextBusiness>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,
                              ILoggerFactory loggerFactory, IServiceProvider serviceProvider,
                              Core.Data.DataDbContext context)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseMvc(option =>
            {
                // 05/06/2018 : custom routes
            });            

            this._dbInitializer = serviceProvider.GetService<IDatabaseInitializer>();
            this._dbInitializer.Initialize(context);
        }
        #endregion

        #region Properties
        public IConfiguration Configuration { get; }
        #endregion
    }
}
