// // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // В итоге получается вот такой массив:
// // 7 4 2 1
// // 9 5 3 2
// // 8 4 4 2

/*

int[,] GenerateArray(int t, int i)
{
    int[,] table = new int[t, i];
    Random random = new Random();
    for (int a = 0; a < t; a++)
    {
        for (int b = 0; b < i; b++)
        {
            table[a, b] = random.Next(0, 9);
        }
    }
    return table;
}
void PrintArray(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            Console.Write(array[a, b] + " ");
        }
        Console.WriteLine();
    }
}
void BubbleSort(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = 0; j < inArray.Length - i - 1; j++)
        {
            if (inArray[j] > inArray[j + 1])
            {
                int temp = inArray[j];
                inArray[j] = inArray[j + 1];
                inArray[j + 1] = temp;
            }
        }
    }
}
void Insert(bool isRow, int dim, int[] sourse, int[,] dest)
{
    for (int k = 0; k < sourse.Length; k++)
    {
        if (isRow)
        {
            dest[dim, k] = sourse[k];
        }
        else
        {
            dest[k, dim] = sourse[k];
        }
    }

}

int colCount = 6;
int rowCount = 5;

int[,] arr = GenerateArray(rowCount,colCount);
Console.WriteLine("Исходный массив");
PrintArray(arr);

Console.WriteLine("Сортировка по столбцам:");

int[] col = new int[rowCount];
for(int i=0; i<colCount; i++)
{
    for(int j=0; j<rowCount; j++)
    {
        col[j]=arr[j,i];
    }
    BubbleSort(col);
    Insert(false, i, col, arr);
    }
PrintArray(arr);






// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
//суммой элементов:
//  1 строка


Console.WriteLine("Введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество элементов массива в строке n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
Random myRandom = new Random();
Console.WriteLine(" ");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = myRandom.Next(0, 10 + n);
        Console.Write("{0}\t", array[i, j]);
    }
    Console.WriteLine(" ");
}
int result = 1;
int temp1 = 0, temp2 = 0;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i == 0)
        {
            temp2 += array[i, j];
            temp1 = temp2;
        }
        else { temp2 += array[i, j]; }
    }
    if (temp1 > temp2)
    {
        result = i + 1;
        temp1 = temp2;
        temp2 = 0;
    }
    temp2 = 0;
}
Console.WriteLine(" ");
Console.Write("строка с наименьшей суммой элементов: {0}", result);
Console.WriteLine(" ");
Console.WriteLine(" ");





*/


//  Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение 
//двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.WriteLine("Введите количество строк первого массива");
int rows=int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первого массива");
int columns=int.Parse(Console.ReadLine());

int[,] matrix1=FillArray(rows,columns);

Console.WriteLine("Введите количество строк второго массива");
rows=int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второго массива");
columns=int.Parse(Console.ReadLine());

int[,] matrix2=FillArray(rows,columns);

int[,] matrix3 = ProductMatrix(matrix1, matrix2);
PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine();
PrintArray(matrix3);


int[,] FillArray(int n,int m)
{
    int[,] res=new int[n,m];
    for(int i=0; i<n;i++)
    {
        for (int j = 0; j < m; j++)
        {
            res[i,j]=new Random().Next(10);
        }
    
    }
    return res;
}
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        for (int j = 0 ; j < matrix.GetLength(1)  ; j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}
int[,] ProductMatrix(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        System.Console.WriteLine("Матрицы невозможно перемножить в таком порядке!");
        return matrix1;
    }
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                matrix3[i, j] +=matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrix3;
}




// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)




// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07