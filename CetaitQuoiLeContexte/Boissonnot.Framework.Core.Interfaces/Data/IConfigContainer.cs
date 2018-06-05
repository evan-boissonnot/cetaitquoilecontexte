using System;
using System.Collections.Generic;
using System.Text;

namespace Boissonnot.Framework.Core.Interfaces.Data
{
    public interface IConfigContainer
    {
        /// <summary>
        /// Chaîne de connexion
        /// </summary>
        string ConnnectionString { get; }
    }
}
