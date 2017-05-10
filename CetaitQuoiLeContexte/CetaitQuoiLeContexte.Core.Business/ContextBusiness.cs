using System;
using System.Collections.Generic;
using System.Text;
using Boissonnot.Framework.Core.Interfaces.Filters;
using CetaitQuoiLeContexte.Core.Interfaces.Data;

namespace CetaitQuoiLeContexte.Core.Business
{
    public class ContextBusiness : Interfaces.Business.IContextBusiness
    {
        #region Fields
        private Core.Data.DataDbContext _context = null;
        #endregion

        #region Constructors
        public ContextBusiness(Core.Data.DataDbContext context)
        {
            _context = context;
        }
        #endregion

        #region Public methods
        public void DeleteOne(IContext item)
        {
            throw new NotImplementedException();
        }

        public void DeleteOne(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(IContext item)
        {
            throw new NotImplementedException();
        }

        public List<IContext> SelectAll()
        {
            throw new NotImplementedException();
        }

        public List<IContext> SelectAll(IParentFilter<IContext> filter)
        {
            throw new NotImplementedException(); 
        }

        public IContext SelectOne(int id)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
