using Boissonnot.Framework.Core.Interfaces.Filters;
using CetaitQuoiLeContexte.Core.Interfaces.Business;
using CetaitQuoiLeContexte.Core.Interfaces.Data;
using CetaitQuoiLeContexte.Razor.Web.UI.Data;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using CetaitQuoiLeContexte.Core.Business.Filters;

namespace CetaitQuoiLeContexte.Core.Business.WebService.Access
{
    public class ContextBusiness : IContextAsAsyncBusiness
    {
        #region Fields
        private HttpClient _client = new HttpClient();
        #endregion

        #region Constructors
        public ContextBusiness()
        {
            this._client.BaseAddress = new Uri("http://localhost/CetaitQuoiLeContexte.Web.Services.UI/");
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

        public Task Save(Interfaces.Data.IContext item)
        {
            throw new NotImplementedException();
        }

        public Task<List<Interfaces.Data.IContext>> SelectAll()
        {
            return this.SelectAll(null);
        }

        public async Task<List<Interfaces.Data.IContext>> SelectAll(IParentFilter<Interfaces.Data.IContext> filter)
        {
            List<Interfaces.Data.IContext> list = null;

            using (var result = await this._client.GetAsync(this.PrepareUrl(filter)))
            {
                if (result.IsSuccessStatusCode)
                {
                    var listResult = await result.Content.ReadAsAsync<List<PocoContext>>();
                    list = listResult.Cast<IContext>().ToList();
                }
            }

            return list;
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
        #endregion

        #region Internal methods
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
            string url = "api/context?";

            if (filter is ContextFilter realFilter)
            {
                if (realFilter.TakenNumber.HasValue)
                    url += $"nb={realFilter.TakenNumber.Value}&";

                if (realFilter.Id > 0)
                    url += $"id={realFilter.Id}&";
            }

            return url;
        }
        #endregion
    }
}
