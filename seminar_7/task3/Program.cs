// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d

static void CheckConsonants(string txt, int index)
{
    string vowels = "aeiouy";
    if (char.IsLetter(txt[index]))
    {
        if (!vowels.Contains(txt[index]))
        {
            Console.Write(txt[index] + " ");
        }

    }
}
void PrintСonsonants(string txt, int index)
{

    if (index == txt.Length)
    {
        return;
    }
    CheckConsonants(txt, index);
    PrintСonsonants(txt, index + 1);
}



Console.Write("Введите строку с латинскими буквами: ");
string str = Console.ReadLine();
int indx = 0;
PrintСonsonants(str, indx);
