﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class ItemCategoryType : BaseModel
    {
        public int SortOrder { get; set; }
        public string Name { get; set; }
    }
}
