using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.API.Domain.Models
{
    public class Product2
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public short QuantityInPackage { get; set; }
        public EUnitOfMeasurement UnitOfMeasurement { get; set; }

        public int CategoryId { get; set; }
        public Category2 Category { get; set; }
    }
}
