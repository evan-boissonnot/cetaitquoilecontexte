using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boissonnot.Framework.Core.Interfaces.Data
{
    public interface IDatabaseInitializer
    {
        /// <summary>
        /// Initialisation de la base de données
        /// </summary>
        /// <param name="context">Context à initialiser</param>
        void Initialize(DbContext context);
    }
}
