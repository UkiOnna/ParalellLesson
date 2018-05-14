using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParalelLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parallel.

            String[] cities = new String[] { "Астна", "Караганда", "Алматы" };
            for(int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine(cities[i]);
            }

            Parallel.For(0, cities.Length, i => Console.WriteLine(cities[i]));

            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }
            Parallel.ForEach<string>(cities, city => Console.WriteLine(city));

            Parallel.Invoke(() => Console.WriteLine("Выполняется работа"));
        }
    }
}
