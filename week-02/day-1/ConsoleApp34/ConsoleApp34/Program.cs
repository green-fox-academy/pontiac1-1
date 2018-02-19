using System;

namespace ConsoleApp34
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("pls enter the numbor of integers you would like to sum!");
            int cardinality = int.Parse(Console.ReadLine());
            int[] numstosum = new int[cardinality];
            Console.WriteLine("pls enter the numbers");
            for (int i = 0; i < cardinality; i++)
            {
                
                numstosum[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("the sum of the "+cardinality+" numbers you have entered is: "+Add(numstosum));
            Console.ReadLine();
        }
        static int Add(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                
                sum += array[i];
                
            }
            return sum;
        }
    }
}
