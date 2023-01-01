using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_QtdParesPorLinha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercicio 1
             * 
             * Crie um programa que solicite do usuário o preenchimento de uma matriz
             * 4x3. Ao final exiba quantos números pares existem em cada uma das linhas.
             */

            //usar classe de numeros randomicos
            Random gerador = new Random();

            int[,] matriz = new int[4, 3];
            int linha, coluna, qtdPares;

            //entrada de dados
            for(linha=0; linha < 4; linha++)
            {
                for(coluna=0; coluna < 3; coluna++)
                {
                    Console.Write($"\nDigite o valor para matriz {linha},{coluna}: ");
                    //entrada manual
                    //matriz[linha, coluna] = Convert.ToInt32(Console.ReadLine());
                    //gera numeros entre 10 e 389
                    matriz[linha, coluna] = gerador.Next(10, 390);
                    Console.Write(matriz[linha, coluna]);
                }
            }

            Console.WriteLine("\n");

            //processamento
            for (linha = 0; linha < 4; linha++)
            {
                qtdPares = 0;
                for (coluna = 0; coluna < 3; coluna++)
                {
                    if(matriz[linha, coluna] % 2 == 0)
                    {
                        qtdPares++;
                    }
                }

                //exibir na tela
                Console.WriteLine($"Quantidade de pares para a " +
                                  $"linha {linha}: {qtdPares}");
            }

            Console.ReadKey();
        }
    }
}