using CetaitQuoiLeContexte.Core.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CetaitQuoiLeContexte.Razor.Web.UI.Data
{
    public class PocoPerson : IPerson
    {
        #region Properties
        public string Name {get; set;}
        public int Id {get; set;}
        #endregion
    }
}
