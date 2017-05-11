﻿using System;
using System.Collections.Generic;
using System.Text;
using Boissonnot.Framework.Core.Interfaces.Filters;
using CetaitQuoiLeContexte.Core.Interfaces.Data;
using System.Linq;
using CetaitQuoiLeContexte.Core.Business.Filters;

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
            return this.SelectAll(null);
        }

        public List<IContext> SelectAll(IParentFilter<IContext> filter)
        {
            var query = this._context.Contexts.AsQueryable();

            if(filter != null)
            {
                if(filter.Id > 0)
                    query = query.Where(item => item.Id == filter.Id);

                ContextFilter contextFilter = filter as ContextFilter;
                if(contextFilter != null)
                {
                    if (contextFilter.BeginDate > DateTime.MinValue)
                        query = query.Where(item => item.CreatedDate >= contextFilter.BeginDate);
                }
            }

            return query.Cast<IContext>()
                        .ToList();
        }

        public IContext SelectOne(int id)
        {
            return this._context.Contexts.First(item => item.Id == id);
        }
        #endregion
    }
}
