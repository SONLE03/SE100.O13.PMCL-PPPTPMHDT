using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BillDetail
    {
        public string productName;
        public int quantity;

        public BillDetail(string productName, int quantity)
        {
            this.productName = productName;
            this.quantity = quantity;
        }

        public BillDetail()
        {

        }
    }
}
