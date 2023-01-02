using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex32_UltimaOcorrencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o texto: ");
            string texto = Console.ReadLine();

            Console.WriteLine("\nDigite uma letra: ");
            char letra = Console.ReadLine()[0];

            int posicao = -1;

            for (int n = texto.Length - 1; n >= 0; n--)
                if (texto[n] == letra)
                {
                    posicao = n;
                    break;
                }

            if (posicao == -1)
                Console.WriteLine("\nEste caractere não existe no texto!");
            else
                Console.WriteLine("\nEste caractere está na posição {0}", posicao);

            Console.ReadKey();
        }
    }
}