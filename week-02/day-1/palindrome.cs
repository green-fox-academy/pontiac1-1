using System;

namespace ConsoleApp44
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tosort = new int[] { 2, 1, 5, 4, 7, 6, 8, 3 };
            for (int i = 0; i < tosort.Length; i++)
            {
                int temp;
                if (tosort[i] > tosort[i+1])
                {
                    temp = tosort[i];
                    tosort[i] = tosort[i+1];
                    tosort[i + 1] = temp;
                }
                else
                {

                }
            }
        }
    }
}
