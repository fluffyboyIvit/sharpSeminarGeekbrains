// Определение, является ли число положительным
// Описание: Напишите метод, который на вход принимает число и выводит, является ли
// оно положительным (больше нуля), отрицательным (меньше нуля) или нулём.


class Answer {
static void CheckNumber(int number)
{
// Введите свое решение ниже
if(number < 0)
{
    Console.WriteLine("отрицательное");
}
else if(number == 0)
{
    Console.WriteLine("ноль");
}
else
{
    Console.WriteLine("положительное");
}
}
static public void Main(string[] args) {
int number;
if (args.Length >= 1) {
number = int.Parse(args[0]);
} else {
number = 7;
}
CheckNumber(number);
}
}
