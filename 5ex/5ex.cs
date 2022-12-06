using System;
internal class Program
{
    class Tisto
    {
        private string boroshno ="";
        private string texnika_vup = "";
        private int massa = 0;
        private double kk = 0;

        public void SetTisto()
        {
            Console.WriteLine("Vvedit tup boroshna: ");
            double mboroshna=0;
            double mtexniku=0;
            while (true)
            {
                string temp=Console.ReadLine();
                if (temp == "white" || temp=="White")
                {
                    boroshno = temp;
                    mboroshna=1.5;
                    break;
                }
                else if(temp == "wholegrain" || temp == "Wholegrain")
                {
                    boroshno = temp;
                    mboroshna = 1;
                    break;
                }
                else
                {
                    Console.WriteLine("\nNe pravulno vvedenui tup boroshna! \n");
                }
            }
            Console.WriteLine("\nVvedit texniky vupi4ku: ");
            while (true)
            {
                string temp = Console.ReadLine();
                if (temp == "crispy" || temp == "Crispy")
                {
                    boroshno = temp;
                    mtexniku = 0.9;
                    break;
                }
                else if (temp == "chewy" || temp == "Chewy")
                {
                    boroshno = temp;
                    mtexniku = 1.1;
                    break;
                }
                else if (temp == "homemade" || temp == "Homemade")
                {
                    boroshno = temp;
                    mtexniku = 1;
                    break;
                }
                else
                {
                    Console.WriteLine("\nNe pravulno vvedenui tup vupi4ku! Zanovo vvedu\n");
                }
            }
            Console.WriteLine("\nVvedit massy tista [1 - 200]: ");
            while (true)
            {
                int temp = int.Parse(Console.ReadLine());
                if (temp >=1 && temp<=200)
                {
                    massa = temp;
                    break;
                }
                else
                {
                    Console.WriteLine("\nBlyat pushe vid 1 do 200!!!! Zanovo vvedu: \n");
                }
            }
            kk = (double)((2 * massa) * mboroshna * mtexniku);

        }

        public double GetKK()
        {
            return kk;
        }
    }

    class Toppic
    {
        private string type="";
        private double kk = 0;
        private int massa=0;

        public void SetToppic()
        {
            Console.WriteLine("Vvedit tup toppic: ");
            double mtype = 0;
            while (true)
            {
                string temp = Console.ReadLine();
                if (temp == "Meat" || temp == "meat")
                {
                    type = temp;
                    mtype = 1.2;
                    break;
                }
                else if (temp == "Veggies" || temp == "veggies")
                {
                    type = temp;
                    mtype = 0.8;
                    break;
                }
                else if (temp == "Cheese" || temp == "cheese")
                {
                    type = temp;
                    mtype = 1.1;
                    break;
                }
                else if (temp == "Sauce" || temp == "sauce")
                {
                    type = temp;
                    mtype = 0.9;
                    break;
                }
                else
                {
                    Console.WriteLine("\nV nas nema takoho tupe toppic iak "+temp+", vvedit 4to-to drygoe: ");
                }
            }
            Console.WriteLine("\nVvedit massy toppic: ");
            while (true)
            {
                int temp = int.Parse(Console.ReadLine());
                if (temp >= 1 && temp <= 200)
                {
                    massa = temp;
                    break;
                }
                else
                {
                    Console.WriteLine("\nMassa "+type+" povunna bytu v meshax [1 - 50]. Vvedit zanovo: ");
                }
            }
            kk = (double)(2*massa*mtype);
        }

        public double GetKK()
        {
            return kk;
        }
    }

    class Pizza
    {
        private string name;
        private double kk=0;

        public void SetPizza()
        {
            Tisto tisto = new Tisto();
            Console.WriteLine("Vvedit nazvy pizzu (1-15 sumvoliv):");
            while (true)
            {
                string temp = Console.ReadLine();
                if (temp.Length >= 1 && temp.Length <= 15 && temp != "" && temp != " ")
                {
                    name = temp;
                    break;
                }
                else
                {
                    Console.WriteLine("Ne moshe bytu pystota, probel ili menshe 1 i bolshe 15 simvolov! Vvedit znovy: ");
                }
            }
            Console.WriteLine();
            tisto.SetTisto();
            kk += tisto.GetKK();
            int i = 1;
            Console.WriteLine();
            while (true)
            {
                Console.Write("["+i+"]");
                i++;
                Toppic toppic = new Toppic();
                toppic.SetToppic();
                kk += toppic.GetKK();
                Console.WriteLine("\n(Vvedit END dlia zakin4enia)");
                string temp = Console.ReadLine();
                if(temp=="END" ||temp == "end" || temp == "End")
                {
                    break;
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n"+name+" - "+kk+" Calories");
        }
    }
    static void Main()
    {
        Pizza pizza = new Pizza();
        pizza.SetPizza();
    }
}
