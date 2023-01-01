using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex24_Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 24
             * 
             * Tabuada
             * 
             * Solicite um número qualquer e calcule a tabuada deste número de forma que o resultado fique assim:
             * 
             * ex: para o nº 7
             * 
             * 7 x 1 = 7
             * 7 x 2 = 14
             * 7 x 3 = 21
             * 7 x 4 = 28
             * ...
             * 7 x 10 = 70
             */

            Int32 numero, resultado;

            Console.Write("Informe o número da tabuada: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n-------------------------------\n");

            for (Int32 cont = 10; cont > 0; cont--) //vai de tras para frente
            //for(Int32 cont = 1; cont < 11; cont++)
            {
                resultado = cont * numero;
                Console.WriteLine("{0} X {1} = {2}", numero, cont, resultado);
            }

            Console.ReadKey();
        }
    }
}