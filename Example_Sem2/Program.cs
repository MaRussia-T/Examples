class Hero
{
    public string Name;
    public string Sex;
    public string Rase;
    public string Class;
    public Dictionary<string, int> Skills = new Dictionary<string, int>()
    {
        {"Сила",0},
        {"Удача",0},
        {"Ловкость",0},
        {"Харизма",0},
        {"Эмпатия",0},
        {"Красноречие",0},
    };
}

class InRase
{
    public string Name;
    public string Ability;
    public string Bonus;
    public string Side;

    public Dictionary<string, int> Skills = new Dictionary<string, int>()
    {
        {"Сила",0},
        {"Удача",0},
        {"Ловкость",0},
        {"Харизма",0},
        {"Эмпатия",0},
        {"Красноречие",0},
    };
    public InRase(string name, string ability, string bonus, string side, Dictionary<string, int> skills)
    {
        Name = name;
        Ability = ability;
        Bonus = bonus;
        Side = side;
        Skills = skills;
    }
}



class Program
{
    public static InRase[] Rases ={
    

new InRase("Люди", "Fire", "Intelect", "sw", new Dictionary<string, int>(){
        {"Сила",10},
        {"Удача",5},
        {"Ловкость",6},
        {"Харизма",5},
        {"Эмпатия",4},
        {"Красноречие",7},
}),
new InRase("Эльфы", "Fly", "Magic", "sw", new Dictionary<string, int>(){
        {"Сила",8},
        {"Удача",8},
        {"Ловкость",6},
        {"Харизма",7},
        {"Эмпатия",5},
        {"Красноречие",9},
}),
new InRase("Орки", "Fire", "Intelect", "sw", new Dictionary<string, int>(){
        {"Сила",10},
        {"Удача",3},
        {"Ловкость",3},
        {"Харизма",2},
        {"Эмпатия",1},
        {"Красноречие",1},
}),
new InRase("Гоблины", "Fire", "Intelect", "sw", new Dictionary<string, int>(){
        {"Сила",9},
        {"Удача",4},
        {"Ловкость",6},
        {"Харизма",3},
        {"Эмпатия",2},
        {"Красноречие",1},
}), new InRase("Гномы", "Fire", "Intelect", "sw", new Dictionary<string, int>(){
        {"Сила",10},
        {"Удача",7},
        {"Ловкость",8},
        {"Харизма",3},
        {"Эмпатия",4},
        {"Красноречие",8},
}),
    };
    static void SelectRase(Hero myHero)
    {
        string[] nameRase = { "Люди", "Эльфы", "Орки", "Гоблины", "Гномы" };
        Console.WriteLine("Выбери свою расу");
        Select(nameRase);
        InRase RaseHero = Rases[Convert.ToInt32(Console.ReadLine()) - 1];
        Console.WriteLine("Вы выбрали расу " + RaseHero.Name);
        myHero.Rase = RaseHero.Name;
        myHero.Skills = RaseHero.Skills;

    }

    static void SelectSex(Hero myHero)
    {
        string[] nameSex = { "женский", "мужской" };
        Console.WriteLine("Выбери свой пол");
        Select(nameSex);
        string SexHero = nameSex[Convert.ToInt32(Console.ReadLine()) - 1];
        Console.WriteLine("Вы выбрали пол " + SexHero);
        myHero.Sex = SexHero;
    }

    static void SelectClass(Hero myHero)
    {
        string[] nameClass = { "Воин", "Разбойник", "Маг", "Вор" };
        Console.WriteLine("Выбери свой класс");
        Select(nameClass);
        string ClassHero = nameClass[Convert.ToInt32(Console.ReadLine()) - 1];
        Console.WriteLine("Вы выбрали класс " + ClassHero);
        myHero.Class = ClassHero;
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
        Hero myHero = new Hero();
        Console.WriteLine("Как вас зовут?");
        myHero.Name = Console.ReadLine();
        SelectRase(myHero);
        SelectSex(myHero);
        SelectClass(myHero);

        Console.WriteLine("Все наши характеристики");
        Console.WriteLine("Ваше имя " + myHero.Name);
        Console.WriteLine("Ваш пол " + myHero.Sex);
        Console.WriteLine("Ваша раса " + myHero.Rase);
        Console.WriteLine("Ваш класс " + myHero.Class);
        Console.WriteLine("Сила"+myHero.Skills["Сила"]);
        Console.WriteLine("Удача"+myHero.Skills["Удача"]);
        Console.WriteLine("Ловкость"+myHero.Skills["Ловкость"]);
        Console.WriteLine("Харизма"+myHero.Skills["Харизма"]);
        Console.WriteLine("Эмпатия"+myHero.Skills["Эмпатия"]);
        Console.WriteLine("Красноречие"+myHero.Skills["Красноречие"]);

    }

}
