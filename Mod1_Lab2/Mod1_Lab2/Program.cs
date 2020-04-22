using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var Car1 = new Car();


            // Using dot notation to call members on Car1
            Car1.Color = "White";
            Car1.Year = 2020;
            Car1.Mileage = 11000;

            var Car2 = new Car("red", 2008);

            // Access static member
            int Carcount = Car.Countcars();
            Console.WriteLine($"There are {Carcount} cars in the inventory right now");

        }
    }
    // Declaring the Car() Class
    // This class has 3 properties: Color, Year, and Mileage
    
}