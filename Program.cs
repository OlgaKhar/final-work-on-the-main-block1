//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string[] StringArray(string[] array)
    {
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                count++;
            }
        }

        string[] newArray = new string[count];
        count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                newArray[count] = array[i];
                count++;
            }
        }
        return newArray;
    }

    void PrintArray(string[] array)
    {
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }

//string[] array = {"apple", "banana", "car", "dog", "elephant", "fox" }; // если массив задан, то следующие 7 строчек не нужны.
//Console.InputEncoding = Encoding.Unicode;
//Console.OutputEncoding = Encoding.Unicode;
Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine()); 
string[] array = new string[n]; 
    for (int i = 0; i < n; i++)
    {
    array[i] = Console.ReadLine()!; 
    }
          
string[] newArray = StringArray(array);

Console.WriteLine("\n Новый массив:");
 PrintArray(newArray);