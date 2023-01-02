using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17_FraseVertical
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercicio 17
             * 
             * Sabendo-se que o comando Writeline pula de linha
             * após exibir um texto, faça um programa que 
             * imprima na tela um texto informado pelo usuário na vertical,
             * letra por letra, cada uma em uma linha. 
             */

            Console.WriteLine("Digite um texto ");
            string texto = Console.ReadLine();

            // Utilizando For
            for (int posicao = 0; posicao < texto.Length; posicao++)
                Console.WriteLine(texto[posicao]);

            Console.ReadLine();

            // Utilizando do While
            int n = 0;
            do
            {
                Console.WriteLine(texto[n]);
                n++;
            }
            while (n < texto.Length);

            Console.ReadLine();
        }
    }
}