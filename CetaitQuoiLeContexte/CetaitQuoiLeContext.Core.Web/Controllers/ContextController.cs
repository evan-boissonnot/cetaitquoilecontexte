using CetaitQuoiLeContexte.Core.Interfaces.Business;
using CetaitQuoiLeContexte.Core.Interfaces.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
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
            IContext context = this._serviceProvider.GetService<IContext>();
            IPerson person = this._serviceProvider.GetService<IPerson>();

            dynamic result = new {
                State = "OK",
                Item = context
            };

            context.Message = value;
            context.Author = person;

            context.Author.Name = "Context'man";

            this._business.Save(context);

            return this.Json(result);
        }
        #endregion  
    }
}
