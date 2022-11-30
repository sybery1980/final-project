/*
Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа.
Перовначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

// создание произвольного массива
string[] newArray()
{
    Console.WriteLine("Введите количество элементов массива");
    int n = Convert.ToInt32(Console.ReadLine());
    string[] a = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Введите {0}-й элемент", i + 1);
        a[i] = Console.ReadLine();
    }
    return a;
}

//печать массива
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < (array.Length - 1)) Console.Write($" ");

    }
    Console.WriteLine();
}

// метод создания массива менше 3-х символов
void NewArrayWith3SymbolElements(string[] array, string[] array2)
{
    int count = 0;
    int maxIndex = 3;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i].Length <= maxIndex)
        {
            array2[count] = array[i];
            count++;
        }
    }
}

string[] array = newArray();
string[] array2 = new string[array.Length];
Console.WriteLine("Исходный массив: ");
PrintArray(array);
NewArrayWith3SymbolElements(array, array2);
Console.WriteLine("Массив из строк, длина которых меньше либо равна 3 символа: ");
PrintArray(array2);