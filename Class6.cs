using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
   class Class6
    //Readonly and cost keyword
    {
        public readonly double pi = 3.14;
        public Class6(double pi)
        {
            this.pi = pi;
        }
        public static void Main()
        {
            const double PI = 3.14;
            //readonly int pi = 3.14;
            Class6 class6 = new Class6(PI);
            Console.WriteLine(PI);
            Console.ReadLine();
        }
    }
}
