using Boissonnot.Framework.Core.Interfaces.Results;
using CetaitQuoiLeContexte.Core.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace CetaitQuoiLeContexte.Core.Business.WebService.Access.Models
{
    public class ListPocoContextResult : IResult<List<PocoContext>>
    {
        #region Properties
        public int FullResultNumber { get; set; }

        public List<PocoContext> Item { get; set; }

        public bool HasNextItems { get; set; }
        #endregion
    }
}
