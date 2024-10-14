using System;

namespace CLASS2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name :");
            string Name = Convert.ToString(Console.ReadLine());
            Console.Write("Description :");
            string Description = Convert.ToString(Console.ReadLine());
            Console.Write("Count  :");
            int Count = Convert.ToInt32(Console.ReadLine());
            Console.Write("Price :");
            double Price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ram :");
            byte Ram = Convert.ToByte(Console.ReadLine());
            Console.Write("Storage :");
            double Storage = Convert.ToDouble(Console.ReadLine());



            Notebook notebook = new Notebook(Name, Description, Count, Price, Ram, Storage);
            notebook.Sale();
            Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
            notebook.ShowFullData();
            Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
            notebook.ShowFullInfo();

        }
        class Product
        {
            public string Name;
            public string Description;
            public int Count;
            public bool IsStock;
            public double Price;

            public Product(string name, string description, int count, double price)
            {
                bool isStock = false;
                Name = name;
                Description = description;
                Count = count;
                IsStock = isStock;
                Price = price;


            }
            public Product(string name, int count, double price)
            {
                Name = name;
                Count = count;
                Price = price;

            }
            public void Sale()
            {
                Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
                if (Count > 0)
                {
                    IsStock = true;
                }
                if (IsStock)
                {
                    Console.WriteLine("Mehsul Movcuddur");
                }
                else Console.WriteLine("Mehsul movcud deyil");

            }
        }
        class Notebook : Product
        {
            public byte RAM;
            public double Storage;
            public Notebook(string name, int count, double price, byte ram) : base(name, count, price)
            {
                RAM = ram;

            }
            public Notebook(string name, string description, int count, double price, byte ram, double storage) : base(name, description, count, price)
            {
                RAM = ram;
                Storage = storage;
            }
            public void ShowFullInfo()
            {
                Console.WriteLine($"Name :({Name}) \n Description :({Description}) \n Count :({Count}) \n Price:({Price}$) \n Ram :({RAM}) \n Storage :({Storage}GB) ");
            }
            public void ShowFullData()
            {
                Console.WriteLine($" Ram :({RAM})  Storage :({Storage}GB) ");
            }
        }
    }
}
