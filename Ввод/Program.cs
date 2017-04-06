using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ввод
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            Console.WriteLine("Введие число:");

            i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Вы ввели:" + i);

            Console.ReadKey();
        }
    }
}
