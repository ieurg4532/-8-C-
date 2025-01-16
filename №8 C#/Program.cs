using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_C_
{
    class Cloak
    {
        private string Brand;
        private string Gender;
        private string Color;
        private decimal Price;

        public void Input()
        {
            Console.Write("Brand: ");
            Brand = Console.ReadLine();

            Console.Write("Gender (male/female): ");
            Gender = Console.ReadLine();

            Console.Write("Color: ");
            Color = Console.ReadLine();

            Console.Write("Price: ");
            Price = Convert.ToDecimal(Console.ReadLine());
        }

        public void Info()
        {
            Console.WriteLine($"Brand: {Brand}, Gender: {Gender}, Color: {Color}, Price: {Price:F2}");
        }

        public void analysis(string gender, string color, decimal price)
        {
            if (gender == Gender && color == Color && price >= Price)
            {
                Info();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of coats: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Cloak[] cloaks = new Cloak[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nEnter data for cloak {i + 1}: ");
                cloaks[i] = new Cloak();
                cloaks[i].Input();
            }

            Console.Write("\nEnter gender (male/female): ");
            string Gender = Console.ReadLine();

            Console.Write("Enter the desired color: ");
            string Color = Console.ReadLine();

            Console.Write("Enter the maximum price: ");
            decimal Price = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\nRaincoats that meet your criteria:");

            for (int i = 0; i < n; i++)
            {
                cloaks[i].analysis(Gender, Color, Price);
            }
        }
    }
}

