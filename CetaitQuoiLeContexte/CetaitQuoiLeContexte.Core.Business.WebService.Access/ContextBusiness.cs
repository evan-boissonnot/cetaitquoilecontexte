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

            using (var result = await this._client.GetAsync("api/context"))
            {
                if(result.IsSuccessStatusCode)
                {
                    var listResult = await result.Content.ReadAsAsync<List<PocoContext>>();
                    list = listResult.Cast<IContext>().ToList();
                }
            }

            return list;
        }

        public Task<Interfaces.Data.IContext> SelectOne(int id)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
