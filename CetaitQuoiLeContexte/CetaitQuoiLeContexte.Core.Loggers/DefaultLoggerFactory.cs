using CetaitQuoiLeContexte.Core.Data.Loggers;
using CetaitQuoiLeContexte.Core.Loggers;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace CetaitQuoiLeContexte.Core.Data
{
    public class DefaultLoggerFactory : LoggerFactory
    {
        #region Constructors
        public DefaultLoggerFactory(ILogger logger)
        {
            this.AddProvider(new DatabaseLoggerProvider(logger));
        }
        #endregion
    }
}
