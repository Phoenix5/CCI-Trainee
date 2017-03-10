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
            //int[] a = { -7, 1, 5, 2, -4, 3, 0 };
           // int[] a = { 1, 2, 3, 4, 3, 2, 1 };
            int[] a = { 99, 0, 66, 32, 1 };

            int aftersum = a.Sum();
            int beforesum = 0;
            int p = 0;

            if ((aftersum - a[p]) == 0) Console.WriteLine(a[p]);
            else if ((aftersum - a[(a.Length) - 1]) == 0) Console.WriteLine(a[(a.Length) - 1]);
            else {
                aftersum -= a[p];
                do{
                   beforesum += a[p];
                    p++;
                    aftersum -= a[p];
                } while(aftersum!=beforesum);
            }

            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
