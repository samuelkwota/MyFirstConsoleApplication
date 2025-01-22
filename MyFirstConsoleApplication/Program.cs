using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
             // store name and location
 string myName = "Samuel Kwota"; 
 string myLocation = "Ghana, Accra"; 

 // location
 Console.WriteLine($"My name is {myName}.");
 Console.WriteLine($"I am from {myLocation}.");

 // date
 Console.WriteLine($"Today's date is {DateTime.Now.ToString("MM/dd/yyyy")}.");

 // days until Christmas
 DateTime today = DateTime.Today;
 DateTime christmas = new DateTime(today.Year, 12, 25);

 if (today > christmas)
 {
     // If today is after Christmas, calculate days until next year's Christmas
     christmas = christmas.AddYears(1);
 }

 int daysUntilChristmas = (christmas - today).Days;
 Console.WriteLine($"There are {daysUntilChristmas} days until Christmas this year.");

 // Add example from Section 2.1 of the C# Programming Yellow Book
 Console.WriteLine("The square root of 16 is: " + Math.Sqrt(16));

 // Pause the program so it does not terminate immediately
 Console.WriteLine("\nPress any key to exit...");
 Console.ReadKey();
            
            
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

        }
    }
}
