using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day 3
{
    //Readonly and cost keyword
    class Class8
  {
    public static void Main()
    {
        string a = "It is a bad color";
        Console.WriteLine("string: " + a);
        string b = "is a";
        Console.WriteLine("string: " + b);
        {
            if (a.Contains(b))
            {
                Console.WriteLine("substring 'is a' is present");
            }
            else
            {
                Console.WriteLine("substring 'is a' is absent");
            }
            Console.ReadLine();
        }
    }
  }
}
