// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

int number;
int fristDigit;
int secondDigit;
int sum;

Console.Write("Введите трёхначиное положительное число: ");
number = Convert.ToInt32(Console.ReadLine());

if (100 <= number && number <= 999)
{
    fristDigit = number/ 100;
    secondDigit = number % 10;
    sum = fristDigit + secondDigit;
    Console.WriteLine($"Сумма первой и последней цифры числа {number} равна: {sum}");
}
else{
    Console.WriteLine("Ошибка ввода!");

}