using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL
{
    public class DALConstraint
    {
        private static DALConstraint instance;

        public static DALConstraint Instance
        {
            get
            {
                if (instance == null) instance = new DALConstraint();
                return instance;
            }
            set => instance = value;
        }
        public string TransformString(string input)
        {
            var normalizedInput = Regex.Replace(input.Trim(), @"\s+", " ");
            return normalizedInput;
        }
    }
}
