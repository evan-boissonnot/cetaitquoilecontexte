using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CetaitQuoiLeContexte.Core.Interfaces.Business;
using CetaitQuoiLeContexte.Core.Interfaces.Data;
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
            this.Business = business;
        }
        #endregion

        #region Public methods
        public virtual async Task OnGetAsync(string title)
        {
            this.Title = title;

            await this.SelectOneContext(title);
        }
        #endregion

        #region Internal methods
        /// <summary>
        /// Recherche un context par son titre
        /// </summary>
        /// <param name="title">Titre recherché</param>
        /// <returns></returns>
        virtual protected async Task SelectOneContext(string title)
        {
            this.Current = await this.Business.SelectOne(title);
        }
        #endregion

        #region Properties
        public string Title { get; set; }

        public IContext Current { get; set; }

        /// <summary>
        /// Business pour agir sur les contextes
        /// </summary>
        public IContextAsAsyncBusiness Business { get => this._business; set => this._business = value; }
        #endregion
    }
}