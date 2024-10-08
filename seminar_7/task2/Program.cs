// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// Указание
// Использовать рекурсию
int SumDigitNumber(int num)
{
    
    if(num==0)
    {
        return 0;
    }
    
    return  num % 10 + SumDigitNumber(num/10) ;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumDigitNumber(number);
Console.WriteLine(result);