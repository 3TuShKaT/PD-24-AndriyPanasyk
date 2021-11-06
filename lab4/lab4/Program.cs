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
            int[] array = N.Select(x => x - 48).ToArray(); //не дуже зрозуміло сенс використання Лінкк'ю і що ти хотів цим отримати. 
            
            List<int> formalList = new List<int>();
            foreach (int i in array)
            {
                formalList.Add(i);
                if (formalList.Equals(formalList)); //Перевірка на спільні елементи????? //та наврят, подивись що поверне Equals для двох лістів
                {
                    counter++;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine($"Number of repetetive digits is: ", counter);
        }
    }
}
