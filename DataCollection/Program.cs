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
            //var cars = new List<string>();

            //var car1 = "BMW";
            //var car2 = "LADA";
            //var car3 = "HONDA";
            //var car4 = "LAMBORGHINI";
            //var car5 = "FORD";
            //var car6 = "SAAB";

            //cars.Add(car1);
            //cars.Add(car2);
            //cars.Add(car3);
            //cars.Add(car4);
            //cars.Add(car5);
            //cars.Add(car6);

            //foreach (var item in cars)
            //{
            //    Console.WriteLine(item);
            //}

            //var cars = new List<string> { "BMW", "Lada", "Honda", "Lamborghini", "Ford", "Saab" };
            //for (int index = 0; index < cars.Count; index++)
            //{
            //    Console.WriteLine(cars[index]);
            //}

            var humans1 = new List<Human>
            {
                new Human(){Name = "Kalle", Age = 20},
                new Human(){Name = "Malle", Age = 25},
                new Human(){Name = "Mari", Age = 14},
                new Human(){Name = "Elmar", Age = 16},
                new Human(){Name = "Juku", Age = 35},
            };

            var human1 = new Human();
            human1.Name = "Priit";
            human1.Age = 25;
            humans1.Add(human1);

            var human2 = new Human();
            Console.WriteLine("sisestage nimi");
            human2.Name = Console.ReadLine();
            Console.WriteLine("sisestage vanus");
            human2.Age = int.Parse(Console.ReadLine());
            humans1.Add(human2);

            foreach (var item in humans1)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }

            Console.ReadLine();
        }
    }
}
