﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DNZ_Gayrimenkul.Models
{
    public class Specification
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SpecType { get; set; }
        public string Selected { get; set; }

        public virtual ICollection<Property> Properties { get; set; }
    }
}