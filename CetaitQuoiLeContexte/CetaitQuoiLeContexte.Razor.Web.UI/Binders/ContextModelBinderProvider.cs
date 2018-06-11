using CetaitQuoiLeContexte.Core.Interfaces.Data;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CetaitQuoiLeContexte.Razor.Web.UI.Binders
{
    public class ContextModelBinderProvider : IModelBinderProvider
    {
        #region Public methods
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            IModelBinder binder = null;

            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (context.Metadata.ModelType == typeof(IContext))
                binder = new BinderTypeModelBinder(typeof(ContextModelBinder));

            return binder;
        }
        #endregion
    }
}
