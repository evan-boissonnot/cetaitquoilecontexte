using System;
using System.Collections.Generic;
using System.Text;

namespace CetaitQuoiLeContexte.Core.Interfaces.Data
{
    public interface IPerson
    {
        /// <summary>
        /// Id de la personne
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Prénom de la personne
        /// </summary>
        string Name { get; set; }
    }
}
