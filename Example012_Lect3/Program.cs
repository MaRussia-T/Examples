/*
// Вид 1 - метод ничего не принимает и ничего не возвращает

void Method1()
{
    Console.WriteLine("Автор ...");
}
//Method1(); //вызов метода


// Вид 2 - метод ничего не принимает, но что-то возвращает

void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg:"Текст сообщения");

void Method21(string msg, int count)
{
    int i=0;
    while(i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
    
}
//Method21("Текст", 4); //вызов метода путем указания аргументов
//Method21(msg: "Текст", count: 4); // явно указываем, какому аргументу какое значение хотим присвоить
// при использовании явных аргументов не обязательно указывать их по порядку
//Method21(count: 4, msg: "новый текст");


// Вид 3 - метод что-то принимает и ничего не возвращает
// если метод что-то возвращает, обязательно указываем тип данных, который ожидаем

int Method3()
{
    return DataTime.Now.Year;
}
int year = Method3(); // сюда кладется результат работы метода
Console.WriteLine(year);

// Вид 4 - метод что-то принимает и что-то возвращает

string Method4(int count, string text) // при переименоывании путем "правая кнопка мыши -> перемиеновать" призойдет переименование во всем коде
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res= Method4(10, "z");
Console.WriteLine(res);
*/
/*
// Цикл for

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count;i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res); 
*/
/*
// ЦИКЛ В ЦИКЛЕ
// построение таблицы умножения

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i}x{j}={i*j}"); //интерполяция строк (вводим произведение)
    }
    Console.WriteLine();
}
*/
/*
// Practice

// ===== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + " вы бы взяли приступом согласие прусского короля."
            + " Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();
 newText = Replace(newText, 'к', 'К');
 Console.WriteLine(newText);
 


int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)

    {
        System.Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length -1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}


PrintArray(arr);
SelectionSort(arr);
PrintArray(arr); */


// Конспект семинара 4





/*  static void ReadNumber(int number)
  {
      Console.WriteLine(number * number);
  }

  static string WriteNumber(int number)
  {
      return number %2 == 0 ? "Кратное" : "Не кратное";
  }
  public static void Main(string[] args)
  {
      int number = Convert.ToInt32(Console.ReadLine());
      ReadNumber(number);
      System.Console.WriteLine(WriteNumber(number));
      Console.ReadLine();
  }
  */

class Program
{
    /* static int PowTwoNumber(int number)
     {
         return number * number;
     }

     static string MultipleTwoNumber(int number)
     {
         return number % 2 == 0 ? "Кратное" : "Не кратное";
     } */

    static int[] Shuffle(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int j = new Random().Next(0, i + 1);
            int tmp = array[i];
            array[i] = array[j];
            array[j] = tmp;
        }
        return array;
    }
    static int[] CreaterArray(int number)
    {
        int[] array = new int[number];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }
        return array;
    }
    static void WriteArray(int[] array)
    {
        Console.WriteLine("Вывод массива");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }

    static void Main(string[] args)
    {
        //int number = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine(PowTwoNumber(number));
        // Console.WriteLine(MultipleTwoNumber(PowTwoNumber(number)));
        //
        int[] array = CreaterArray(30);
        WriteArray(array);
        array = Shuffle(array);
        Console.ReadLine();
    }
}