using System;
using System.Collections.Generic;

namespace Supermarket.API.Domain.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int QuantityInPackage { get; set; }
        public int UnitOfMeasurement { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
