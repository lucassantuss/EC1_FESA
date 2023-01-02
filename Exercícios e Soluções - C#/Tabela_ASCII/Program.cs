using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabela_ASCII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int n = 0; n <= 255; n++)
            {
                Console.WriteLine("{0}  {1}", n, Convert.ToChar(n));
            }

            Console.ReadKey();
        }
    }
}