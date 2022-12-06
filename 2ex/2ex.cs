using System;

class Box
{
    private double length;
    private double width;
    private double height;

    private double searea;
    private double laterals;
    private double volume;

    public void SetBox()
    {
        Console.WriteLine("Vvedit length: ");
        length = double.Parse(Console.ReadLine());
        Proverka(ref length);


        Console.WriteLine("Vvedit width: ");
        width = double.Parse(Console.ReadLine());
        Proverka(ref width);


        Console.WriteLine("Vvedit height: ");
        height = double.Parse(Console.ReadLine());
        Proverka(ref height);

    }

    public void Proverka (ref double a)
    {
        if (a <= 0)
        {
            bool b = false;
            while (b == false)
            {
                Console.WriteLine("Danue ne mogyt but <0!!!!!!\n");
                Console.WriteLine("Vvedit zanovo peremennyy: ");
                a= double.Parse(Console.ReadLine());
                if(a > 0)
                {
                    b = true;
                }
            }
        }
    }

    public void GetSLV()
    {
        volume = (length * width * height);
        laterals = 2 * (length * height) + 2 * (width * height);
        searea = laterals + 2 * (length * width);

        Console.WriteLine("Surface Area – " + Math.Round(searea, 2));
        Console.WriteLine("Lateral Surface Area – " + Math.Round(laterals, 2));
        Console.WriteLine("Volume – " + Math.Round(volume, 2));
    }
}
internal class Program
{
    static void Main()
    {
        Box box = new Box();
        box.SetBox();
        Console.WriteLine();
        box.GetSLV();
    }
}
