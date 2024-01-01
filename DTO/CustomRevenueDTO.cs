using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CustomRevenueDTO
    {
        public DateTime Date { get; set; }
        public DateTime Day { get; set; }  
        //public int Month { get; set; }
        //public int Year { get; set; }
        public double TotalAmount { get; set; }
    }
}
