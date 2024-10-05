// Задайте произвольную строку. Выясните,
// является ли она палиндромом.

bool StringIsPolyndrom (string str)
{   
    int  count = str.Length-1;

    for (int i = 0; i < str.Length/2; i++)
    {
        if(str[i]!= str[count])
        {   
            return   false;
        }
        count--;
    }
    return true;
}
Console.WriteLine("Введите строку: ");
string str = Console.ReadLine();

bool polyndoromTrue = StringIsPolyndrom(str);
string result = polyndoromTrue ? "Да": "Нет";
Console.WriteLine(result);