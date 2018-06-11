using CetaitQuoiLeContexte.Core.Data;
using CetaitQuoiLeContexte.Core.Interfaces.Data;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CetaitQuoiLeContexte.Web.Services.UI.Binders
{
    public class ContextBinder : IModelBinder
    {
        #region Fields
        private IServiceProvider _provider = null;
        #endregion

        #region Constructors
        public ContextBinder(IServiceProvider provider)
        {
            this._provider = provider;
        }
        #endregion

        #region Public methods
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            IContext context = null;

            using (StreamReader reader = new StreamReader(bindingContext.HttpContext.Request.Body))
            {
                string content = reader.ReadToEnd();
                context = Newtonsoft.Json.JsonConvert.DeserializeObject<Context>(content);
            }

            bindingContext.Result = ModelBindingResult.Success(context);

            return Task.CompletedTask;
        }
        #endregion
    }
}
