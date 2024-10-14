using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace Classes2
{



//    Task 1:
//     3 class-nız olur.Vehicle, Car, Motorcycle.Car və Motorcycle Vehicle-dan miras alır.

//Vehicle class:
//==============
//string Brand 
//string Model 
//double Mile 

//Car class: Vehicle
//int DoorsNum 
//ShowFullInfo()

//MotorCycle class: Vehicle
//int WheelNum 
//ShowFullInfo()


//Brand ve Model teyin edilmeden, Car ve Bicycle obyekti yaratmaq olmasin.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Brand : ");
            string brand1 = Convert.ToString(Console.ReadLine());

            Console.Write("Model : ");
            string model1 = Convert.ToString(Console.ReadLine());

            Console.Write("Mile :");
            int Mile1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Door Number : ");
            int Doornumber = Convert.ToInt32(Console.ReadLine());

            Car car = new Car(brand1,model1,Mile1,Doornumber);

            Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
            car.ShowFullInfo();
            Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");

            Console.Write("Brand : ");
            string brand2 = Convert.ToString(Console.ReadLine());

            Console.Write("Model : ");
            string model2 = Convert.ToString(Console.ReadLine());

            Console.Write("Mile :");
            int Mile2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Wheel Number : ");
            int Wheelnumber = Convert.ToInt32(Console.ReadLine());

            Motorcycyle motorcycle = new Motorcycyle(brand2, model2, Mile2, Wheelnumber);

            Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
            motorcycle.ShowFullInfo();
            Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");


        }
        class Vehicle
        {
            public string Brand;
            public string Model;
            public double Mile;
            public Vehicle(string brand, string model)
            {
                 Brand = brand;
                Model = model;  

            }
            public Vehicle(string brand, string model,double mile ): this (brand,model) 
            {
               Mile = mile;

            }

        }

        class Car:Vehicle
        {
            public int DoorsNum;
            public Car(string brand, string model):base (brand,model) 
            {
                 
            }
            public Car(string brand, string model,double mile,int doornum) : base(brand, model,mile)
            {
                DoorsNum = doornum;
            }
            public void ShowFullInfo()
            {
                Console.WriteLine($"Brand : {Brand} || Model: {Model}\n Doorsnum :{DoorsNum} || Mile: {Mile}");
            
            }
        }

        class Motorcycyle:Vehicle
        {
            public Motorcycyle(string brand, string model) : base(brand, model)
            {

            }
            public int WheelNum;
            public Motorcycyle(string brand, string model,double mile, int wheelnum) : base(brand, model,mile)
            {
                WheelNum = wheelnum;
            }
            public void ShowFullInfo()
            {
                Console.WriteLine($"Brand : {Brand} || Model: {Model}\n WheelNum :{WheelNum} || Mile: {Mile}");

            }
        }
    }
}
