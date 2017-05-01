using System;
using System.Collections.Generic;
using System.Text;
using CetaitQuoiLeContexte.Core.Interfaces.Data;

namespace CetaitQuoiLeContexte.Core.Data
{
    public class Context : Interfaces.Data.IContext
    {
        public int Id { get; set; }

        public string Message { get; set; }

        public IPerson Author { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
