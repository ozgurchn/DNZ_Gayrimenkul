﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DNZ_Gayrimenkul.Models
{
    public class Address
    {
        [Key, ForeignKey("Property")]
        public int PropertyID { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public double Lon { get; set; }
        public double Lat { get; set; }
        public bool ShowOnMap { get; set; }

        public virtual Property Property { get; set; }
      
    }
}