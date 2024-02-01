Console.WriteLine("Введите целое число из отрезка [10, 99]");
int number = Convert.ToInt32(Console.ReadLine());

int firstDigit = number / 10;
int secondDigit = number % 10;

if (firstDigit > secondDigit)
{
    Console.WriteLine($"Наибольшей цифрой числа {number} является {firstDigit}");
}

if (firstDigit < secondDigit)
{
    Console.WriteLine($"Наибольшей цифрой числа {number} является {secondDigit}");
}

if (firstDigit == secondDigit)
{
    Console.WriteLine($"Число {number} является палиндромным!");
}