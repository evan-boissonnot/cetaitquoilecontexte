using Boissonnot.Framework.Core.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace CetaitQuoiLeContexte.Core.Data
{
    public class DefaultConfigContainer : IConfigContainer
    {
        #region Properties
        public string ConnnectionString => throw new NotImplementedException();
        #endregion
    }
}
