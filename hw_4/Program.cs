Console.WriteLine("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());
int i=1;
int n;

Console.WriteLine($"Цифры числа {number}:");

while (i < number)
{
    n = number % (10*i)/i;
    i=i*10;
    Console.Write(" " + n);   
}