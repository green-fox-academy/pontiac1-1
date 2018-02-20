using System;

namespace ConsoleApp47
{
    class ConsoleApp47
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a '0' if you want numerical and '1' if ou want descending order!");
            int dori = int.Parse(Console.ReadLine());
            int[] tosort = new int[] { 6, 4, 9, 7, 8, 2, 1 };
            int temp;

            if (dori == 0)
            {
                for (int i = 0; i < tosort.Length; i++)
                {
                    for (int j = 0; j < tosort.Length - 1; j++)
                    {
                        if (tosort[j] > tosort[j + 1])
                        {
                            temp = tosort[j];
                            tosort[j] = tosort[j + 1];
                            tosort[j + 1] = temp;
                        }
                    }
                }
            }

            if (dori == 1)
            {
                for (int x = 0; x < tosort.Length; x++)
                {
                    for (int y = 0; y < tosort.Length - 1; y++)
                    {
                        if (tosort[y] < tosort[y + 1])
                        {
                            temp = tosort[y];
                            tosort[y] = tosort[y + 1];
                            tosort[y + 1] = temp;
                        }
                    }
                }
            }

            foreach (var item in tosort)
            {
                Console.Write(item+" ");
            }
            Console.ReadLine();
        }

    }
}
