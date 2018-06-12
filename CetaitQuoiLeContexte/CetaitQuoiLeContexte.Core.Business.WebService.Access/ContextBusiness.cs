using Boissonnot.Framework.Core.Interfaces.Filters;
using CetaitQuoiLeContexte.Core.Interfaces.Business;
using CetaitQuoiLeContexte.Core.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using CetaitQuoiLeContexte.Core.Business.Filters;
using CetaitQuoiLeContexte.Core.Interfaces;
using Boissonnot.Framework.Core.Interfaces.Business;
using Boissonnot.Framework.Core.Interfaces.Results;

namespace CetaitQuoiLeContexte.Core.Business.WebService.Access
{
    public class ContextBusiness : IContextAsAsyncBusiness
    {
        #region Constants
        private const string BASE_URL = "api/context";
        #endregion

        #region Fields
        private HttpClient _client = new HttpClient();
        private IMotor _motor = null;
        #endregion

        #region Constructors
        public ContextBusiness(IMotor motor)
        {
            this._motor = motor;
            this._client.BaseAddress = new Uri(this._motor.Settings.ApiUrl);
            this._client.DefaultRequestHeaders.Accept.Clear();
            this._client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        #endregion

        #region Public methods
        public Task DeleteOne(Interfaces.Data.IContext item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteOne(int id)
        {
            throw new NotImplementedException();
        }

        public async Task Save(Interfaces.Data.IContext item)
        {
            if (item == null)
                throw new ArgumentNullException("item");

            if (item.Id <= 0)
                await this.Insert(item);
        }

        public Task<IResult<List<IContext>>> SelectAll()
        {
            return this.SelectAll(null);
        }

        public async Task<IResult<List<IContext>>> SelectAll(IParentFilter<Interfaces.Data.IContext> filter)
        {
            IResult<List<PocoContext>> itemResult = null;

            using (var result = await this._client.GetAsync(this.PrepareUrl(filter)))
            {
                if (result.IsSuccessStatusCode)
                    itemResult = await result.Content.ReadAsAsync<Models.ListPocoContextResult>();
            }

            return new Models.Temps.ListContextResult()
            {
                FullResultNumber = itemResult.FullResultNumber,
                Item = itemResult.Item.Cast<IContext>().ToList(),
                HasNextItems = itemResult.HasNextItems
            };
        }

        public async Task<Interfaces.Data.IContext> SelectOne(int id)
        {
            IContext context = null;

            using (var result = await this._client.GetAsync(this.PrepareUrl(id)))
            {
                if (result.IsSuccessStatusCode)
                    context = await result.Content.ReadAsAsync<PocoContext>();
            }

            return context;
        }

        public async Task<Interfaces.Data.IContext> SelectOne(string title)
        {
            IContext context = null;

            using (var result = await this._client.GetAsync(this.PrepareUrl(title)))
            {
                if (result.IsSuccessStatusCode)
                {
                    var listResult = await result.Content.ReadAsAsync<List<PocoContext>>();
                    var list = listResult.Cast<IContext>().ToList();

                    if (list.Count > 0)
                        context = list[0];
                }
            }

            return context;
        }
        #endregion

        #region Internal methods
        private async Task Insert(IContext context)
        {
            using (var result = await this._client.PostAsJsonAsync(BASE_URL, context)) {}
        }

        private string PrepareUrl(string title)
        {
            ContextFilter filter = new ContextFilter()
            {
                Title = title
            };

            return this.PrepareUrl(filter);
        }

        private string PrepareUrl(int id)
        {
            ContextFilter filter = new ContextFilter()
            {
                Id = id
            };

            return this.PrepareUrl(filter);
        }

        private string PrepareUrl(IParentFilter<Interfaces.Data.IContext> filter)
        {
            string url = $"{BASE_URL}?";

            if (filter is ContextFilter realFilter)
            {
                if (realFilter.TakenNumber.HasValue)
                    url += $"nb={realFilter.TakenNumber.Value}&";

                if (realFilter.Id > 0)
                    url += $"id={realFilter.Id}&";

                if (!string.IsNullOrEmpty(realFilter.Title))
                    url += $"title={realFilter.Title}&";
            }

            return url;
        }
        #endregion
    }
}
