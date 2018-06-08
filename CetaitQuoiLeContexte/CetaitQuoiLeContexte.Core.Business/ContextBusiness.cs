using System;
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
            if(item.Id == 0)
            {
                Data.Context data = new Data.Context()
                {
                    CreatedDate = DateTime.Now,
                    Message = item.Message,
                    Author = new Data.Person()
                    {
                        Name = item.Author.Name
                    }
                };

                this._context.Contexts.Add(data);
                this._context.SaveChanges();

                item.Id = data.Id;
            }
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

                if (filter is ContextFilter contextFilter)
                {
                    if (contextFilter.BeginDate > DateTime.MinValue)
                        query = query.Where(item => item.CreatedDate >= contextFilter.BeginDate);

                    if (!string.IsNullOrEmpty(contextFilter.From))
                        query = query.Where(item => item.From.ToLower() == contextFilter.From.ToLower());

                    if (contextFilter.TakenNumber.HasValue && contextFilter.TakenNumber.Value > 0)
                        query = query.Take(contextFilter.TakenNumber.Value);
                }
            }

            return query.OrderByDescending(item => item.CreatedDate)
                        .Cast<IContext>()
                        .ToList();
        }

        public IContext SelectOne(int id)
        {
            return this._context.Contexts.First(item => item.Id == id);
        }
        #endregion
    }
}
