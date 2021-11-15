using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace lab6
{

    //Створити перевантаження методу shake(), який робить коктейлі...Залежно від зазначених параметрів, у вас виконується або той чи інший метод shake(), і на консоль виводитися назва коктейлю...самбука, мохіто і т.д...


    // Є ідея коли користувачу надається функція вводити інгредієнти по етапно (один ввів, система питає чи додати ще один). Потім перевіряти введені дані з Ingridients, якщо дані відповідні "рецепту", активується метод Shake.
    // Поки думаю як зробити перевірку.

    class Coctails
    {
        private static bool _insert = true;
        public static void Genry()
        {
            Console.WriteLine("Рецепт: Палаючий Генрi" + "\n" + "Вiскi: Jack Daniel`s + Лікер амарето + Айріш крім" + "\n");
        }

        public static void Kalvados()
        {
            Console.WriteLine("Рецепт: Кальвадос на терені" + "\n" + "Кальвадос + Терен + Цукрова пудра + Гвоздика");
        }

        public static void Mohito()
        {
            Console.WriteLine("Рецепт: Мохiто" + "\n" + "Білий ром + Цукровий сироп + Содова + Лайм + М'ята + лід" + "\n");
        }

        public static void Sunrise()
        {
            Console.WriteLine("Рецепт: Текіла санрайз" + "\n" + "Текіла Sіerra + Гренадін + Апельсин + лід" + "\n");
        }

        public static void Negroni()
        {
            Console.WriteLine("Рецепт: Негроні" + "\n" + "Джин + Червоний вермут" + "\n");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Список Коктейлів:");
            Console.WriteLine("| Палаючий Генрі |" + "\n" + "| Кальвадос на терені |" + "\n" + "| Мохіто |" + "\n" + "| Текіла санрайз |" + "\n" + "| Негроні |");
            Console.WriteLine();
            Genry();
            Kalvados();
            Mohito();
            Sunrise();
            Negroni();

            Ingridients ing = new Ingridients();
            ing.jackDeniels = "Jack Daniel`s";
            ing.amareto = "Лікер амарето";
            ing.irishCream = "Айріш крім";
            ing.kalvados = "Кальвадос";
            ing.terev = "Терен";
            ing.pudra = "Цукрова пудра";
            ing.gvozdika = "Гвоздика";
            ing.rum = "Білий ром";
            ing.syrop = "Цукровий сироп";
            ing.soda = "Содова";
            ing.lime = "Лайм";
            ing.miata = "М'ята";
            ing.ice = "Лід";
            ing.tequilla = "Текіла Sіerra";
            ing.grenada = "Гренадін";
            ing.orange = "Апельсин";
            ing.djin = "Джин";
            ing.vermut = "Червоний вермут";

            
        }

        //public void shake(string jackDeniels, string amareto, string irishCream)
        //{
        //    Console.WriteLine("Вітаю! У вас вийшов Палаючий Генрі.");
        //}

        //public void shake(string kalvados, string terev, string pudra, string gvozdika)
        //{
        //    Console.WriteLine("Вітаю! У вас вийшов Кальвадос на терені.");
        //}
        //public void shake(string rum, string syrop, string soda, string lime, string miata, string ice)
        //{
        //    Console.WriteLine("Вітаю! У вас вийшов Мохіто");
        //}
        //public void shake(string tequilla, string grenada, string orange, string ice, string vermut)
        //{
        //    Console.WriteLine("Вітаю! У вас вийшла Текіла Санрайз");
        //}
        //public void shake(string djin, string vermut)
        //{
        //    Console.WriteLine("Вітаю! У вас вийшов Негроні");
        //}
    }
}
