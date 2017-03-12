using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowels
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = { 'a','e','i','o','u','A','E','I','O','U'};
            string input = Console.ReadLine();
            int lenght=input.Length;
            foreach(char c in vowels)
                   input= input.Replace(Convert.ToString(c),"");
            Console.WriteLine(lenght-input.Length);
            Console.ReadKey();
        }
    }
}
