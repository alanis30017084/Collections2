/*Name: Alanis Correa
 *Purpose: Testing dictionary features */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> fruits = new Dictionary<string, double>()
            {
                { "Apples", 0.49 },
                { "Bananas", 0.39 },
                { "Grapes", 0.59 }
            };

            Console.WriteLine($"Number of entries: {fruits.Count}\n");
            foreach (KeyValuePair<string, double> item in fruits)
            {
                Console.WriteLine("Fruit Type: {0}, Price per kg: ${1}", item.Key, item.Value);
            }
            
            fruits.Remove("Grapes");
            if (fruits.ContainsKey("Grapes"))
            {
                fruits.Add("Oranges", 0.24);
                fruits.Add("Solid Gold Oranges", 48120.02);
            }
            else fruits.Add("Mangoes", 0.99);
                fruits.Add("Solid Gold Mangoes", 48120.02);

            Console.WriteLine("\n");
            for (int i = 0; i < fruits.Count; i++)
            {
                Console.WriteLine("Fruit Type: {0}, Price per kg: ${1}",
                    fruits.Keys.ElementAt(i),
                    fruits[fruits.Keys.ElementAt(i)]);
            }            

            Console.ReadKey();
        }
    }
}
