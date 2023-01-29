// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int[] CreateArrayRndInt(int size, int min, int max)
{         
    int[] array = new int[size];
    Random rnd = new Random();  
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1); 
    }
    return array; 
}

//выводим на экран
void PrintArray(int[] array)

{
    Console.Write("Заданный массив -> [");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

//Программа
int[] arrayRandom=CreateArrayRndInt(8,-100,100);
PrintArray(arrayRandom);
