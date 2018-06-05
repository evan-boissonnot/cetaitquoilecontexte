using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CetaitQuoiLeContexte.Core.Interfaces.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CetaitQuoiLeContexte.Razor.Web.UI.Pages
{
    public class IndexModel : PageModel
    {
        #region Fields
        private IContextBusiness _business = null;
        #endregion

        #region Constructors
        public IndexModel(IContextBusiness business)
        {
            this._business = business;
        }
        #endregion

        #region Public methods
        public void OnGet()
        {

        }
        #endregion
    }
}
