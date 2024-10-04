// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

int CountVowelsLetters(string str)
{   int count = 0;
    string vowels = "aeiouy";
    for (int i = 0; i < str.Length; i++)
    {
        for (int j = 0; j < vowels.Length; j++)
        {
            if (vowels[j] == str[i])
            {
                count++;
            }
        }
    }
    return count;
}

Console.Write("Введите слово: ");
string word = Console.ReadLine();
int result = CountVowelsLetters(word);
Console.WriteLine($"в слове {word}, {result} глассных");

