using CetaitQuoiLeContexte.Core.Interfaces.Data;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
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
            IContext context = (IContext)this._provider.GetService(typeof(IContext));

            

            bindingContext.Result = ModelBindingResult.Success(context);

            return Task.CompletedTask;
        }
        #endregion
    }
}
