using CetaitQuoiLeContexte.Core.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CetaitQuoiLeContexte.Razor.Web.UI.Data
{
    public class PocoContext : IContext
    {
        #region Properties
        public string Message {get; set;}
        public IPerson Author {get; set;}
        public int AuthorId {get; set;}
        public DateTime CreatedDate {get; set;}
        public string From {get; set;}
        public int Id {get; set;}
        public string HtmlTitle { get; set; }
        #endregion
    }
}
