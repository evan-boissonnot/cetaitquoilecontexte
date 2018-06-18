using System;
using System.Collections.Generic;
using System.Text;
using Boissonnot.Framework.Core.Interfaces.Filters;
using Boissonnot.Framework.Core.Extensions;
using CetaitQuoiLeContexte.Core.Interfaces.Data;
using System.Linq;
using CetaitQuoiLeContexte.Core.Business.Filters;
using Boissonnot.Framework.Core.Interfaces.Results;
using CetaitQuoiLeContexte.Core.Business.Models;

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
            IPerson currentPerson = null;

            if (item == null)
                throw new ArgumentNullException("item");

            if (item.Author == null)
                throw new ArgumentNullException("item.Author");

            currentPerson = this._context.Persons.FirstOrDefault(data => data.Email.ToLower() == item.Author.Email.ToLower());
            if (currentPerson == null)
                currentPerson = item.Author;

            if(item.Id == 0)
            {
                Data.Context data = new Data.Context()
                {
                    CreatedDate = DateTime.Now,
                    Message = item.Message,
                    From = item.From,
                    HtmlTitle = item.Message ?? string.Empty,
                    Author = (Data.Person) currentPerson
                };
                data.HtmlTitle = data.HtmlTitle.ToUrl();

                this._context.Contexts.Add(data);
                this._context.SaveChanges();

                item.Id = data.Id;
            }
        }

        public IResult<List<IContext>> SelectAll()
        {
            return this.SelectAll(null);
        }

        public IResult<List<IContext>> SelectAll(IParentFilter<IContext> filter)
        {
            var query = this._context.Contexts.AsQueryable();

            if(filter != null)
            {
                query = query.OrderByDescending(item => item.CreatedDate);

                if (filter.Id > 0)
                    query = query.Where(item => item.Id == filter.Id);

                if (filter is ContextFilter contextFilter)
                {
                    if (contextFilter.BeginDate > DateTime.MinValue)
                        query = query.Where(item => item.CreatedDate >= contextFilter.BeginDate);

                    if (!string.IsNullOrEmpty(contextFilter.From))
                        query = query.Where(item => item.From.ToLower() == contextFilter.From.ToLower());

                    if (!string.IsNullOrEmpty(contextFilter.Title))
                        query = query.Where(item => item.HtmlTitle.ToLower() == contextFilter.Title.ToLower() ||
                                                    item.Message.ToLower() == contextFilter.Title.ToLower());

                    if(contextFilter.IndexPage.HasValue)
                        query = query.Skip(contextFilter.IndexPage.Value * contextFilter.TakenNumber.GetValueOrDefault(0));

                    if (contextFilter.TakenNumber.HasValue && contextFilter.TakenNumber.Value > 0)
                        query = query.Take(contextFilter.TakenNumber.Value);
                }
            }

            var list = query
                        .Cast<IContext>()
                        .ToList();

            return new ListContextResult()
            {
               Item = list
            };
        }

        public IContext SelectOne(int id)
        {
            return this._context.Contexts.First(item => item.Id == id);
        }
        #endregion
    }
}
