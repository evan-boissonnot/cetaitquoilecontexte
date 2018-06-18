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
        public async Task OnGetAsync(string indexPage)
        {
            int index = 0;

            if (!string.IsNullOrEmpty(indexPage))
                int.TryParse(indexPage, out index);

            IResult<List<IContext>> result = await this._business.SelectAll(new ContextFilter()
            {
                TakenNumber = this._settings.ContextNbItems,
                IndexPage = index
            });

            this.ContextList = result.Item;
            this.IsNextPageExists = result.HasNextItems;
            this.IsPreviousExists = index > 0;


            this.NextPageIndex = index + 1;

            if(index - 1 >= 0)
                this.PreviousPageIndex = index - 1;
        }
        #endregion

        #region Properties
        public List<IContext> ContextList { get => this._list; set => this._list = value; }

        /// <summary>
        /// Permet de savoir si on peut passer à la page suivante
        /// </summary>
        public bool IsNextPageExists { get; set; }

        /// <summary>
        /// Permet de savoir si on peut revenir à la page précédente
        /// </summary>
        public bool IsPreviousExists { get; set; }

        /// <summary>
        /// Index de la page suivante
        /// </summary>
        public int NextPageIndex { get; set; }

        /// <summary>
        /// Index de la page précédente
        /// </summary>
        public int PreviousPageIndex { get; set; }
        #endregion
    }
}
