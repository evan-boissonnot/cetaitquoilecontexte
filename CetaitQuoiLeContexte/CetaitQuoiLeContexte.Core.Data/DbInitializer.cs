using CetaitQuoiLeContexte.Core.Interfaces.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CetaitQuoiLeContexte.Core.Data
{
    public class DbInitializer : Boissonnot.Framework.Core.Interfaces.Data.IDatabaseInitializer
    {
        #region Public methods
        public void Initialize(DbContext context)
        {
            context.Database.EnsureCreated();
        }
        #endregion
    }
}
