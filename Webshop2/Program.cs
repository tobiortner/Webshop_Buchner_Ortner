using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Anzahl der User erfragen
            int sizeUserArray = InsertUserArraySize();
            User[] personArray = new User[sizeUserArray];
            for (int i = 0; i < sizeUserArray; i++)
            {
                personArray[i] = new User("firstname", "surname", DateTime.Today);

                //USerarray befüllen
                personArray[i].FirstName = InsertFirstName("firstname");
                personArray[i].Surname = InsertSurName("surname");
                personArray[i].Birthdate = InsertBirthdate();

            }
        }
        public static int InsertUserArraySize()
        {
            bool conversionsucess = false;
            int sizeArray;

            do
            {
                Console.Write("Bitte geben Sie die Anzahl der User ein: ");
                string userInput = Console.ReadLine();
                conversionsucess = int.TryParse(userInput, out sizeArray);

                if (conversionsucess == false)
                {
                    Console.WriteLine("Ihre Eingabe war keine Zahl!");
                }
                Console.WriteLine();

            } while (conversionsucess == false);

            return sizeArray;
        }
        public static string InsertFirstName(string firstname)
        {
            bool provename;
            do
            {
                Console.Write("Vorname:");
                firstname = Console.ReadLine();
                provename = User.CheckFirstname(firstname);
            } while (provename == false);
            return firstname;
        }
        public static string InsertSurName(string surname)
        {
            bool provename;
            do
            {
                Console.Write("Nachname:");
                surname = Console.ReadLine();
                provename = User.CheckSurname(surname);
            } while (provename == false);
            return surname;
        }
        public static DateTime InsertBirthdate()
        {
            int birthyear = 0;
            int birthmonth = 0;
            int birthday = 0;
            DateTime Birthdate;

            bool checkinput;
            do
            {
                //Geburtsjahr abfragen
                do
                {
                    Console.WriteLine("Geben sie ihr Gebutsjahr ein:");
                    string year = Console.ReadLine();
                    checkinput = int.TryParse(year, out birthyear);
                } while (checkinput == false);
                //Geburtsmonat abfragen
                do
                {
                    Console.WriteLine("Geben sie ihr Gebutsmonat ein:");
                    string month = Console.ReadLine();
                    checkinput = int.TryParse(month, out birthmonth);
                } while (checkinput == false);
                //Geburtstag abfragen
                do
                {
                    Console.WriteLine("Geben sie ihr Gebutstag ein:");
                    string day = Console.ReadLine();
                    checkinput = int.TryParse(day, out birthday);
                } while (checkinput == false);

                Birthdate = new DateTime(birthyear, birthmonth, birthday);
                checkinput = User.CheckBirthdate(Birthdate);

            } while (checkinput == false);

            return Birthdate;
        }
    }
}

