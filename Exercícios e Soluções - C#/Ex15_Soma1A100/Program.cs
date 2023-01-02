using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15_Soma1A100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercicio 15
             * 
             * Faça um programa para somar todos os números de 
             * 1 a 100 e exibir o  resultado em vídeo.
             */

            int soma = 0;
            int contador;

            // Utilizando For
            for (contador = 1; contador <= 100; contador++)
            {
                soma = soma + contador;
            }

            Console.WriteLine("Soma dos números de 1 a 100 é {0}", soma);

            // Utilizando do While
            soma = 0;
            contador = 1;
            do
            {
                soma = soma + contador;
                contador++;
            }
            while (contador <= 100);

            Console.WriteLine("soma = {0}", soma);

            Console.ReadKey();
        }
    }
}