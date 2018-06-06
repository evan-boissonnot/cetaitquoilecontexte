﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CetaitQuoiLeContexte.Core.Interfaces.Business;
using CetaitQuoiLeContexte.Core.Interfaces.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CetaitQuoiLeContexte.Razor.Web.UI.Pages
{
    public class IndexModel : PageModel
    {
        #region Fields
        private IContextAsAsyncBusiness _business = null;
        private List<IContext> _list = null;
        #endregion

        #region Constructors
        public IndexModel(IContextAsAsyncBusiness business)
        {
            this._business = business;
        }
        #endregion

        #region Public methods
        public async Task OnGetAsync()
        {
            this.ContextList = await this._business.SelectAll();
        }
        #endregion

        #region Properties
        public List<IContext> ContextList { get => this._list; set => this._list = value; }
        #endregion
    }
}
