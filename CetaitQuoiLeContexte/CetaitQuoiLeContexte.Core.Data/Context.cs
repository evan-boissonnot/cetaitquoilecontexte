﻿using System;
using System.Collections.Generic;
using System.Text;
using CetaitQuoiLeContexte.Core.Interfaces.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CetaitQuoiLeContexte.Core.Data
{
    public class Context : Interfaces.Data.IContext
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Message { get; set; }

        public IPerson Author { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
    }
}
