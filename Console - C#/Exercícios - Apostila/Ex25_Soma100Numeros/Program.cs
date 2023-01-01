using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex25_Soma100Numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 25
             * 
             * Faça um programa para somar todos os números de 1 a 100 e exibir o resultado em vídeo.
             */

            int cont, soma = 0;

            for (cont = 1; cont <= 100; cont++)
            {
                soma = soma + cont;
            }

            Console.WriteLine("Somatória: " + soma);
            Console.ReadKey();
        }
    }
}