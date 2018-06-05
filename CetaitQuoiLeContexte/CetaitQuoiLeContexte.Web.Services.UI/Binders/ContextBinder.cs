using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CetaitQuoiLeContexte.Web.Services.UI.Binders
{
    public class ContextBinder : IModelBinder
    {
        #region Public methods
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
