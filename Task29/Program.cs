using System;
/* Задача 29: Напишите программу, которая задаёт 
массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int [] array = new int[8];
new string= ConvertToString(new int[8]);


//new array[] = Convert.ToInt32(new int[]);

Console.WriteLine($"Ведите числа 8 элементов: {new string}, ");
Console.ReadLine();
for (int i = 0; i < array.Length; i++)
{
    array[i] = new string;
    Console.WriteLine($"{array[i]}");
}



/*void PrintArray (int[] array)
{
    int count = array.Length;

    for(int i = 0; i<count; i++ )
    {
        Console.Write($"{array} ");
    }
    Console.WriteLine();
}*/