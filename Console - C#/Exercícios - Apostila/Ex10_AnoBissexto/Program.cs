using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_AnoBissexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 10
             *
             * Ano bissexto
             * 
             * Solicite ao usuário que digite um ano.
             * 
             * Seu programa deverá informar se o ano digitado é bissexto ou não.
             * 
             * Lembre-se que ano bissexto (de forma simplificada) é aquele que é divisível por 4 com resto igual a zero. 
             */

            int ano;

            Console.Write("Digite um ano: ");
            ano = int.Parse(Console.ReadLine());

            if (ano % 4 == 0)
                Console.WriteLine("\nO ano é bissexto");
            else
                Console.WriteLine("\nO ano não é bissexto");

            Console.ReadKey();
        }
    }
}