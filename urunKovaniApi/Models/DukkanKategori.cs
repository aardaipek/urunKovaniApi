﻿using Esnafim.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Esnafim.Models
{
    public class DukkanKategori : BaseEntity
    {
        [Column("category_name")]
        public string CategoryName { get; set; }

        public virtual ICollection<Shops> Shops { get; set; }


    }
}