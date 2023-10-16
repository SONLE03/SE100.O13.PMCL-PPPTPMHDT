using SE100.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE100.Model.DataContext
{
    public class DataProvider
    {
        private static QLCFEntities instance;

        public static QLCFEntities Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new QLCFEntities();
                }    

                return instance; 
            }
            set 
            { 
                instance = value; 
            }
        }

    }
}
