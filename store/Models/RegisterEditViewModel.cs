﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace store.Models
{
    public class RegisterEditViewModel
    {
        public int OrderID { get; set; }
        public int ItemID { get; set; }
        public int? Quantity { get; set; }
    }
}
