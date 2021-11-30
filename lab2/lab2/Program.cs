using System;

namespace lab2 // на майбутнє, бажано писати завдання до лаби в заголовку
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert how many elemnets of array you want: ");
            string n;
            n = Console.ReadLine();

            int numberOfArray;
            numberOfArray= int.Parse(n); //якщо ввести з клавіатури не число, програма завалиться з помилкою
            //5 верхніх рядочків можна було записати в 1 int.TryParse(Console.ReadLine(), out string numberOfArray)
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
                for (int j = i + 1; j < array.Length; j++) // по ідеї в тебе в якийсб з моментів буде indexOtOfRange.Exeption
                {
                    if (array[i] == array[j])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine($"Counter of max repetetive elements of array is: {counter}");  //я так розумію ти робив 7 завдання, тоді воно виконано не зовсім правильно
            //треба знайти максимальну кількість повторень елементу з масиву, тобто який з елементів масиву повторюється найчастіше
        }
    }
}
