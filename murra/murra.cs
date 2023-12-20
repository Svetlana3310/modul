using System;

abstract class Drink
{
    public abstract void Prepare();
}

class Coffee : Drink
{
    public override void Prepare()
    {
        Console.WriteLine("Preparing Murra Coffee");
    }
}

class Tea : Drink
{
    public override void Prepare()
    {
        Console.WriteLine("Preparing Murra Tea");
    }
}

class DrinkFactory
{
    public Drink CreateDrink(string type)
    {
        Drink drink = null;

        switch (type.ToLower())
        {
            case "coffee":
                drink = new Coffee();
                break;
            case "tea":
                drink = new Tea();
                break;
            default:
                throw new ArgumentException("Invalid drink type");
        }

        return drink;
    }
}

class Program
{
    static void Main()
    {
        DrinkFactory drinkFactory = new DrinkFactory();

        Drink coffee = drinkFactory.CreateDrink("coffee");
        coffee.Prepare();

        Drink tea = drinkFactory.CreateDrink("tea");
        tea.Prepare();
    }
}
