using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_C_
{
    class Cloak
    {
        public string Brand;
        public string Gender;
        public string Color;
        public decimal Price;

        public Cloak(string brand, string gender, string color, decimal price)
        {
            Brand = brand;
            Gender = gender;
            Color = color;
            Price = price;
        }

        public void Info()
        {
            Console.WriteLine($"Brand: {Brand}, Gender: {Gender}, Color: {Color}, Price: {Price:F2}");
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
                Console.Write("Brand: ");
                string brand = Console.ReadLine();

                Console.Write("Gender (male/female): ");
                string gender = Console.ReadLine();

                Console.Write("Color: ");
                string color = Console.ReadLine();

                Console.Write("Price: ");
                decimal price = Convert.ToDecimal(Console.ReadLine());

                cloaks[i] = new Cloak(brand, gender, color, price);
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
                if(Gender == cloaks[i].Gender && Color == cloaks[i].Color && Price >= cloaks[i].Price)
                {
                    cloaks[i].Info();
                }
            }
        }
    }
}
