using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CetaitQuoiLeContexte.Core.Interfaces.Business;
using CetaitQuoiLeContexte.Core.Interfaces.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CetaitQuoiLeContexte.Razor.Web.UI.Pages
{
    public class RandomModel : ContextModel
    {
        #region Constructors
        public RandomModel(IContextAsAsyncBusiness business) : base(business) {}
        #endregion

        #region Public methods
        public async override Task OnGetAsync(string title)
        {
            IContext context = await this.Business.SelectOneWithRandomSearching();

            throw new NotImplementedException("Finir en redirigeant vers la page d'un context");
        }
        #endregion
    }
}