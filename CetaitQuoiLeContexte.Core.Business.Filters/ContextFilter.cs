using System;
using System.Collections.Generic;
using System.Text;
using CetaitQuoiLeContexte.Core.Interfaces.Data;
using Boissonnot.Framework.Core.Interfaces.Filters;

namespace CetaitQuoiLeContexte.Core.Business.Filters
{
    public class ContextFilter : IParentFilter<Core.Interfaces.Data.IContext>
    {
        #region Properties
        public int Id { get; set; }

        public IContext Model { get; set; }

        /// <summary>
        /// Date de création du contexte
        /// </summary>
        public DateTime BeginDate { get; set; }

        /// <summary>
        /// Provenance précisée
        /// </summary>
        public string From { get; set; }

        public int? TakenNumber { get; set; }
        #endregion
    }
}
