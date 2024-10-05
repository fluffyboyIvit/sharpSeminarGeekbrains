// Задайте строку, состоящую
// из слов, разделенных пробелами. Сформировать строку,
// в которой слова расположены в обратном порядке. В
// полученной строке слова должны быть также разделены
// пробелами.


string InvertString(string str)
{
    string[] strNewSplit = str.Split();
    string strInvert = "";
    for (int i = strNewSplit.Length-1; i >= 0; i--)
    {
        strInvert += strNewSplit[i] + " ";
    }
    return strInvert;
}
Console.WriteLine("Введите предложение: ");
string str = Console.ReadLine();
string result = InvertString(str);
Console.WriteLine(result);