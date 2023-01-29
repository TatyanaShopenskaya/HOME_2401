// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
 
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number<0) number=number*(-1);
int SumNumbers(int num)
{
    int sum=0;
    while (num != 0) 
    {
        int a = num % 10;
        sum = sum + a;
        num = num / 10;
    }
    return sum;
}
int sumNumbers=SumNumbers(number);
Console.WriteLine(sumNumbers);

 
