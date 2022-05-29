/*
// Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.

int VowelLetterCount(string[] array)
{
    int count = 0;
    char[] vowels = "aeiouy".ToCharArray();
    foreach(string word in array)
        foreach(char letter in vowels)
            if(word.ToLower().StartsWith(letter))
                count++;
    return count;
}
string[] VowelArray = { "qwe", "wer", "ert", "rty", "tyu"};
Console.Write("{" + string.Join(", ", VowelArray) + "} -> ");
Console.WriteLine(VowelLetterCount(VowelArray));
Console.WriteLine();
*/

/*
// Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.

string[] PairLetter(string[] array)
{
    int al = array.Length / 2 + array.Length % 2;
    string[] outArray = new string[al];
    for(int i = 0, j = 0; i < array.Length - 1; i += 2, j++)
    {
        outArray[j] = (array[i] + array[i + 1]);
        if(array.Length % 2 != 0 && j == al - 2)
        {
            outArray[al - 1] = array[array.Length-1];
            break;
        }
    }
    return outArray;
}
string[] PairArray = { "qwe", "wer",
                       "ert", "rty",
                       "tyu", "yui"};

Console.WriteLine("{\"" + string.Join("\", \"", PairArray)+ "\"" + " -> " + "\"" + string.Join("\", \"", PairLetter(PairArray)) + "\"}");
*/