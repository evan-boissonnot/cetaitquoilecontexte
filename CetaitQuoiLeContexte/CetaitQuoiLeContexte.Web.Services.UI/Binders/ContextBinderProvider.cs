using CetaitQuoiLeContexte.Core.Interfaces.Data;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CetaitQuoiLeContexte.Web.Services.UI.Binders
{
    public class ContextBinderProvider : IModelBinderProvider
    {
        #region Public methods
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            IModelBinder binder = null;

            if (context.Metadata.ModelType == typeof(IContext))
                binder = new ContextBinder();

            return binder;
        }
        #endregion
    }
}
