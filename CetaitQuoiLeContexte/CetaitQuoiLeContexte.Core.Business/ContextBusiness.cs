﻿using System;
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
        private static Random __random = new Random();
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

            if (item.Id == 0)
            {
                Data.Context data = new Data.Context()
                {
                    CreatedDate = DateTime.Now,
                    Message = item.Message,
                    From = item.From,
                    HtmlTitle = item.Message ?? string.Empty,
                    Author = (Data.Person)currentPerson
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
            int nbItemsToTake = 0;
            int nbItemsToSkip = 0;

            if (filter != null)
            {
                query = query.OrderByDescending(item => item.CreatedDate);

                if (filter.Id > 0)
                    query = query.Where(item => item.Id == filter.Id);

                if (!filter.IsRandomGet.GetValueOrDefault())
                    this.PrepareSelectAllQuery(filter, ref query, out nbItemsToSkip, out nbItemsToTake);
                else
                    this.PrepareRandomSelect(ref query);
            }

            var list = query
                        .Cast<IContext>()
                        .ToList();

           bool hasMoreItems = false;
            if (nbItemsToTake > 0)
                hasMoreItems = this._context.Contexts.Skip(nbItemsToSkip + nbItemsToTake + 1).Take(1).Any();

            return new ListContextResult()
            {
                Item = list,
                HasNextItems = hasMoreItems
            };
        }

        public IContext SelectOne(int id)
        {
            return this._context.Contexts.First(item => item.Id == id);
        }
        #endregion

        #region Internal methods
        private void PrepareRandomSelect(ref IQueryable<Data.Context> query)
        {
            int nbItems = query.Count();
            int newItemIndex = __random.Next(0, nbItems);

            query = query.Skip(newItemIndex).Take(1);
        }

        private void PrepareSelectAllQuery(IParentFilter<IContext> filter, ref IQueryable<Data.Context> query, 
                                           out int nbItemsToSkip, out int nbItemsToTake)
        {
            nbItemsToSkip = 0;
            nbItemsToTake = 0;

            if (filter is ContextFilter contextFilter)
            {
                if (contextFilter.BeginDate > DateTime.MinValue)
                    query = query.Where(item => item.CreatedDate >= contextFilter.BeginDate);

                if (!string.IsNullOrEmpty(contextFilter.From))
                    query = query.Where(item => item.From.ToLower() == contextFilter.From.ToLower());

                if (!string.IsNullOrEmpty(contextFilter.Title))
                    query = query.Where(item => item.HtmlTitle.ToLower() == contextFilter.Title.ToLower() ||
                                                item.Message.ToLower() == contextFilter.Title.ToLower());

                if (contextFilter.IndexPage.HasValue)
                {
                    nbItemsToSkip = contextFilter.IndexPage.Value * contextFilter.TakenNumber.GetValueOrDefault(0);
                    query = query.Skip(nbItemsToSkip);
                }

                if (contextFilter.TakenNumber.HasValue && contextFilter.TakenNumber.Value > 0)
                {
                    nbItemsToTake = contextFilter.TakenNumber.Value;
                    query = query.Take(contextFilter.TakenNumber.Value);
                }
            }
        }
        #endregion
    }
}
