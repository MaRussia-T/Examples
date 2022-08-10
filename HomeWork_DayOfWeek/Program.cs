
//Console.WriteLine("Задача 15");
//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
class Week
{
    public string Day;
}

class Program
{
       static void SelectDay(Week myDay)
    {
        string[] nameDay = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
        Console.WriteLine("Выбери день недели");
        Select(nameDay);
        string dayOfWeek = nameDay[Convert.ToInt32(Console.ReadLine()) - 1];
        myDay.Day = dayOfWeek;

        if (dayOfWeek == "Суббота" || dayOfWeek == "Воскресенье")

            Console.WriteLine("Ваш день недели " + dayOfWeek + " - выходной");
        else
            Console.WriteLine("Ваш день недели " + dayOfWeek + " - будний");
    }
    static void Select(string[] words)
    {
        for (int i = 0; i < words.Length - 1; i++)
        {
            Console.Write(i + 1 + " - " + words[i] + ", ");
        }
        Console.WriteLine(words.Length + " - " + words[words.Length - 1] + ". ");
        Console.WriteLine("");
    }

    static void Main(string[] args)
    {
        Week myDay = new Week();
        SelectDay(myDay);
    }
}