using Boissonnot.Framework.Core.Interfaces.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boissonnot.Framework.Core.Business
{
    public class ParentBusiness<T> : Core.Interfaces.Business.IParentBusiness<T>
        where T : Core.Interfaces.Data.IParentModel

    {
        #region Public methods
        public virtual List<T> SelectAll(IParentFilter<T> filter)
        {
            throw new NotImplementedException();
        }

        public virtual void DeleteOne(T item)
        {
            throw new NotImplementedException();
        }

        public virtual void DeleteOne(int id)
        {
            throw new NotImplementedException();
        }

        public virtual void Save(T item)
        {
            throw new NotImplementedException();
        }

        public virtual List<T> SelectAll()
        {
            throw new NotImplementedException();
        }

        public virtual T SelectOne(int id)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
