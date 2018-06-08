using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CetaitQuoiLeContexte.Core.Business.Filters;
using CetaitQuoiLeContexte.Core.Interfaces.Business;
using CetaitQuoiLeContexte.Core.Interfaces.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace CetaitQuoiLeContexte.Razor.Web.UI.Pages
{
    public class IndexModel : PageModel
    {
        #region Fields
        private Data.AppSettings _settings = null;
        private IContextAsAsyncBusiness _business = null;
        private List<IContext> _list = null;
        #endregion

        #region Constructors
        public IndexModel(IContextAsAsyncBusiness business, IOptions<Data.AppSettings> settings)
        {
            this._business = business;
            this._settings = settings.Value;
        }
        #endregion

        #region Public methods
        public async Task OnGetAsync()
        {
            this.ContextList = await this._business.SelectAll(new ContextFilter()
            {
                TakenNumber = this._settings.ContextNbItems
            });
        }
        #endregion

        #region Properties
        public List<IContext> ContextList { get => this._list; set => this._list = value; }
        #endregion
    }
}
