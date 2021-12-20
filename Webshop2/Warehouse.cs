using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop2
{
    class Warehouse
    {

        public List<int> Articelnumber { get; set; }
        public List<int> Availibility { get; set; }

        #region constructor

        #endregion
        #region public methodes
        public bool CheckAvalibility()
        {
            bool available = true;
            foreach (var item in Availibility)
            {
                if (item <= 0)
                {
                    available =  false;
                } 
            }
            return available;
        }
        public void RemoveFromWarhouse()
        {

        }
        public string ShowAvalibility()
        {
            string output = "";
            int i = 1; 
            foreach (var item in Availibility)
            {
                output += "item " + i + ": " + item + "\n";
                i++;
            }
            return output;
        }


        #endregion
    }
}
