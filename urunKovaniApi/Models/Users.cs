﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace urunKovaniApi.Models
{
    public class Users : BaseEntity
    {
        [Column("name")]
        public string Name { get; set; }

        [Column("surename")]
        public string SureName { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("password")]
        public string Password { get; set; }

    }
}