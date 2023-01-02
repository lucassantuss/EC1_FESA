using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14_Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            14.	Tabuada.

            Solicite um número qualquer e calcule a tabuada deste número de forma que o resultado fique assim:

            ex:  para o nº 7

            7 x 1 = 7
            7 x 2 = 14
            7 x 3 = 21
            7 x 4 = 28
            ...
            7 x 10 = 70
            */

            Console.WriteLine("Digite um número");
            int numero = Convert.ToInt32(Console.ReadLine());

            int contador;

            // Utilizando For
            for (contador = 1; contador <= 10; contador++)
                Console.WriteLine("{0} x {1} = {2}", numero, contador,
                    numero * contador);

            Console.WriteLine();

            // Utilizando do While
            int n = 0;
            do
            {
                Console.WriteLine("{0}x{1}={2}", numero, n, numero * n);
                n++;
            }
            while (n <= 10);

            Console.ReadKey();
        }
    }
}