using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Product : BaseEntity
    {
        public string CategoryName { get; set; }
        public decimal Price { get; set; }

    }
}
