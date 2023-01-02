using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_AnoBissexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercicio 6
             * 
             * Ano bissexto
             * 
             * Solicite ao usuário que digite um ano. 
             * Seu programa deverá informar se o ano digitado é bissexto ou não. 
             * Lembre-se que ano bissexto (de forma simplificada) 
             * é aquele que é divisível por 4 com resto igual a zero
             */

            Console.WriteLine("Digite um ano com 4 dígitos: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            if (ano % 4 == 0) // % calcula o resto da divisão inteira
                Console.WriteLine("Este ano é bissexto.");
            else
                Console.WriteLine("Este ano NÃO é bissexto.");

            Console.ReadKey();
        }
    }
}