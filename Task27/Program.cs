/* Задача 27: Напишите программу, которая принимает 
на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12*/

Console.WriteLine("введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
int count = 0; // количество цифр в числе

while (a > 0)
{
    a = a/10;
    count++;
}
Console.WriteLine("количество цифр = " + count);