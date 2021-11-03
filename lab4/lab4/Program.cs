using System;
using System.Collections.Generic;
using System.Linq;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            Console.WriteLine("Insert number");
            string N = Console.ReadLine();
            int[] array = N.Select(x => x - 48).ToArray();

            List<int> formalList = new List<int>();
            foreach (int i in array)
            {
                formalList.Add(i);
                if (formalList.Equals(formalList)); //Перевірка на спільні елементи?????
                {
                    counter++;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine($"Number of repetetive digits is: ", counter);
        }
    }
}