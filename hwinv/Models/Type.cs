﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hwinv.Models
{
    public class Type
    {
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public virtual ICollection<Model> Models { get; set; }
    }
}