using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Сlient<int> сlient1 = new Сlient<int>();
            сlient1.Input();
            Console.WriteLine(сlient1.GetInfo());

            Сlient<string> сlient2 = new Сlient<string>();
            сlient2.Input();
            Console.WriteLine(сlient2.GetInfo());

            Console.ReadKey();
        }
    }
}
