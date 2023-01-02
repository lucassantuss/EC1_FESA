using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16_ParesImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             16. Faça um programa que exiba os nºs pares 
             e os ímpares de 1 a 1000. 
             
             Dica : número par é todo aquele cujo resto da divisão inteira por 2 dá ZERO.
             
             % = operador de resto da divisão
             
             Ex: 
             4%2 == 2  resto ZERO (PAR)
             5%2 == 2  resto 1    (IMPAR)
             */

            // Utilizando For
            int contador;
            for (contador = 1; contador <= 1000; contador++)
            {
                if (contador % 2 == 0)
                    Console.WriteLine("{0} é par", contador);
                else
                    Console.WriteLine("{0} é impar", contador);

                if (contador % 100 == 0)
                {
                    Console.WriteLine("Pressione ENTER para continuar...");
                    Console.ReadLine();
                }
            }

            // Utilizando do While
            contador = 1;
            do
            {
                if (contador % 2 == 0)
                    Console.WriteLine("{0} é par", contador);
                else
                    Console.WriteLine("{0} é impar", contador);

                if (contador % 200 == 0)
                    Console.ReadLine();

                contador++;
            }
            while (contador <= 1000);
        }
    }
}