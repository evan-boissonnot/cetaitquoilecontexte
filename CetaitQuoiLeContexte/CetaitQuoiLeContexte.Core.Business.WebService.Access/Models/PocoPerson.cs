using CetaitQuoiLeContexte.Core.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CetaitQuoiLeContexte.Core.Business.WebService.Access
{
    public class PocoPerson : IPerson
    {
        #region Properties
        public string Name {get; set;}

        public int Id {get; set;}

        public string Email { get; set; }
        #endregion
    }
}
