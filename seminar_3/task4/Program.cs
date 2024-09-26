// Дано натуральное трёхзначное число. Создайте массив, состоящий из
// цифр этого числа. Младший разряд числа должен располагаться на 0-
// м индексе массива, старший – на 2-м. 


Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] result = new int [3];
if(number>100 && number<999)
{
    result[2] = number / 100;
    result[1] = number / 10 % 10;
    result[0] = number % 10;
    for(int k=0 ; k <result.Length;k++)
{  
    Console.Write($"{result[k]} ");
}
}
else{
    Console.WriteLine("Ошибка ввода!");
}