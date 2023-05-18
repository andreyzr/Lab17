using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            print<int>(12);
            print<string>("hello!");
            Console.ReadKey ();
        }
        static void print<T>(T value)
        {
            Console.WriteLine(value);
        }
    }

}
