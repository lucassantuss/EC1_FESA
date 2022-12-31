using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11_ParOuImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 11
             * 
             * Par ou Impar
             * 
             * Faça um programa que solicite um número.
             * 
             * Seu programa deverá informar se o número informado é par ou impar. 
             */

            float numero;

            Console.Write("Digite um número: ");
            numero = float.Parse(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("\nO número é par");
            else
                Console.WriteLine("\nO número é impar");

            Console.ReadKey();
        }
    }
}