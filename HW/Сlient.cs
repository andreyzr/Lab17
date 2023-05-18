using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    class Сlient<T>
    {
        public T Num { get; set; }
        public string Name { get; set; }
        public int Summa { get; set; }


        public string GetInfo()
        {
            return $"{Num} {Name} {Summa}";
        }

        public void Input()
        {
            Console.WriteLine("Введите номер счета");
         
            Num = (T)Convert.ChangeType(Console.ReadLine(),typeof(T));

            Console.WriteLine("Введите имя клиенат");
            Name = Console.ReadLine();
            Console.WriteLine("Введите объем счета");
            Summa = Convert.ToInt32(Console.ReadLine());
        }
    }
}
