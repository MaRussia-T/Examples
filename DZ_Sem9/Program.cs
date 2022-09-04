// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""



int WriteNumber(int a, int b)
 {
     Console.WriteLine(a+" ");
     if(a==b) return b;
   return WriteNumber(a+1,b);

 }
 WriteNumber(1, 5);



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



int WriteNumb(int a, int b, int sum=0)
{
    sum+=a;
    if(a==b) return sum;
    return WriteNumb(a+1,b, sum);

}
Console.WriteLine(WriteNumb(4, 8)); 


//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

//m = 2, n = 3 -> A(m,n) = 29

int A(int n, int m)
{
    if (n == 0) return m + 1;
    else
    if ((n!=0) &&(m == 0)) return A(n - 1, 1);
    else
    return A(n - 1, A(n, m - 1));
}
Console.WriteLine(A(3, 2));