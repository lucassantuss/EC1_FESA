using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_QtdParesImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá! Este programa lerá uma quantidade de números positivos (diferentes de zero) e");
            Console.WriteLine("informará para você a quantidade de números pares e ímpares, a média de valores");
            Console.WriteLine("(pares/ímpares) e a média geral dos números lidos.");

            double n = 1, quantidade = 0, media = 0, mp = 0, mi = 0, soma = 0, sp = 0, si = 0, par = 0, impar = 0;

            //Solicitando a quantidade de números que serão informados
            Console.WriteLine("\nQuantos números positivos deseja informar?");
            quantidade = Convert.ToDouble(Console.ReadLine());

            // Condição para a quantidade ser um número positivo, diferente de zero
            if (quantidade > 0)
            {
                //Laço de repetição a partir da quantidade de números 
                for (int i = 1; i <= quantidade; i++)
                {
                    //Solicitando os números 
                    Console.Write("\n" + i + "° número: ");
                    n = Convert.ToDouble(Console.ReadLine());

                    //Condição para não ter número negativo, ou igual a zero
                    if (n <= 0)
                    {
                        Console.WriteLine("\nOps! Só pode informar números POSITIVOS e DIFERENTES de zero!");
                        Console.WriteLine("Vamos novamente, reinicie o programa!");
                        break;
                    }

                    //Soma dos números 
                    soma = soma + n;

                    //Condição para números pares 
                    if (n % 2 == 0)
                    {
                        //Soma dos números pares
                        sp = sp + n;

                        //Quantidade de números pares
                        par++;
                    }

                    //Condição para números ímpares
                    else
                    {
                        //Soma dos números ímpares
                        si = si + n;

                        //Quantidade de números ímpares
                        impar++;
                    }

                    //Média dos números pares
                    mp = sp / par;

                    //Média dos números ímpares
                    mi = si / impar;

                    //Média geral dos números
                    media = soma / quantidade;
                }

                if (n > 0)
                {
                    //Imprimindo os resultados para o usuário
                    Console.WriteLine($"\nTêm {par} número(s) par(es) e {impar} número(s) ímpar(es).");
                    Console.WriteLine($"A média destes números é {media:0.00}.");
                    Console.WriteLine($"A média dos números pares é {mp:0.00}.");
                    Console.WriteLine($"A média dos números ímpares é {mi:0.00}.");
                }
            }

            // Caso a quantidade de números for um número negativo ou igual a zero
            else
            {
                Console.WriteLine("\nOps! Só pode informar números POSITIVOS e DIFERENTES de zero!");
                Console.WriteLine("Vamos novamente, reinicie o programa!");
            }

            Console.ReadKey();
        }
    }
}