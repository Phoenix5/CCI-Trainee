using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equilibrium
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] List = { -7, 1, 5, 2, -4, 3, 0 };
            //int[] List = { 1, 2, 3, 4, 3, 2, 1 };
            // int[] List = { 99, 0, 66, 32, 1 };
            int[] List = GetList();
            int AfterSum = List.Sum();
            int BeforeSum = 0;
            int p = 0;

            FindEquilibrium(List, ref AfterSum, ref BeforeSum, ref p);

            DisplayEquilibrium(p);
            Console.ReadKey();
        }

        private static void DisplayEquilibrium(int p)
        {
            Console.Write("The Equilibrium Is Found At Index:");
            Console.WriteLine(p);
        }

        private static void FindEquilibrium(int[] List, ref int AfterSum, ref int BeforeSum, ref int p)
        {
            if ((AfterSum - List[p]) == 0) Console.WriteLine(List[p]);
            else if ((AfterSum - List[(List.Length) - 1]) == 0) Console.WriteLine(List[(List.Length) - 1]);
            else
            {
                AfterSum -= List[p];
                do
                {
                    BeforeSum += List[p];
                    p++;
                    AfterSum -= List[p];
                } while (AfterSum != BeforeSum);
            }
        }

        private static int[] GetList()
        {
            Console.Write("Enter The Size:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The List:");
            int[] list = new int[n];
            for (int i = 0; i < n; i++)
                list[i] = Convert.ToInt32(Console.ReadLine());
            return list;
        }

    }
}
