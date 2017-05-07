using System;
using System.Collections.Generic;
using System.Text;

namespace CetaitQuoiLeContexte.Core.Interfaces.Data
{
    public interface IPerson : Boissonnot.Framework.Core.Interfaces.Data.IParentModel
    {
        /// <summary>
        /// Prénom de la personne
        /// </summary>
        string Name { get; set; }
    }
}
