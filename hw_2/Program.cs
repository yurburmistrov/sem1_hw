Console.WriteLine("Введите координаты точки по оси X, не равные 0");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки по оси Y не равные 0");
int y = Convert.ToInt32(Console.ReadLine());

if (x < 0 && y > 0)
{
    Console.WriteLine($"Точка с координатами ({x},{y}) принадлежит II четверти координатной плоскости");
}

if (x < 0 && y < 0)
{
    Console.WriteLine($"Точка с координатами ({x},{y}) принадлежит III четверти координатной плоскости");
}

if (x > 0 && y < 0)
{
    Console.WriteLine($"Точка с координатами ({x},{y}) принадлежит IV четверти координатной плоскости");
}

if (x > 0 && y > 0)
{
    Console.WriteLine($"Точка с координатами ({x},{y}) принадлежит I четверти координатной плоскости");
}

if (x == 0 || y == 0)
{
    Console.WriteLine($"Одна или обе координаты равны 0");
}