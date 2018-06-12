using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Boissonnot.Framework.Core.Interfaces.Results;
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
            IResult<List<IContext>> result = await this._business.SelectAll(new ContextFilter()
            {
                TakenNumber = this._settings.ContextNbItems
            });

            this.ContextList = result.Item;
            this.IsNextPageExists = result.HasNextItems;
        }
        #endregion

        #region Properties
        public List<IContext> ContextList { get => this._list; set => this._list = value; }

        /// <summary>
        /// Permet de savoir si on peut passer à la page suivante
        /// </summary>
        public bool IsNextPageExists { get; set; }
        #endregion
    }
}
