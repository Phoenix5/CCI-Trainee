using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = stairsize();

            staircase(size);

            Console.ReadKey();
        }

        private static int stairsize()
        {
            Console.Write("Enter Size:");
            int size = Convert.ToInt32(Console.ReadLine());
            return size;
        }

        private static void staircase(int size)
        {
            char[] hash = new char[size];

            for (int i = 0; i < size; i++)
            {
                hash[size - 1 - i] = '#';

                Console.Write(hash);

                Console.WriteLine();
            }
        }
    }
}