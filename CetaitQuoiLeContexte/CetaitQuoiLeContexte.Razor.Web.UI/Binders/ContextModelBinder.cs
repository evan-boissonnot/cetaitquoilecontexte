using CetaitQuoiLeContexte.Core.Interfaces.Data;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CetaitQuoiLeContexte.Razor.Web.UI.Binders
{
    public class ContextModelBinder : IModelBinder
    {
        #region Fields
        private IServiceProvider _provider =null;
        #endregion

        #region Constructors
        public ContextModelBinder(IServiceProvider provider)
        {
            this._provider = provider;
        }
        #endregion

        #region Public methods
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            IContext context = null;
            Task currentTask = Task.CompletedTask;
            ValueProviderResult messageResult = bindingContext.ValueProvider.GetValue("Item.Message");
            ValueProviderResult fromResult = bindingContext.ValueProvider.GetValue("Item.From");
            ValueProviderResult nameResult = bindingContext.ValueProvider.GetValue("Item.Author.Name");
            ValueProviderResult emailResult = bindingContext.ValueProvider.GetValue("Item.Author.Email");

            if (messageResult != ValueProviderResult.None &&
                nameResult != ValueProviderResult.None &&
                emailResult != ValueProviderResult.None)
            {
                context = (IContext)this._provider.GetService(typeof(IContext));
                context.Author = (IPerson)this._provider.GetService(typeof(IPerson));

                context.Message = messageResult.FirstValue;
                context.From = fromResult.FirstValue;
                context.Author.Email = emailResult.FirstValue;
                context.Author.Name = nameResult.FirstValue;

                bindingContext.Result = ModelBindingResult.Success(context);
            }

            return currentTask;
        }
        #endregion
    }
}
