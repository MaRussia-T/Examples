/*

Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

[5, 18, 123, 6, 2] -> 1

[1, 2, 3, 6, 2] -> 0

[10, 11, 12, 13, 14] -> 5



[1 2 3 4 5] -> 5 8 3

[6 7 3 6] -> 36 21
*/

//Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99].


void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
    Console.WriteLine();
}

int[] array = new int[123];
for (int i = 0; i < 123; i++)
{
    array[i] = new Random().Next(1, 123);
}


int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < 10 || array[i] > 99)
    continue;
    else sum++;
}

PrintArray(array);
Console.WriteLine(sum);


//Задача 37: Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
/*
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
    Console.WriteLine();
}
*/
Console.WriteLine("Задайте длину массива");
int length = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[length];
Console.WriteLine();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(1, 10);
}

PrintArray(arr);


for (int i = 0, j = arr.Length-1; i < arr.Length/ 2; i++, j--)
{
    Console.WriteLine(arr[i] * arr[j]);
    }




