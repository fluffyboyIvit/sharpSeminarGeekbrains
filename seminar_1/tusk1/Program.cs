// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

int numMax;
int count;
Console.Write("Введите целое положительное число: ");
numMax = Convert.ToInt32(Console.ReadLine());
count = numMax * -1;

if (numMax>0)
{
 while(count<=numMax) 
 {
    Console.Write(count);
    Console.Write(" ");
    count++ ;
 }
}
else
{
   Console.WriteLine("Ошибка ввода!");
}