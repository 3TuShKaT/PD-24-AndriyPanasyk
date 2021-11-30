using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args) // чому в 2 лабі було 7 завдання а тут 6? 
        {
            Console.WriteLine("Insert K1: "); // те ж саме зауваження що й до 2 лабораторної
            string k1;
            k1 = Console.ReadLine(); //якщо користувач ввеже числа більші 4/10 або менше 1 буде помилка виконання нижче

            Console.WriteLine("Insert K2: ");
            string k2;
            k2 = Console.ReadLine();

            int keyNumber1;
            keyNumber1 = int.Parse(k1);
            int keyNumber2;
            keyNumber2 = int.Parse(k2);

            int[,] Array = new int[4,10];

            Random randNumbers = new Random();

            for (int i = 0; i < 4; i++) //Генеруємо рандомні числа
            {
                for (int j = 0; j < 10; j++)
                {
                    Array[i, j] = randNumbers.Next(0, 9);
                }
            }

            for (int i=0; i<4; i++) //Виведення масиву
            {
                for (int j=0; j<10; j++)
                {
                    Console.Write("|" + Array[i, j] + "|"); // для двовимірних масивів найкраще використовувати табуляцію
                }
                Console.WriteLine();
            }

            Console.WriteLine("__________________");

             for (int i=0; i<4; i++)
            {
                int temp = Array[i,keyNumber1 - 1];
                Array[i,keyNumber1 - 1] = Array[i,keyNumber2 - 1];
                Array[i,keyNumber2 - 1] = temp;
            }
            for (int i = 0; i < 4; i++) //Виведення масиву
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("|" + Array[i, j] + "|");
                }
                Console.WriteLine();
            }
        }
    }
}
