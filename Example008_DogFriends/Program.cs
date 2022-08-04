Console.Clear();
Console.WriteLine("Введите скорость первого друга");
int firstFriendSpeed = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите скорость второго друга");
int secondFriendSpeed = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите скорость собаки");
int dogSpeed = Convert.ToInt32(Console.ReadLine());
int distance = 10000;
int friend = 2;
int count = 0;

while (distance > 10)
{
    if (friend != 2)
    {
        int distance = 10000;
        int time = distance / (secondFriendSpeed + dogSpeed);
        int distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
        count++;
    }
    else
    {
        int time = distanse / (firstFriendSpeed + dogSpeed);
        int friend = 2;
        int distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
        count++;
    }
}
Console.WriteLine("Собака пробежит", count, "раз");
