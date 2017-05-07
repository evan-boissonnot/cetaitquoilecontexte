﻿using Microsoft.Extensions.DependencyInjection;
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
            ConfigureModels(services);
            ConfigureServices(services);
        }
        #endregion

        #region Internal methods
        private static void ConfigureServices(IServiceCollection services)
        {

        }

        private static void ConfigureModels(IServiceCollection services)
        {
            services.AddTransient<Core.Interfaces.Data.IContext, Core.Data.Context>();
            services.AddTransient<Core.Interfaces.Data.IPerson, Core.Data.Person>();
        }
        #endregion
    }
}
