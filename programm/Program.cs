// Из имеющегося массива строк сформировать массив из строк, длина которых меньше либо равна 3. //

System.Console.Write("Введите массив строк через пробел:");
string input = Console.ReadLine() ?? "";
string[] stringArray = input.Split(" ");
int j = 0;
int k = 0;

for (int i = 0; i < stringArray.Length; i++)
{
    if (stringArray[i].Length <= 3)
    {
        j++;
    }
}

string[] newStringArray = new string[j];

for (int i = 0; i < stringArray.Length; i++)
{
    if (stringArray[i].Length <= 3)
    {
        newStringArray[k] = stringArray[i];
        k++;
    }
}

System.Console.Write("['" + String.Join("', '", stringArray) + "']" + " --> " + "['" + String.Join("', '", newStringArray) + "']");