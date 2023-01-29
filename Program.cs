// Написать программу которая из имеющегося массива строк формирует массив 
// из строк, длина которых меньше или равна 3 символа.

string[] array = { "Hello", "2", "world", ":-)", "5", "gg" };

int count = 0;
for (int i = 0; i < array.Length; i = i + 1)
{   
    string word = array[i];
    if (word.Length < 4)
    {
        count = count + 1;
    }

}
// System.Console.WriteLine(array.Length);
// System.Console.WriteLine(count);

string[] arrayResult = new string[count];
int countResult = 0;
for (int i = 0; i < array.Length; i = i + 1)
{   
    string word = array[i];

    if (word.Length<4)
    {
        arrayResult[countResult] = word;
        countResult = countResult + 1;
    }

}


for (int i = 0; i < arrayResult.Length; i = i + 1)
{   
    System.Console.WriteLine(arrayResult[i]+ " ");

}
System.Console.WriteLine();
