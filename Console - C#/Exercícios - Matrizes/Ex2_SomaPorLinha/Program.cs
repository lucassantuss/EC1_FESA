using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_SomaPorLinha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercicio 2
             * 
             * Crie um programa que solicite do usuário o preenchimento de uma matriz
             * 4x3. Após o preenchimento, crie um vetor de 4 elementos e armazene em cada
             * linha desse vetor a somatória de cada linha existente na matriz. Ao final exiba
             * os valores da matriz e do vetor.
             */

            //usar classe de numeros randomicos
            Random gerador = new Random();

            int[,] matriz = new int[4, 3];
            int[] vetor = { 0, 0, 0, 0 }; //cria seu vetor já iniciando os valores
            int linha, coluna;

            //entrada de dados
            for (linha = 0; linha < 4; linha++)
            {
                for (coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write($"\nDigite o valor para matriz {linha},{coluna}:");
                    //entrada manual
                    //matriz[linha, coluna] = Convert.ToInt32(Console.ReadLine());
                    //gera numeros entre 10 e 389
                    matriz[linha, coluna] = gerador.Next(10, 390);
                    Console.Write(matriz[linha, coluna]);
                }
            }

            //processamento
            for (linha = 0; linha < 4; linha++)
            {
                for (coluna = 0; coluna < 3; coluna++)
                {
                    //somando os elementos dessa linha
                    vetor[linha] += matriz[linha, coluna];
                    //ou
                    //vetor[linha] = vetor[linha] + matriz[linha, coluna];
                }
            }

            Console.WriteLine("Exibindo a Matriz...");
            //exibindo a matriz
            for (linha = 0; linha < 4; linha++)
            {
                for (coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write($"{matriz[linha, coluna]} \t");
                }

                //pula linha
                Console.Write("\n");
            }

            Console.WriteLine("Exibindo o Vetor...");
            foreach (int valor in vetor)
            {
                Console.Write($"{valor} - ");
            }

            Console.ReadKey();
        }
    }
}