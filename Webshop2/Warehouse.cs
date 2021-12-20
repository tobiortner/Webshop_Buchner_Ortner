using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop
{
    class Warehouse
    {
        #region private members

        private List<int> _articelnumber = new List<int>();
        private List<int> _availability = new List<int>();

        #endregion
        #region public properties

        public List<int> availability
        {
            get
            {
                return _availability;
            }
            set
            {
                _availability = value;
            }
        }
        public List<int> articelnumber
        {
            get
            {
                return _articelnumber;
            }
            set
            {
                _articelnumber = value;
            }
        }

        #endregion
        #region constructor
        public Warehouse(List<int> availability, List<int> articelnumber)
        {
            _articelnumber = articelnumber;
            _availability = availability;
        }
        #endregion
        #region public methodes
        public bool CheckAvalibility()
        {
            bool available = false;
            foreach (var item in availability)
            {
                if (item <= 0)
                {
                    available =  false;
                }
                else
                {
                    available = true;
                }
                
            }
            return available;
        }
        public void RemoveFromWarhouse()
        {

        }
        public string ShowAvalibility()
        {
            return "test";
        }

        #endregion
    }
}
