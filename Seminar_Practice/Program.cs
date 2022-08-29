// // // // типы функций

// // // void DO() //ничего не принимает и ничего не отдает
// // // {

// // // }

// // // void DO2(int number) //функция принимаает число и ничего не отдает
// // // {

// // // }

// // // int DO3() //функция ничего не принимает и отдает число
// // // {
// // //     return 1;
// // // }

// // // int DO4(int number)//функция принимаает число и отдает число
// // // {
// // //     return number;
// // // }

// // // string DO5(int number) // функция принимает число и отдает строку
// // // {
// // //     return number.ToString() + " яблок";
// // // }
// // // string str = DO5(5);
// // // Console.WriteLine(str);


// void PowDoubleNumber(int number) // функция принимает число и ничего не отдает
// {
//     number = number * number; // число умножается на само себя
//     Console.WriteLine(number); // вывод числа
// }
// int DoubleNumber(int number) // функция принимает число и отдает тоже число
// {
//     number = number * 2; // берем число и умножаем его на 2
//     return number; // отдаем полученное число
// }


// int number = 12; // создаем переменную и сохраняем число
// PowDoubleNumber(number); // вызываем функцию где передаем число которое умножается на само себя и выводить
// number = DoubleNumber(number); // обращаемся к нашей переменной снова и пересохраняем ее данные через функцию
// Console.WriteLine(number); // вывом результат

int ReadStringConvertInt(string word)
{
    return int.Parse(word);
}

int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(0, 2);
    }
    return result;
}

void GetConsoleArray(int[] array)
{
    Console.WriteLine($"[{String.Join(",", array)}]");
}


int number = ReadStringConvertInt(Console.ReadLine());
int[] array = GetBinaryArray(number);
GetConsoleArray(array);

