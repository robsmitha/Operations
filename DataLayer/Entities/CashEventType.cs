﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class CashEventType : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
