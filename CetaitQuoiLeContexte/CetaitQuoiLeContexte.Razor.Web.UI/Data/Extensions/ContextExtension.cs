using CetaitQuoiLeContexte.Core.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Boissonnot.Framework.Core.Extensions;

namespace CetaitQuoiLeContexte.Razor.Web.UI.Data.Extensions
{
    public static class ContextExtension
    {
        #region Public methods
        /// <summary>
        /// Transforme un titre en url 
        /// </summary>
        /// <param name="context">Context à formatter</param>
        /// <returns></returns>
        public static string ToUrlTitle(this IContext context)
        {
            return context?.Message.ToUrl();
        }
        #endregion
    }
}
