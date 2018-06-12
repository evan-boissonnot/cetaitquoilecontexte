using Boissonnot.Framework.Core.Interfaces.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boissonnot.Framework.Core.Interfaces.Business
{
    public interface IParentBusiness<T> where T : Data.IParentModel
    {
        /// <summary>
        /// Sélectionne une liste d'éléments
        /// </summary>
        /// <returns></returns>
        IResult<List<T>> SelectAll();

        /// <summary>
        /// Sélectionne une liste d'éléments avec des filtres
        /// </summary>
        /// <param name="filter">Item de filtre</param>
        /// <returns></returns>
        IResult<List<T>> SelectAll(Filters.IParentFilter<T> filter);

        /// <summary>
        /// Sélectionne un élément par son id
        /// </summary>
        /// <param name="id">ID de l'élément</param>
        /// <returns></returns>
        T SelectOne(int id);

        /// <summary>
        /// Enregistre un élément (ajout ou modification)
        /// </summary>
        /// <param name="item">Item à ajouter</param>
        void Save(T item);

        /// <summary>
        /// Supprime un élément
        /// </summary>
        /// <param name="item">Elément à supprimer</param>
        void DeleteOne(T item);

        /// <summary>
        /// Supprime un élément par son id
        /// </summary>
        /// <param name="id">id de l'élément</param>
        void DeleteOne(int id);
    }
}
