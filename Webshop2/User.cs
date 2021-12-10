using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop2
{
    class User
    {
        #region private members
        private string _firstname;
        private string _surname;
        private DateTime _birthdate;
        #endregion

        #region public properties
        public string FirstName
        {
            get
            {
                return _firstname;
            }
            set
            {
                _firstname = value;
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }
        public DateTime Birthdate
        {
            get
            {
                return _birthdate;
            }
            set
            {
                _birthdate = value;
            }
        }
        #endregion

        #region constructor
        public User(string Firstname, string Surname, DateTime birthdate)
        {
            _firstname = Firstname;
            _surname = Surname;
            _birthdate = birthdate;
        }
        #endregion

        #region public methods
        public static bool CheckFirstname(string currentname)
        {
            bool provename = false;
            if (currentname.All(char.IsLetter) && currentname.Length > 2 && !string.IsNullOrWhiteSpace(currentname))
            {
                provename = true;
                return provename;
            }
            else
            {
                provename = false;
                return provename;
            }

        }

        public static bool CheckSurname(string currentname)
        {
            bool provename = false;
            if (currentname.All(char.IsLetter) && currentname.Length > 2 && !string.IsNullOrWhiteSpace(currentname))
            {
                provename = true;
                return provename;
            }
            else
            {
                provename = false;
                return provename;
            }

        }

        public static bool CheckBirthdate(DateTime birthdate)
        {
            bool provedbirthdate = false;
            int checkcounter = 0;
            int ageUpperbound = 1890;
            int check = 6;

            //Geburtsjahr auf Grenze überprüfen
            if (birthdate.Year >= ageUpperbound)
                checkcounter++;
            //Geburtsjahr darf nicht größer als aktueles Jahr sein
            if (birthdate.Year <= DateTime.Now.Year)
                checkcounter++;
            //Monatsgrenzen überprüfen
            if (birthdate.Month <= 12)
                checkcounter++;

            if (birthdate.Month > 0)
                checkcounter++;
            //Tagesgrenzen überprüfen
            if (birthdate.Day <= 31)
                checkcounter++;

            if (birthdate.Day > 0)
                checkcounter++;

            //Counter überprüfen
            if (!(checkcounter == check))
                provedbirthdate = false;

            if (checkcounter == check)
                provedbirthdate = true;

            return provedbirthdate;


        }
        #endregion

    }
}
