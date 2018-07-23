using System;
using System.Collections.Generic;
using System.Text;

namespace Boissonnot.Framework.Core.Business.Filters
{
    public class ParentFilter<T> : Core.Interfaces.Filters.IParentFilter<T>
                 where T : Core.Interfaces.Data.IParentModel
    {
        #region Properties
        public int Id { get; set; }

        public int? TakenNumber { get; set; }

        public T Model { get; set; }

        public int? IndexPage { get; set; }

        public bool? IsRandomGet { get; set; }
        #endregion
    }
}
