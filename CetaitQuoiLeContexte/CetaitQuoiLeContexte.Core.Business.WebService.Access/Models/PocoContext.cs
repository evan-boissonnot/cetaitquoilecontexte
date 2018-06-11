using CetaitQuoiLeContexte.Core.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CetaitQuoiLeContexte.Core.Business.WebService.Access
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
