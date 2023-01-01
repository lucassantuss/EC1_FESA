using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_MediaAritmetica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá! Este programa irá ler diversos valores e informar a média");
            Console.WriteLine("aritmética, a quantidade de valores positivos e negativos e o");
            Console.WriteLine("percentual de negativos e positivos.");

            double n, soma = 0;
            int quantidade, i = 0;

            double pos = 0, neg = 0;

            //Solicitando a quantidade de números que serão informados
            Console.WriteLine("\nQuantos números deseja informar?");
            quantidade = Convert.ToInt32(Console.ReadLine());

            //Laço de repetição a partir da quantidade de números 
            for (i = 1; i <= quantidade; i++)
            {
                //Solicitando os números
                Console.Write("\n" + i + "° número: ");
                n = Convert.ToDouble(Console.ReadLine());

                //Soma dos números solicitados
                soma = soma + n;

                //Condição para números positivos 
                if (n > 0)
                {
                    n = pos;
                    pos = pos + 1;
                }

                //Condição para números negativos
                else if (n < 0)
                {
                    n = neg;
                    neg = neg + 1;
                }
            }

            //Média dos números
            double media = soma / quantidade;

            //Percentuais de negativos e positivos
            double pp = pos / quantidade * 100;
            double pn = neg / quantidade * 100;

            //Imprimindo os resultados para o usuário
            Console.WriteLine($"\nA média dos números é: {media:0.00}.");
            Console.WriteLine($"\nTêm {pos} número(s) positivo(s) e {neg} número(s) negativo(s).");
            Console.WriteLine($"\nPortanto, {pp:0.00}% de números positivos e {pn:0.00}% de números negativos.");

            Console.ReadKey();
        }
    }
}