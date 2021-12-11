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
        private int _availabilityItem1;
        private int _articlenumberItem1;
        private int _availabilityItem2;
        private int _articlenumberItem2;
        private int _availabilityItem3;
        private int _articlenumberItem3;
        private int _availabilityItem4;
        private int _articlenumberItem4;
        private int _availabilityItem5;
        private int _articlenumberItem5;
        #endregion
        #region public properties
        public int ArticlenumberItem1
        {
            get
            {
                return _articlenumberItem1;
            }
            set
            {
                _articlenumberItem1 = value;
            }
        }
        public int AvailabilityItem1

        {
            get
            {
                return _availabilityItem1;
            }
            set
            {
                _availabilityItem1 = value;
            }
        }
        public int ArticlenumberItem2
        {
            get
            {
                return _articlenumberItem2;
            }
            set
            {
                _articlenumberItem2 = value;
            }
        }
        public int AvailabilityItem2

        {
            get
            {
                return _availabilityItem2;
            }
            set
            {
                _availabilityItem2 = value;
            }
        }
        public int ArticlenumberItem3
        {
            get
            {
                return _articlenumberItem3;
            }
            set
            {
                _articlenumberItem3 = value;
            }
        }
        public int AvailabilityItem3

        {
            get
            {
                return _availabilityItem3;
            }
            set
            {
                _availabilityItem3 = value;
            }
        }
        public int ArticlenumberItem4
        {
            get
            {
                return _articlenumberItem4;
            }
            set
            {
                _articlenumberItem4 = value;
            }
        }
        public int AvailabilityItem4

        {
            get
            {
                return _availabilityItem4;
            }
            set
            {
                _availabilityItem4 = value;
            }
        }
        public int ArticlenumberItem5
        {
            get
            {
                return _articlenumberItem5;
            }
            set
            {
                _articlenumberItem5 = value;
            }
        }
        public int AvailabilityItem5

        {
            get
            {
                return _availabilityItem5;
            }
            set
            {
                _availabilityItem5 = value;
            }
        }



        #endregion
        #region constructor
        public Warehouse(int availibilityItem1, int articlenumberItem1, int availibilityItem2, int articlenumberItem2, int availibilityItem3, int articlenumberItem3, int availibilityItem4, int articlenumberItem4, int availibilityItem5, int articlenumberItem5)
        {
            _availabilityItem1 = availibilityItem1;
            _articlenumberItem1 = articlenumberItem1;
            _availabilityItem2 = availibilityItem2;
            _articlenumberItem2 = articlenumberItem2;
            _availabilityItem3 = availibilityItem3;
            _articlenumberItem3 = articlenumberItem3;
            _availabilityItem4 = availibilityItem4;
            _articlenumberItem4 = articlenumberItem4;
            _availabilityItem5 = availibilityItem5;
            _articlenumberItem5 = articlenumberItem5;
        }
        #endregion
        #region public methodes
        public bool CheckAvalibility()
        {
            bool isOk = false; //avalibility 1-5>0
            if (true)//avalibility Item1-5>0
            {
                isOk = true;
            }
            return isOk;
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
