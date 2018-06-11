using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Boissonnot.Framework.Core.Interfaces.Business
{
    public interface IParentAsAsyncBusiness<T> where T : Data.IParentModel
    {
        /// <summary>
        /// Sélectionne une liste d'éléments
        /// </summary>
        /// <returns></returns>
        Task<List<T>> SelectAll();

        /// <summary>
        /// Sélectionne une liste d'éléments avec des filtres
        /// </summary>
        /// <param name="filter">Item de filtre</param>
        /// <returns></returns>
        Task<List<T>> SelectAll(Filters.IParentFilter<T> filter);

        /// <summary>
        /// Sélectionne un élément par son id
        /// </summary>
        /// <param name="id">ID de l'élément</param>
        /// <returns></returns>
        Task<T> SelectOne(int id);

        /// <summary>
        /// Sélectionne un élément par son titre, label (formatté)
        /// </summary>
        /// <param name="title">ID de l'élément</param>
        /// <returns></returns>
        Task<T> SelectOne(string title);

        /// <summary>
        /// Enregistre un élément (ajout ou modification)
        /// </summary>
        /// <param name="item">Item à ajouter</param>
        Task Save(T item);

        /// <summary>
        /// Supprime un élément
        /// </summary>
        /// <param name="item">Elément à supprimer</param>
        Task DeleteOne(T item);

        /// <summary>
        /// Supprime un élément par son id
        /// </summary>
        /// <param name="id">id de l'élément</param>
        Task DeleteOne(int id);
    }
}
