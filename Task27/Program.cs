/* Задача 27: Напишите программу, которая принимает 
на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12*/

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
//string stringNum = num.ToString();
int sum = 0;
while (num > 0)
    {
    sum = sum+num%10;
    num/=10;
    }
Console.WriteLine($"сумма чисел равна={sum}");



    
 

/*int sum = 0;
while (num != 0)
{
   a = a+count(i);
   int summ = a + acount(i);
}
Console.WriteLine("сумма цифр = " + summ);*/