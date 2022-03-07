﻿using ECommerce.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Entities
{
    public class Customer:BaseEntity
    {
        public string Name { get; set; }
        ICollection<Order> Orders { get; set; }
    }
}
