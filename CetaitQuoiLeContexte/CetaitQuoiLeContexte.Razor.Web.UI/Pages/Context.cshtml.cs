using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CetaitQuoiLeContexte.Core.Interfaces.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CetaitQuoiLeContexte.Razor.Web.UI.Pages
{
    public class ContextModel : PageModel
    {
        #region Fields
        private IContextAsAsyncBusiness _business = null;
        #endregion

        #region Constructrors
        public ContextModel(IContextAsAsyncBusiness business)
        {
            this._business = business;
        }
        #endregion

        #region Public methods
        public void OnGet(string title)
        {
            this.Title = title;
        }
        #endregion

        #region Properties
        public string Title { get; set; }
        #endregion
    }
}