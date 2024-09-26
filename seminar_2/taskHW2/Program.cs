// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка

Console.WriteLine("Введите X координату: ");
int coordinateX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y координату: ");
int coordinateY = Convert.ToInt32(Console.ReadLine());

if (coordinateX > 0 && coordinateY > 0)
{
    Console.WriteLine("Первая четверь");
}
else if (coordinateX < 0 && coordinateY > 0)
{
    Console.WriteLine("Вторая четверь");
}
else if (coordinateX < 0 && coordinateY < 0)
{
    Console.WriteLine("Третья четверь");
}
else if (coordinateX > 0 && coordinateY < 0)
{
    Console.WriteLine("Четвертая четверь");
}
else
{
    Console.WriteLine("Ошибка: нельзя определить четверть из-за нулевых координат");
}