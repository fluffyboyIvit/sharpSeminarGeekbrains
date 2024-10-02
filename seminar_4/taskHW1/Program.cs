//  Напишите программу, которая бесконечно запрашивает целые числа с консоли.
//  Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

int AssignValue()
{
    String inputValue = Console.ReadLine();
    if (inputValue == "q")
    {
        return 0;
    }
    else
    {
        int num = Convert.ToInt32(inputValue);
        return num;
    }
}
void PrintArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == 0)
        {
            break;
        }
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]} ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }

    }
}

bool BoolDigitSumEven(int num)
{
    bool result = false;
    int count = 0;
    int num1 = num;
    int sum = 0;

    while (num != 0)
    {
        num /= 10;
        count++;
    }

    int[] arr = new int[count];
    for (int i = 0; i < count; i++)
    {
        arr[i] = num1 % 10;
        num1 /= 10;
    }
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }
    if (sum % 2 == 0)
    {
        result = true;
    }
    return result;
}

void CheckNumber()
{
    int number;
    int[] array = new int[100]; //массив сделал для запоминания предыдущих чисел
    int count = 0;
    while (true)
    {
        number = AssignValue();
        if (number == 0 || BoolDigitSumEven(number) == true)
        {
            array[count] = number;
            PrintArray(array);
            return;
        }
        else
        {
            array[count] = number;
            PrintArray(array);
            count++;
        }
    }
}
Console.WriteLine("Введите число: ");
CheckNumber();

