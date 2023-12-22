using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TopSellingDrinkDTO : DRINK
    {
        public string DrinkId { get; set; }
        public string DrinkName { get; set; }
        public int TotalQuantity { get; set; }
    }
}
