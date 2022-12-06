using System;

internal class Program
{
    static void FindWord(ref string v, ref string temp)
    {
        string b = "";
        for (int i = 0; i < v.Length; i++)
        {
            if (v[i] == ' ')
            {
                v = v.Remove(i, 1);
                break;
            }
            else
            {
                b += v[i];
                v = v.Remove(i, 1);
                i--;
            }
        }
        temp = b;
    }
    class Person
    {
        private string name;
        private double money;
        private string bag = "Ni4ego ne kypil";

        public void SetPerson()
        {
            Console.WriteLine("Vvedit name personu: ");
            name=Console.ReadLine();
            if (name ==" "||name=="")
            {
                bool b = false;
                while (b == false)
                {
                    Console.WriteLine("Ne pravulno!!!!!!\n");
                    Console.WriteLine("Vvedit zanovo name: ");
                    name = Console.ReadLine();
                    if (name != "" && name!=" ")
                    {
                        b = true;
                    }
                }
            }
            Console.WriteLine("Vvedit dengi personu: ");
            money = double.Parse(Console.ReadLine());
            if (money<=0)
            {
                bool b = false;
                while (b == false)
                {
                    Console.WriteLine("Ne pravulno!!!!!!\n");
                    Console.WriteLine("Vvedit zanovo money: ");
                    string temp = Console.ReadLine();
                    if (double.Parse(temp) > 0)
                    {
                        money= double.Parse(temp);
                        b = true;
                    }
                }
            }
        }

        public string GetName()
        {
            return name;
        }

        public void SetBag(Product b)
        {
            if (money - b.GetPrice() >= 0)
            {
                if(bag== "Ni4ego ne kypil")
                {
                    bag = name +" - ";
                }
                money-= b.GetPrice();
                bag += b.GetName() + " ";
            }
        }

        public double GetMoney()
        {
            return money;
        }

        public void GetBag()
        {
            if(bag== "Ni4ego ne kypil")
            {
                Console.WriteLine(name+" "+bag + "\n");
            }
            else
            {
                Console.WriteLine(bag + "\n");
            }
        }
    }
    class Product
    {
        private string name;
        private double price;


        public void SetProduct()
        {
            Console.WriteLine("Vvedit name prodycty: ");
            name = Console.ReadLine();
            if (name == " " || name == "")
            {
                bool b = false;
                while (b == false)
                {
                    Console.WriteLine("Ne pravulno!!!!!!\n");
                    Console.WriteLine("Vvedit zanovo peremennyy: ");
                    name = Console.ReadLine();
                    if (name != "" && name != " ")
                    {
                        b = true;
                    }
                }
            }
            Console.WriteLine("Vvedit price prodycta: ");
            price = double.Parse(Console.ReadLine());
            if (price <= 0)
            {
                bool b = false;
                while (b == false)
                {
                    Console.WriteLine("Ne pravulno!!!!!!\n");
                    Console.WriteLine("Vvedit zanovo peremennyy: ");
                    price = double.Parse(Console.ReadLine());
                    if (price > 0)
                    {
                        b = true;
                    }
                }
            }
        }

        public string GetName()
        {
            return name;
        }

        public double GetPrice()
        {
            return price;
        }
    }
    static void Main()
    {
        Console.WriteLine("Vvedit kilkist lydei: ");
        int k = int.Parse(Console.ReadLine());
        Person[] person = new Person[k];

        for (int i = 0; i != k; i++)
        {
            person[i] = new Person();
            person[i].SetPerson();
            Console.WriteLine("\n");

        }
        Console.WriteLine("\n\n");
        Console.WriteLine("Vvedit kilkist productiv: ");
        k = int.Parse(Console.ReadLine());
        Product[] product = new Product[k];

        for (int i = 0; i != k; i++)
        {
            product[i] = new Product();
            product[i].SetProduct();
            Console.WriteLine("\n");
        }

        while (true)
        {
            string temp = Console.ReadLine();
            if (temp == "end" || temp == "End")
            {
                break;
            }
            string temp1 = "";
            FindWord(ref temp, ref temp1);
            int pn = -1;
            int pp = -1;
            for (int i = 0; i != person.Length; i++)
            {
                if (temp1 == person[i].GetName())
                {
                    pn = i;
                    break;
                }
            }
            if (pn == -1)
            {
                Console.WriteLine("Ne pravulno vvedeno name personu");
            }
            else
            {
                FindWord(ref temp, ref temp1);
                for (int i = 0; i != product.Length; i++)
                {
                    if (temp1 == product[i].GetName())
                    {
                        pp = i;
                        break;
                    }

                }
                if(pp == -1)
                {
                    Console.WriteLine("Ne pravulno vvedeno name product");
                }
                else
                {
                    if (person[pn].GetMoney() - product[pp].GetPrice() >= 0)
                    {
                        Console.WriteLine(person[pn].GetName() + " bought " + product[pp].GetName() + "\n");
                        person[pn].SetBag(product[pp]);
                    }
                    else
                    {
                        Console.WriteLine(person[pn].GetName() +" can not afford "+ product[pp].GetName() +"\n");
                    }
                }
            }
        }
        Console.WriteLine("\n\n\n");
        for(int i = 0; i != person.Length; i++)
        {
            person[i].GetBag();
            Console.WriteLine("\n\n");
        }

    }
}
