using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CetaitQuoiLeContexte.Core.Business.Filters;
using CetaitQuoiLeContexte.Core.Interfaces.Business;
using CetaitQuoiLeContexte.Core.Interfaces.Data;
using Microsoft.AspNetCore.Mvc;

namespace CetaitQuoiLeContexte.Web.Services.UI.Controllers
{
    [Route("api/[controller]")]
    public class ContextController : Controller
    {
        #region Fields
        private IContextBusiness _business = null;
        private IServiceProvider _serviceProvider = null;
        #endregion

        #region Constructors
        public ContextController(IContextBusiness business, IServiceProvider serviceProvider)
        {
            this._business = business;
            this._serviceProvider = serviceProvider;
        }
        #endregion

        #region Public methods
        [HttpGet]
        public IEnumerable<IContext> Get()
        {
            IEnumerable<IContext> list = null;
            string fromQuery = this.HttpContext.Request.Query["from"];

            list = this._business.SelectAll(new ContextFilter() { From = fromQuery });

            return list;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IContext Get(int id)
        {
            return this._business.SelectOne(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]IContext value)
        {
            this._business.Save(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]IContext value)
        {
            value.Id = id;
            this._business.Save(value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this._business.DeleteOne(id);
        }
        #endregion
    }
}
