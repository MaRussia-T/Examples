Console.Clear();

int count = 0;
int friend = 2;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int time = 0;

for (int distance = 10000; distance > 10; count++)
{
    if (friend == 2)
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    }

    else if (friend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    }

}
Console.Write("Собака пробежит ");
Console.Write(count);
Console.Write(" раз(а)");
