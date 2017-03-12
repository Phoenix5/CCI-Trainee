using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace last_man_standing
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = GetList();

            GetLastMan(list);

            DisplayLastMan(list);

            Console.ReadKey();

        }

        private static void DisplayLastMan(int[] list)
        {
            Console.WriteLine("----------------------------");
            // for (int i = 0; i < l; i++)
            //    Console.Write(list[i]);
            Console.Write(list[0]);
            Console.WriteLine();
        }

        private static void GetLastMan(int[] list)
        {
            int l = list.Length - 1;
            for (int x; l > 1; l--)
            {
                x = list[0];
                // if((l-1)>=0)
                Array.Copy(list, 2, list, 0, l - 1);
                list[l - 1] = x;

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
