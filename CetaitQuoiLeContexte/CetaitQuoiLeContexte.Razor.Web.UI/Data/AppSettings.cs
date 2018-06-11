using CetaitQuoiLeContexte.Core.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CetaitQuoiLeContexte.Razor.Web.UI.Data
{
    public class AppSettings : IAppSettings
    {
        #region Properties
        public int ContextNbItems { get; set; }

        public string ApiUrl { get; set; }
        #endregion
    }
}
