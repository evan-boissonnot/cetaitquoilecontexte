using Boissonnot.Framework.Core.Interfaces.Results;
using CetaitQuoiLeContexte.Core.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace CetaitQuoiLeContexte.Core.Business.Models
{
    public class ContextResult : IResult<IContext>
    {
        #region Properties
        public int FullResultNumber { get; set; }

        public IContext Item { get; set; }

        public bool HasNextItems { get; set; }
        #endregion
    }
}
