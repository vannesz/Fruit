using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit
{

    public enum Fruit
    {
        apple,
        orange,
        banana,
        pear,
        watermellon,
        lemon,
        lime,
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fruit[] fruits = new Fruit[3];
            string userResponse;

            for (int index = 0; index < fruits.Count(); index++)
            {
                Console.WriteLine("Please Enter A Fruit");
                userResponse = Console.ReadLine();
                Enum.TryParse(userResponse, out fruits[index]);
                
            }

            Console.WriteLine();

            foreach (Fruit fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.ReadKey();
        }
    }
}
