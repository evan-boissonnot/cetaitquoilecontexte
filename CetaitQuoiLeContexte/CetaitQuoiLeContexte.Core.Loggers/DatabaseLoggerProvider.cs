using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace CetaitQuoiLeContexte.Core.Data.Loggers
{
    public class DatabaseLoggerProvider : ILoggerProvider
    {
        #region Fields
        private ILogger _logger = null;
        #endregion

        #region Constructors
        public DatabaseLoggerProvider(ILogger logger)
        {
            this._logger = logger;
        }
        #endregion

        #region Public methods
        public ILogger CreateLogger(string categoryName)
        {
            return this._logger;
        }

        public void Dispose() {}
        #endregion
    }
}
