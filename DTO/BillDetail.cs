using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BillDetail
    {
        public int drinkID;
        public int quantity;
        public int sizeID;
        public double unitPrice;

        public BillDetail(int drinkID, int quantity, int sizeID, double unitPrice)
        {
            this.drinkID = drinkID;
            this.quantity = quantity;
            this.sizeID = sizeID;
            this.unitPrice = unitPrice;
        }

        public BillDetail()
        {

        }
    }
}
