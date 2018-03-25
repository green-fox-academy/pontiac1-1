using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REDO_Symmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            var symmetricMatrix = new List<List<int>>
            {
                new List<int> { 1, 0, 1, 1 },
                new List<int> { 0, 2, 2, 2 },
                new List<int> { 1, 2, 5, 5 },
                new List<int> { 1, 2, 5, 7 }
            };

            Console.WriteLine(TestSymm(symmetricMatrix));
            Console.Read();
        }

        static bool TestSymm(List<List<int>> matrix)
        {
            int match = 0;
            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix.Count; j++)
                {
                    if (matrix[i][j] == matrix[j][i])
                    {
                        if (i != j)                        
                            match++;                      
                    }
                }
            }
            match /= 2;
            if (match == ((matrix.Count * matrix.Count) - matrix.Count) / 2)
                return true;
            else
                return false;
        }
    }
}
