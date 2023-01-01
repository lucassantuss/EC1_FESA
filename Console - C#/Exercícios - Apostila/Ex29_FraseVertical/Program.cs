using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex29_FraseVertical
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 29
             * 
             * Sabendo-se que o comando Writeline pula de linha após exibir um texto, faça um programa que imprima na
             * tela um texto informado pelo usuário, letra por letra, cada uma em uma linha. Ex: texto = "vertical"
             * 
             * Ex:
             * 
             * v
             * e
             * r
             * t
             * i
             * c
             * a
             * l
             */

            string frase;

            Console.Write("Digite uma frase: ");
            frase = Console.ReadLine();

            //percorrer a string do começo até o final
            for (int pos = 0; pos < frase.Length; pos++)
            {
                Console.WriteLine(frase[pos]);
            }

            Console.WriteLine("\nMostrando a frase ao contrário\n");

            for (int pos = frase.Length - 1; pos >= 0; pos--)
            {
                Console.Write(frase[pos]);
            }

            Console.ReadKey();
        }
    }
}