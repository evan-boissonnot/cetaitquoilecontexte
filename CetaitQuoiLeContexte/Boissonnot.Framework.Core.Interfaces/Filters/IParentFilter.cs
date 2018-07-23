using System;
using System.Collections.Generic;
using System.Text;

namespace Boissonnot.Framework.Core.Interfaces.Filters
{
    public interface IParentFilter<T> where T : Data.IParentModel
    {
        /// <summary>
        /// Filtre par l'id
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Nombre d'éléments à prendre
        /// </summary>
        int? TakenNumber { get; set; }

        /// <summary>
        /// Index de la page d'items
        /// </summary>
        int? IndexPage { get; set; }

        /// <summary>
        /// Valide si on cherche un context au hasard
        /// </summary>
        bool? IsRandomGet { get; set; }

        /// <summary>
        /// FIltre par les attributs de l'item en cours
        /// </summary>
        T Model { get; set; }
    }
}
