﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CardType : BaseModel
    {
        [Required]
        public string Name { get; set; }
    }
}
