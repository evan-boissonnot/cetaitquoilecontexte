using Boissonnot.Framework.Core.Interfaces.Results;
using CetaitQuoiLeContexte.Core.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace CetaitQuoiLeContexte.Core.Business.WebService.Access.Models.Temps
{
    public class ListContextResult : IResult<List<IContext>>
    {
        #region Properties
        public int FullResultNumber { get; set; }

        public List<IContext> Item { get; set; }

        public bool HasNextItems { get; set; }
        #endregion
    }
}
