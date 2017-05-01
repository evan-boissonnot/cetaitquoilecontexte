using System;
using System.Collections.Generic;
using System.Text;

namespace CetaitQuoiLeContexte.Core.Interfaces.Data
{
    public interface IContext
    {
        /// <summary>
        /// Id de l'item
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Contenu du context
        /// </summary>
        string Message { get; set; }

        /// <summary>
        /// Auteur du contexte
        /// </summary>
        IPerson Author { get; set; }

        /// <summary>
        /// Date de création
        /// </summary>
        DateTime CreatedDate { get; set; }
    }
}
