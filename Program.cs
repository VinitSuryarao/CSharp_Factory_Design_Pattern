using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    class Program
    {
        // Client Class or User Class
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Choice");
            string choice = Console.ReadLine();

            // Client class has to call through only interface
            IIndustry obj1 = FactoryClass.GetObject(choice);

            Console.WriteLine(obj1.GetProductName());
            Console.ReadLine();
        }
    }

    interface IIndustry // Interface for Client Class Can Communicate Through it
    {
        string GetProductName();
    }

    class FactoryClass // Factory Class for Object Creation
    {
        public static IIndustry GetObject(string UserInput)
        {
            IIndustry obj = null;
            if(UserInput =="Car")
            {
                obj = new CarCompany();
            }

            if (UserInput == "Bike")
            {
                obj = new BikeCompany();
            }

            return obj;
        }
    }
  
    public class CarCompany : IIndustry // Car Class
    {
        public string GetProductName()
        {
            return "Mahindra Thar";
        }
    }

    public class BikeCompany : IIndustry // Bike Class
    {
        public string GetProductName()
        {
            return "TVS Apache RTR 160";
        }
    }
}
