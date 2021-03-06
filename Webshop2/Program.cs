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
            Console.Clear();

            int sizeArray = 8;
            Article[] articleArray = new Article[sizeArray];

            #region fill articleArray
            articleArray[0] = new Article("Kaffee", 0, "Lebensmittel", 5.90, 12340);
            articleArray[1] = new Article("Milch", 25, "Lebensmittel", 1.90, 12341);
            articleArray[2] = new Article("Teddybär", 4, "Spielzeug", 24.90, 12342);
            articleArray[3] = new Article("Spielzeugauto", 2, "Spielzeug", 34.90, 12343);
            articleArray[4] = new Article("Waschmaschine", 15, "Haushaltsgeräte", 699.90, 12344);
            articleArray[5] = new Article("Backrohr", 1, "Haushaltsgerät", 399.90, 12345);
            articleArray[6] = new Article("Fernseher", 8, "Elektrowaren", 1599.90, 12346);
            articleArray[7] = new Article("Laptop", 5, "Elektrowaren", 699.90, 12347);
            #endregion
            ScreenArticle(articleArray);


            // User Fragen was er kaufen will
            Console.WriteLine("Wenn sie einen Artikel ihrem Warenkorb hinzufügen möchten geben sie einfach seinen Stellplatz ein.");
            int userChoiceArticle = int.Parse(Console.ReadLine());
            GetArticle(userChoiceArticle, articleArray);

            // Wieviel von diesem Artikel will er kaufen?
            Console.WriteLine("Wieviele von diesem Artikel möchten sie kaufen?");
            Console.WriteLine("Zur Verfügung stehen" + articleArray[userChoiceArticle].Availability + ".");

            int userChoiceQuantitiy = int.Parse(Console.ReadLine());
            GetCountofArticle(userChoiceQuantitiy, articleArray, userChoiceArticle);




           

            // User Fragen ob er weiter einkaufen will oder shopingcart anzeigen
            //Wenn schopingcart user fragen ob er zahlen möchte oder weiter einkaufen
            //Wenn Zahlen beenden und nächsten user drann nehmen
            //wenn weiter einkaufen Warehouse wieder anzeigen


            Warehouse warehouse1 = new Warehouse();
            WriteArticleToWarehouse(articleArray, warehouse1);
            Console.WriteLine(warehouse1.CheckAvalibility());
            //Console.WriteLine(warehouse1.ShowAvalibility());
            Console.ReadLine();


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
        public static void ScreenArticle(Article[] articleArray)
        {
            for (int i = 0; i <= 7; i++)
            {
                Console.WriteLine(i + ")");
                Console.Write(articleArray[i].Articledescription + " ");
                Console.Write(articleArray[i].Availability + " ");
                Console.Write(articleArray[i].Category + " ");
                Console.Write(articleArray[i].Price + ",- ");
                Console.Write(articleArray[i].Articlenumber);

                Console.WriteLine();

            }
        }

        public static void GetArticle(int userChoiceArticle, Article[] articleArray)
        {
            Console.Clear();
            Console.WriteLine("Sie habe sich für " + articleArray[userChoiceArticle].Articledescription + " entschieden.");
        }
        public static void WriteArticleToWarehouse(Article[] articleArray, Warehouse warehouse1)
        {
            List<int> articelnumber = new List<int>();
            List<int> availibility = new List<int>();

            foreach (var article in articleArray)
            {
                articelnumber.Add(article.Articlenumber);
                availibility.Add(article.Availability);
            }
            warehouse1.Articelnumber = articelnumber;
            warehouse1.Availibility = availibility;
        }
        public static void GetCountofArticle(int userChoiceQuantitiy,Article[] articleArray,int chosenArticle)
        {
            //Check ob Artikel noch so oft verfügbar ist
            if (userChoiceQuantitiy <= articleArray[chosenArticle].Availability)
            {
                Console.WriteLine("Ihr Artikel wird " + userChoiceQuantitiy + "mal Ihrem Warenkorb hinzugefügt");
            }
            else
            {
                Console.WriteLine("Es tut mir leid ihr Artikel ist leider nicht mehr so oft verfügbar");
            }
        }
    }
}

