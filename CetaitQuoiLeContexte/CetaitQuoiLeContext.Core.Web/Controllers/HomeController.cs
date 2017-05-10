using CetaitQuoiLeContexte.Core.Data;
using CetaitQuoiLeContexte.Core.Interfaces.Business;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace CetaitQuoiLeContext.Core.Web.Controllers
{
    public class HomeController : Controller
    {
        #region Fields
        private IContextBusiness _business = null;
        #endregion

        #region Constructors
        public HomeController(IContextBusiness business)
        {
            this._business = business;
            
        }
        #endregion

        #region Public methods
        public IActionResult Index()
        {
            return this.View();
        }
        #endregion
    }
}
