using System;

class Chicken
{
    private string name;
    private int age;
    public Chicken()
    {
        name = "noname";
        age = 1;
    }

    public void SetChicken()
    {
        Console.WriteLine("Vvedit name: ");
        name = Console.ReadLine();
        Console.WriteLine("Vvedit age: ");
        age =int.Parse(Console.ReadLine());
    }

    public void GetMessage()
    {
        if (name == " " || name == "")
        {
            Console.WriteLine("Name cannot be empty");
        }
        else if (age < 0 || age>15)
        {
            Console.WriteLine("Age should be between 0 and 15");
        }
        else
        {
            Random rnd = new Random();
            int value = rnd.Next(1, 4);
            Console.WriteLine("Chicken "+name+" (age "+age+") can produce "+value+" eggs per day.");
        }
    }
}
internal class Program
{
    static void Main()
    {
        Chicken a = new Chicken();
        a.SetChicken();
        a.GetMessage();
    }
}
