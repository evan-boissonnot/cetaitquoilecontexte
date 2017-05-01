using System;
using System.Collections.Generic;
using System.Text;

namespace CetaitQuoiLeContexte.Core.Data
{
    public class Person : Core.Interfaces.Data.IPerson
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
