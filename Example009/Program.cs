/*Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Результат");
Console.WriteLine(a + b);*/




int resul1 = 0;
int resul2 = 0;
int crat = 2;

while (true)
{
    Console.WriteLine("Введите число или команду");
    string? res = Console.ReadLine();
    if (res == "end")
    {
        break;
    }
    else if (res == "num")
    {
        Console.WriteLine("Введите кратное число");
        crat = Convert.ToInt32(Console.ReadLine());
        resul1 = 0;
        resul2 = 0;
    }
    else
    {
        int number = Convert.ToInt32(res);
        if (number % 2 == 0)
        {
            resul1 += number;
        }
        else
        {
            resul2 += number;
        }

    }
}
Console.WriteLine(resul1.ToString() + "Сумма кратных чисел");

Console.WriteLine(resul2.ToString() + "Сумма не кратных чисел");
Console.WriteLine(crat.ToString() + "Кратное число");

