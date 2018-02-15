using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            ////var cars = new List<string>();

            ////var car1 = "BMW";
            ////var car2 = "LADA";
            ////var car3 = "HONDA";
            ////var car4 = "LAMBORGHINI";
            ////var car5 = "FORD";
            ////var car6 = "SAAB";

            ////cars.Add(car1);
            ////cars.Add(car2);
            ////cars.Add(car3);
            ////cars.Add(car4);
            ////cars.Add(car5);
            ////cars.Add(car6);

            ////foreach (var item in cars)
            ////{
            ////    Console.WriteLine(item);
            ////}

            ////var cars = new List<string> { "BMW", "Lada", "Honda", "Lamborghini", "Ford", "Saab" };
            ////for (int index = 0; index < cars.Count; index++)
            ////{
            ////    Console.WriteLine(cars[index]);
            ////}

            //var humans1 = new List<Human>
            //{
            //    new Human(){Name = "Kalle", Age = 20},
            //    new Human(){Name = "Malle", Age = 25},
            //    new Human(){Name = "Mari", Age = 14},
            //    new Human(){Name = "Elmar", Age = 16},
            //    new Human(){Name = "Juku", Age = 35},
            //};

            //var human1 = new Human();
            //human1.Name = "Priit";
            //human1.Age = 25;
            //humans1.Add(human1);

            //var human2 = new Human();
            //Console.WriteLine("sisestage nimi");
            //human2.Name = Console.ReadLine();
            //Console.WriteLine("sisestage vanus");
            //human2.Age = int.Parse(Console.ReadLine());
            //humans1.Add(human2);

            //foreach (var item in humans1)
            //{
            //    Console.WriteLine(item.Name + " " + item.Age);
            //}

            //Dictionary

            var openWith = new Dictionary<string, string>();
            //            key       value
            openWith.Add("Txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("jpg", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            openWith["rtf"] = "winword.exe";
            openWith["doc"] = "winword.exe";

            try
            {
                openWith.Add("Txt", "word.exe");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An element with key \"txt\" already exists");
            }

            Console.WriteLine("For key = rtf, value = {0}", openWith["rtf"]);
            Console.WriteLine("For key = doc, value = {0}", openWith["doc"]);

            try
            {
                Console.WriteLine("For key = tif, value = {0}", openWith["rtf"]);

            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Key = \"tif\" is not found");
            }

            string value = "";
            if(openWith.TryGetValue("tif", out value))
            {
                Console.WriteLine("For key = \"tif\", value = {0}.");
            }
            else
            {
                Console.WriteLine("Key = \"tif\" is not found");
            }

            //vaatame kas "ht" võti on olemas, kui ei ole lisame
            if (!openWith.ContainsKey("ht"))
            {
                openWith.Add("ht", "hyperterm.exe");
                Console.WriteLine("Value added for key 'ht': {0}", openWith["ht"]);
            }

            //Kpsime väärtused kasutades foreach tsüklis
            foreach (KeyValuePair<string, string> kvp in openWith)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }

            //Küsime väärtused
            Dictionary<string, string>.ValueCollection valueCollection = openWith.Values
            foreach (string item in valueCollection)
            {
                Console.WriteLine("Key = {0}", item);
            }



            Console.ReadLine();
        }
    }
}
