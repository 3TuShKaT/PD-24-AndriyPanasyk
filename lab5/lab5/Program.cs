using System;

namespace lab5
{
    class Program
    {
        private static bool _insert = true;
        private static Store _store;
        static void Main(string[] args)
        {
            _store = new Store();
            while (_insert)
            {
                try
                {
                    Console.WriteLine("Введіть назву товару: ");
                    var name = Console.ReadLine();
                    Console.WriteLine("Введіть тип товару: ");
                    var type = Console.ReadLine();
                    Console.WriteLine("Введіть опис товару: ");
                    var description = Console.ReadLine();
                    Console.WriteLine("Введіть ціну: ");
                    var cost = double.Parse(Console.ReadLine());

                    var tovar = new Tovar(name, type, description, cost);
                    _store.AddTovar(tovar);
                }
                catch (Exception stop)
                {
                    Console.WriteLine("Error");
                }


                var more = new ConsoleKeyInfo();
                while (more.Key != ConsoleKey.Y)
                {
                    if (more.Key == ConsoleKey.N)
                    {
                        _insert = false;
                        break;
                    }

                    Console.WriteLine("Добавити товар? Y - true, N - false: ");
                    more = Console.ReadKey();
                }
            }

                Console.WriteLine("Який товар ви хочете знайти: ");
                var findName = Console.ReadLine();

                var findTovar = _store[findName];
                Console.WriteLine(findTovar == null ? "Такого товару немає " : $"Назва товару: {findTovar.Name}, Тип: {findTovar.Type}, Опис: {findTovar.Description}, Ціна: {findTovar.Cost}");
                
        }
    }
}
