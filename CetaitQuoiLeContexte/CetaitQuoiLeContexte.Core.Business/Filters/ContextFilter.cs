﻿using System;
using System.Collections.Generic;
using System.Text;
using CetaitQuoiLeContexte.Core.Interfaces.Data;
using Boissonnot.Framework.Core.Interfaces.Filters;

namespace CetaitQuoiLeContexte.Core.Business.Filters
{
    public class ContextFilter : IParentFilter<Core.Interfaces.Data.IContext>
    {
        #region Properties
        public int Id { get; set; }

        public IContext Model { get; set; }
        #endregion
    }
}