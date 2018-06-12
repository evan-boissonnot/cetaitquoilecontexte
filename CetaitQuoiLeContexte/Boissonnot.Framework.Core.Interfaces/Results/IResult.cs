using System;
using System.Collections.Generic;
using System.Text;

namespace Boissonnot.Framework.Core.Interfaces.Results
{
    public interface IResult<Titem> 
                     where Titem : class
    {
        /// <summary>
        /// Nombre total d'éléments
        /// </summary>
        int FullResultNumber { get; set; }

        /// <summary>
        /// Permet de savoir s'il y a d'autres items
        /// </summary>
        bool HasNextItems { get; set; }

        /// <summary>
        /// Item courant
        /// </summary>
        Titem Item { get; set; }
    }
}
