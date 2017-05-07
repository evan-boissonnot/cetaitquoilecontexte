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
        /// FIltre par les attributs de l'item en cours
        /// </summary>
        T Model { get; set; }
    }
}
