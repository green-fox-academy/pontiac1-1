using System;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to decide if it's an Armstrong number!");
            string number = Console.ReadLine();
            double numberasdouble = double.Parse(number);
            double lenght = number.Length;
            double sum = 0;

            foreach (var digit in number)
            {
                int aka = int.Parse(digit.ToString());
                double power = Math.Pow(aka, lenght);
                sum += power;
            }

            if (sum == numberasdouble)
            {
                Console.WriteLine("The number " + number + " is an Armstrong number!");
            }
            else
            {
                Console.WriteLine("The number you have entered is not an Armostrong number!");
                
            }

            Console.ReadLine();
        }
    }
}