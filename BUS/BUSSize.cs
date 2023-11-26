using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSSize
    {
        private static BUSSize instance;

        public static BUSSize Instance
        {
            get
            {
                if (instance == null) instance = new BUSSize();
                return instance;
            }
            set { instance = value; }
        }
        public List<C_SIZE> GetAllSize()
        {
            return DALSize.Instance.GetAllSize();
        }
        public C_SIZE GetSizeById(int id)
        {
            return DALSize.Instance.GetSizeById(id);
        }
        public C_SIZE GetSizeByCode(string idSize)
        {
            return DALSize.Instance.GetSizeByCode(idSize);
        }
        public bool AddSize(string sizeName)
        {
            return DALSize.Instance.AddSize(sizeName);
        }
        public bool UpdSize(int idSize, string sizeName)
        {
            return DALSize.Instance.UpdSize(idSize, sizeName);
        }
        public bool DelSize(int idSize)
        {
            return DALSize.Instance.DelSize(idSize);
        }
    }
}
