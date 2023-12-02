using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class FileProvider
    {
        private static FileProvider instance;
        
        public static FileProvider Instance
        {
            get 
            {
                if (instance == null) instance = new FileProvider();
                return instance; 
            }
            set { instance = value; }
        }

        public void deleteFile(string path)
        {
            System.IO.File.Delete(path);
        }
    }
}
