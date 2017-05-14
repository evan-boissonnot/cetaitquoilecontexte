using Boissonnot.Framework.Core.Interfaces.Filters;
using CetaitQuoiLeContexte.Core.Data;
using CetaitQuoiLeContexte.Core.Interfaces.Business;
using CetaitQuoiLeContexte.Core.Interfaces.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CetaitQuoiLeContext.Core.Web.Controllers
{
    public class HomeController : Controller
    {
        #region Fields
        private IContextBusiness _business = null;
        private IServiceProvider _serviceProvider = null;
        #endregion

        #region Constructors
        public HomeController(IContextBusiness business, IServiceProvider serviceProvider)
        {
            this._business = business;
            this._serviceProvider = serviceProvider;            
        }
        #endregion

        #region Public methods
        public IActionResult Index()
        {
            IParentFilter<IContext> filter = this._serviceProvider.GetService<IParentFilter<IContext>>();

            return this.View(this._business.SelectAll());
        }
        #endregion
    }
}
