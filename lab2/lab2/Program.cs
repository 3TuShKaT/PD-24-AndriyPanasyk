using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert how many elemnets of array you want: ");
            string n;
            n = Console.ReadLine();

            int numberOfArray;
            numberOfArray= int.Parse(n);

            int counter = 0;
            int[] array = new int[numberOfArray];

            Random randNumbers = new Random();

            for (int i=0; i<array.Length; i++)
            {
                array[i] = randNumbers.Next(0, 9);
                Console.WriteLine("Array [{0}] = {1} ",i,array[i]);
            }

            for (int i=0; i<array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine($"Counter of max repetetive elements of array is: {counter}");
        }
    }
}
