﻿using System.Text.RegularExpressions;
/* Задача 25: Напишите цикл, который принимает 
на вход два числа (A и B) и возводит число A 
в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16*/


Console.WriteLine("введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int result =  Convert.ToInt32(Math.Pow(A, B)); 

if (A > 0 && B>0)
{
    Console.WriteLine("А в степени В = "+ result); 
}
