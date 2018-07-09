using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CetaitQuoiLeContexte.Core.Business.WebService.Access;
using CetaitQuoiLeContexte.Core.Interfaces.Business;
using CetaitQuoiLeContexte.Core.Interfaces.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CetaitQuoiLeContexte.Razor.Web.UI.Pages
{
    public class AddContextModel : PageModel
    {
        #region Fields
        private PocoContext _context = null;
        private IServiceProvider _provider = null;
        private IContextAsAsyncBusiness _business = null;
        #endregion

        #region Constructors
        public AddContextModel(IServiceProvider provider, IContextAsAsyncBusiness business)
        {
            this._provider = provider;
            this._business = business;
        }
        #endregion

        #region Public methods
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(IContext context)
        {
            IActionResult result = this.Page();

            if (ModelState.IsValid)
            {
                await this._business.Save(context);
                result = this.RedirectToPage("/Index", new { indexPage = 0 });
            }

            return result;
        }
        #endregion

        #region Properties
        public PocoContext Item { get => this._context; set => this._context = value; }
        #endregion
    }
}