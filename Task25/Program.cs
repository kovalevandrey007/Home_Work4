using System.Text.RegularExpressions;
using System.Xml.Schema;
/* Задача 25: Напишите цикл, который принимает 
на вход два числа (A и B) и возводит число A 
в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int A; int B(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }
    
    return result;
}

int Match.Pow (int A, int B)
{
    int expon = 0;
    for (int i = 1; i <= A && i <= B; i++)
    {
        expon += i;
    }

    return expon;
}

int A = GetNumber("Введите первое число");
int B = GetNumber("Введите второе число");
int expon= Match.Pow(A, B);

Console.WriteLine($"{А }  в степени {B} = {expon}");
