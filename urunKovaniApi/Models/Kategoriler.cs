﻿using Esnafim.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Esnafim.Models
{
    public class Kategoriler : BaseEntity
    {
        [Column("category_name")]
        public string CategoryName { get; set; }

        public int DukkanId { get; set; }

        [ForeignKey("shopId")]
        public Shops Shop { get; set; }

        public List<Urunler> Urun { get; set; }


    }
}