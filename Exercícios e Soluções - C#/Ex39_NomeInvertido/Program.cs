using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex39_NomeInvertido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 39. Solicite 5 nomes e exiba-os de forma invertida.

            string[] nomes = new string[5];

            for (int n = 0; n < nomes.Length; n++)
            {
                Console.WriteLine("Digite o nome da posição: {0}", n);
                nomes[n] = Console.ReadLine();
            }

            for (int n = 0; n < nomes.Length; n++)  // iterando pelos elementos do vetor
            {
                for (int l = nomes[n].Length - 1; l >= 0; l--) // iterando pelo nome
                    Console.Write(nomes[n][l]);

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}