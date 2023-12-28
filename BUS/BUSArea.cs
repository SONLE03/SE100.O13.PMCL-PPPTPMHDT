using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUSArea
    {
        private static BUSArea instance;

        public static BUSArea Instance
        {
            get 
            {
                if (instance == null) instance = new BUSArea();
                return instance; 
            }
            set { instance = value; }
        }

        public List<AREA> GetAllArea()
        {
            return DALArea.Instance.GetAllArea();
        }
        public List<AREA> GetAllAreaActive()
        {
            return DALArea.Instance.GetAllAreaActive();
        }
        public List<AREA> GetAllAreaInActive()
        {
            return DALArea.Instance.GetAllAreaInActive();
        }
        public AREA GetAreaById(int id)
        {
            return DALArea.Instance.GetAreaById(id);
        }
        public AREA GetAreaByName(string nameArea)
        {
            return DALArea.Instance.GetAreaByName(nameArea);
        }
        public bool AddArea(string AreaName, int capacity, string Status)
        {
            try
            {
                if (GetAreaByName(AreaName) != null)
                {
                    MessageBox.Show("The area already exists", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (DALArea.Instance.AddArea(AreaName, capacity, Status)) return true;
                MessageBox.Show("Add failure area", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }catch
            {
                MessageBox.Show("Add failure area", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
           
        }
        public bool UpdArea(int idArea, string AreaName, int capacity, string Status)
        {
            try
            {
                var area = GetAreaByName(AreaName);
                if (area != null  && area.id != idArea)
                {
                    MessageBox.Show("The area already exists", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (area.C_TABLE.Count > capacity)
                {
                    MessageBox.Show("The number of tables entered is invalid.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (DALArea.Instance.UpdArea(idArea, AreaName, Status, capacity))
                {
                    return true;
                }
                
                return false;
            }
            catch
            {
                MessageBox.Show("Modify failure area", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public List<AREA> Search(string searchText, string selectedStatus)
        {
            return DALArea.Instance.SearchArea(searchText, selectedStatus);
        }
    }
}
