using System;
using System.Collections.Generic;
using System.Text;

namespace CetaitQuoiLeContexte.Core.Interfaces.Data
{
    public interface IContext : Boissonnot.Framework.Core.Interfaces.Data.IParentModel
    {
        /// <summary>
        /// Contenu du context
        /// </summary>
        string Message { get; set; }

        /// <summary>
        /// Auteur du contexte
        /// </summary>
        IPerson Author { get; set; }

        /// <summary>
        /// Id de l'auteur
        /// </summary>
        int AuthorId { get; set; }

        /// <summary>
        /// Date de création
        /// </summary>
        DateTime CreatedDate { get; set; }
    }
}
