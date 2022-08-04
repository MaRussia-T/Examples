Console.Clear();

int count = 0;
int friend = 2;
//Console.WriteLine("Введите скорость первого друга");
int firstFriendSpeed = 1; //Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите скорость второго друга");
int secondFriendSpeed = 2; //Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите скорость собаки");
int dogSpeed = 5; //Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Задайте дистанцию");
 //Convert.ToInt32(Console.ReadLine());
int time = 0;


for (int distance = 10000; distance > 10; count++)
{
    
    if (friend == 2)
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    }
    
    else if(friend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    }
    
}
Console.Write("Собака пробежит ");
Console.Write(count);
Console.Write(" раз(а)");
