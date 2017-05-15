using CetaitQuoiLeContexte.Core.Interfaces.Business;
using CetaitQuoiLeContexte.Core.Interfaces.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace CetaitQuoiLeContext.Core.Web.Controllers
{
    public class ContextController : Controller
    {
        #region Fields
        private IContextBusiness _business = null;
        private IServiceProvider _serviceProvider = null;
        #endregion

        #region Constructors
        public ContextController(IContextBusiness business, IServiceProvider serviceProvider)
        {
            this._business = business;
            this._serviceProvider = serviceProvider;
        }
        #endregion

        #region Public methods

        public IActionResult Add(string value)
        {
            IContext context = null;

            dynamic result = new {
                State = "OK",
                Item = context
            };



            return this.Json(result);
        }
        #endregion  
    }
}
