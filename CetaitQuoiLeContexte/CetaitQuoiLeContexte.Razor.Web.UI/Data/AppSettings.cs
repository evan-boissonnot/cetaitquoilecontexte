using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CetaitQuoiLeContexte.Razor.Web.UI.Data
{
    public class AppSettings : IAppSettings
    {
        #region Properties
        /// <summary>
        /// Nombre de context à charger sur chaque page
        /// </summary>
        public int ContextNbItems { get; set; }
        #endregion
    }
}
