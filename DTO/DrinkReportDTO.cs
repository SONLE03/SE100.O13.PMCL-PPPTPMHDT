using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DrinkReportDTO
    {
        public int drinkId {  get; set; }
        public string drinkName { get; set; }   
        public double drinkTotalPrice { get; set; }
        public int drinkQuantity { get; set; }

        //public DrinkReportDTO(int drinkId, string drinkName, double drinkTotalPrice, int drinkQuantity)
        //{
        //    this.drinkId = drinkId;
        //    this.drinkName = drinkName;
        //    this.drinkQuantity = drinkQuantity;
        //    this.drinkTotalPrice = drinkTotalPrice;
        //}
    }
}
