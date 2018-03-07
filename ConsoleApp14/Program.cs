using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir eded daxil edin:");
            var eded = Convert.ToInt32(Console.ReadLine());
            cutEded(eded);

            void cutEded(int _eded)
            {
                if (_eded%2 == 0)
                {
                    Console.WriteLine("cut ededir");
                }
            }
        }
    }
}
