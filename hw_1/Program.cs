int number = 322;

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine($"Условие кратности числа {number} одновременно числам 7 и 23 выполняется");
}
else
{
    Console.WriteLine($"Условие кратности числа {number} одновременно числам 7 и 23 не выполняется");
}