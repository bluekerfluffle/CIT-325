using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Gracie Burris";
            string location = "Oklahoma";

            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"My location is {location}");

            DateTime thisDate = new DateTime(2014, 4, 30);
            Console.WriteLine(thisDate.ToString("d"));

            DateTime today = DateTime.Now;
            DateTime christmas = new DateTime(today.Year, 12, 25);

            if (today.Month > 12 || (today.Month == 12 && today.Day > 25))
            {
                christmas = christmas.AddYears(1); 
            }

            TimeSpan remaining = christmas - today;
            int daysUntilChristmas = remaining.Days;

            Console.WriteLine($"Days until Christmas: {daysUntilChristmas}");

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
