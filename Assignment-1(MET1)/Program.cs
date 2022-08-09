using System;
using System.Collections;
using System.Linq;

namespace Assignment_1_MET1_
{
    public class Program
    {
        private static void ElectricityBill()
        {
            int units;
            Console.WriteLine("Enter the number of units:");
            units = Convert.ToInt32(Console.ReadLine());
            double price = calculate(units);
            print(price);
        }
        static double calculate(int units)
        {
            double result = 0.0f;
            if (units <= 100)
            {
                result = units * 1.20f;
            }
            else if (units <= 300)
            {
                result = (100 * 1.20f) + ((units - 100) * 2.0f);
            }
            else
            {
                result = (100 * 1.20f) + (200 * 2.0f) + ((units - 300) * 3.0f);
            }
            return result;
        }
        static void print(object value)
        {
            Console.WriteLine(value);
        }

        private static void Batsman()
        {
            int runs = 0;
            int sum = 0;
            Random rand = new Random();
            for(int i =0; i<=30; i++)
            {
                runs = Convert.ToInt32(rand.Next(1, 6));
                Console.WriteLine(runs);
                sum = sum + runs;
            }
            Console.WriteLine(sum);
           
        }
        static void Main(string[] args)
        {
            ElectricityBill();

            Batsman();
        }

       

       
    }
}