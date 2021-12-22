using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop2
{
    class Article
    {
        #region private members
        private string _articledescription;
        private int _availability;
        private string _category;
        private double _price;
        private int _articlenumber;
        #endregion

        #region public properties
        public string Articledescription
        {
            get
            {
                return _articledescription;
            }
            set
            {
                _articledescription = value;
            }
        }

        public int Availability

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
        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        public int Articlenumber
        {
            get
            {
                return _articlenumber;
            }
            set
            {
                _articlenumber = value;
            }
        }
        #endregion

        #region constructor
        public Article(string Articledescription, int Availability, string Category, double Price, int Articlenumber)
        {
            _articledescription = Articledescription;
            _availability = Availability;
            _category = Category;
            _price = Price;
            _articlenumber = Articlenumber;
        }

        #endregion

        #region public methods


        #endregion
    }
}
