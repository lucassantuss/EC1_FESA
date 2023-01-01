using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex31_ContaLetras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 31
             * 
             * Conta Letras
             * 
             * Faça um programa que solicite uma frase e uma letra. Então, seu programa deverá exibir a quantidade de vezes que
             * a letra aparece na frase.
             * 
             * Ex:
             * 
             * Digite uma frase: “Olá mundo cruel”
             * Digite uma letra: “l”
             * 
             * A letra [l] aparece 2 vezes na frase
             */

            string frase;
            char letra;
            int cont = 0;

            Console.Write("Digite uma frase: ");
            frase = Console.ReadLine().ToUpper();

            Console.Write("Digite uma letra: ");
            letra = Console.ReadLine().ToUpper()[0];

            //percorrer a string do começo até o final
            for (int pos = 0; pos < frase.Length; pos++)
            {
                if (frase.ToUpper()[pos] == letra)
                {
                    cont++;
                }
            }

            Console.WriteLine($"\nFoi repetido {cont} vezes a letra {letra}");
            Console.ReadKey();
        }
    }
}