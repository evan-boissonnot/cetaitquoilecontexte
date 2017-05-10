using Boissonnot.Framework.Core.Interfaces.Data;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CetaitQuoiLeContexte.Core.DependanceInjection
{
    public static class Loader
    {
        #region Public methods
        /// <summary>
        /// Configure les injections de dépendances
        /// </summary>
        /// <param name="services"></param>
        public static void Configure(this IServiceCollection services)
        {
            services.AddTransient<IDatabaseInitializer, Core.Data.DbInitializer>();

            ConfigureModels(services);
            ConfigureServices(services);
        }
        #endregion

        #region Internal methods
        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<Core.Interfaces.Business.IContextBusiness, Core.Business.ContextBusiness>();
        }

        private static void ConfigureModels(IServiceCollection services)
        {
            services.AddTransient<Core.Interfaces.Data.IContext, Core.Data.Context>();
            services.AddTransient<Core.Interfaces.Data.IPerson, Core.Data.Person>();
        }
        #endregion
    }
}
