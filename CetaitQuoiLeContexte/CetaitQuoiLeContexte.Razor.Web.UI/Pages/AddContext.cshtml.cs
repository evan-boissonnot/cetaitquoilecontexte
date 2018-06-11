using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CetaitQuoiLeContexte.Core.Business.WebService.Access;
using CetaitQuoiLeContexte.Core.Interfaces.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CetaitQuoiLeContexte.Razor.Web.UI.Pages
{
    public class AddContextModel : PageModel
    {
        #region Fields
        private IContext _context = null;
        private IServiceProvider _provider = null;
        #endregion

        #region Constructors
        public AddContextModel(IServiceProvider provider)
        {
            this._provider = provider;
        }
        #endregion

        #region Public methods
        public void OnGet()
        {
        }

        public void OnPost(IContext context)
        {

        }
        #endregion

        #region Properties
        [BindProperty]
        public IContext Item { get => this._context; set => this._context = value; }
        #endregion
    }
}