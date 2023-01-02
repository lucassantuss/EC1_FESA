using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex22_TabuadaInvertida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            22.	 Faça o programa da tabuada ao contrário:
            Ex:

            7 * 10 = 70
            7 * 9 = 63
            ...
            7 * 0 = 0
            */

            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Utilizando For
            for (int n = 10; n >= 0; n--)
                Console.WriteLine("{0} x {1} = {2}", numero, n, numero * n);

            Console.ReadLine();

            // Utilizando While
            int contador = 10;
            
            while (contador >= 1)
            {
                Console.WriteLine("{0}x{1}={2}", numero, contador, numero * contador);

                contador--;
            }

            Console.ReadLine();
        }
    }
}