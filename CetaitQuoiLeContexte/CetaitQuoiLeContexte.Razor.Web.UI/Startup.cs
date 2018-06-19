using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CetaitQuoiLeContexte.Razor.Web.UI.Data;
using CetaitQuoiLeContexte.Razor.Web.UI.Services;
using CetaitQuoiLeContexte.Core.Interfaces.Business;
using CetaitQuoiLeContexte.Core.Business.WebService.Access;
using CetaitQuoiLeContexte.Core;
using Microsoft.Extensions.Options;
using CetaitQuoiLeContexte.Core.Interfaces;
using CetaitQuoiLeContexte.Razor.Web.UI.Binders;
using CetaitQuoiLeContexte.Core.Interfaces.Data;

namespace CetaitQuoiLeContexte.Razor.Web.UI
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
            services.AddOptions();

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient<IContext, PocoContext>();
            services.AddTransient<IPerson, PocoPerson>();
            services.AddTransient<IContextAsAsyncBusiness, ContextBusiness>();

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services
                .AddMvc(options =>
                {
                    options.ModelBinderProviders.Insert(0, new ContextModelBinderProvider());
                })
                .AddRazorPagesOptions(options =>
                {
                    options.Conventions.AuthorizeFolder("/Account/Manage");
                    options.Conventions.AuthorizePage("/Account/Logout");

                    options.Conventions.AddPageRoute("/Random", "au-hasard");
                    options.Conventions.AddPageRoute("/Context", "contexte/{title}");
                    options.Conventions.AddPageRoute("/AddContext", "contexte/nouveau");
                    options.Conventions.AddPageRoute("/Index", "page/{indexPage}");

                    //options.Conventions.AddPageRoute("/index", "{*url}");
                });

            // Register no-op EmailSender used by account confirmation and password reset during development
            // For more information on how to enable account confirmation and password reset please visit https://go.microsoft.com/fwlink/?LinkID=532713
            services.AddSingleton<IEmailSender, EmailSender>();

            services.Configure<Data.AppSettings>(this.Configuration.GetSection("AppSettings"));
            services.AddSingleton<IMotor>(Motor.Instance);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, 
                              IOptions<Data.AppSettings> settings, IServiceProvider provider)
        {
            Motor.Instance.Settings = settings.Value;

            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc();
        }
    }
}
