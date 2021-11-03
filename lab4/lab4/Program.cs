using System;
using System.Collections.Generic;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            void for_each_digit(int num)
            {
                if (num == 0) { return; };
                int current = num % 10;
                for_each_digit(num / 10);
                Console.WriteLine(current);
            }

            Console.WriteLine("Insert number");
            string N = Console.ReadLine();

            int num = int.Parse(N);

            for_each_digit(num);

            /* Додати елементи в ліст?????
            List<int> digits = new List<int>()
            {
                digits.Add(for_each_digit(num));
            }
            */
        }
    }
}
