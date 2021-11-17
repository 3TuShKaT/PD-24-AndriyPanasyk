//Перевірити істинність вислову: "Цифри даного тризначного числа утворюють арифметичну прогресію". 

Console.WriteLine("Введіть тризначне число: ");
int number = int.Parse(Console.ReadLine());
int firstItem, secondItem, thirdItem;

firstItem = number / 100;
secondItem = (number / 10 ) % 10;
thirdItem = number % 10;

if (firstItem + secondItem == thirdItem)
{
    Console.WriteLine("Арифметична прогресія вірна");
}
else
{
    Console.WriteLine("Число не утворює арифметичну прогресію");
}
