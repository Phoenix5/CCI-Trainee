using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] diag = GetMatrix();

            var DiagonalDifference = GetDiagonalDifference(diag);

            AbsDiaDiff(DiagonalDifference);
            Console.ReadKey();
        }

        private static void AbsDiaDiff(long DiagonalDifference)
        {
            Console.WriteLine("-----abs value-----");
            Console.WriteLine(DiagonalDifference);
        }

        private static int[,] GetMatrix()
        {
            Console.WriteLine("-----enter dimensions----------");
            int n = Convert.ToInt32(Console.ReadLine()); ;
            int[,] diag = new int[n, n];

            Console.WriteLine("-----enter {0}x{0} array", n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    diag[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("-----");
            }

            return diag;
        }

        private static long GetDiagonalDifference( int[,] diag)
        {
            long sum1 = 0, sum2 = 0;
            int n = diag.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                sum1 += diag[i, i];
                sum2 += diag[n - i - 1, i];
            }
            return Math.Abs(sum1 - sum2);
        }
    }
}
