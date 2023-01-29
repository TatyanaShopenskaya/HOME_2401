// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число, натуральное");
int b = Convert.ToInt32(Console.ReadLine());

int result=1;
int index=0;
if (b<1) Console.WriteLine("Введены некорректные данные");
while (index<b)
    {
        result = result*a;
        index++;
    }

Console.WriteLine(result);
return result;
