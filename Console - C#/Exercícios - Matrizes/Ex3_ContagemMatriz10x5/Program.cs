using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_ContagemMatriz10x5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 3
             * 
             * Crie uma matriz 10x5 de inteiros, permitindo que seja digitado somente
             * valores entre 0 e 99. Após a digitação cria um vetor de 4 elementos e
             * armazene nesse vetor a quantidade de números digitados na matriz
             * obedecendo os seguintes critérios:
             * 
             * Posição 0 – valores entre 0 e 24
             * Posição 1 – valores entre 25 e 49
             * Posição 2 – valores entre 50 e 74
             * Posição 3 – valores entre 75 e 99
             */

            //usar classe de numeros randomicos
            Random gerador = new Random();

            int[,] matriz = new int[10, 5];
            int[] vetor = { 0, 0, 0, 0 };//cria seu vetor já iniciando os valores
            int linha, coluna;

            //entrada de dados
            for (linha = 0; linha < 10; linha++)
            {
                for (coluna = 0; coluna < 5; coluna++)
                {
                    Console.Write($"\nDigite o valor para matriz {linha},{coluna}:");
                    //entrada manual
                    //matriz[linha, coluna] = Convert.ToInt32(Console.ReadLine());
                    //gera numeros entre 0 e 99
                    matriz[linha, coluna] = gerador.Next(0, 100);
                    Console.Write(matriz[linha, coluna]);
                }
            }

            //processamento
            for (linha = 0; linha < 10; linha++)
            {
                for (coluna = 0; coluna < 5; coluna++)
                {
                    int indice = matriz[linha, coluna] / 25;
                    vetor[indice]++;
                }
            }

            Console.WriteLine("\n\nExibindo a Matriz...");
            //exibindo a matriz
            for (linha = 0; linha < 10; linha++)
            {
                for (coluna = 0; coluna < 5; coluna++)
                {
                    Console.Write($"{matriz[linha, coluna]} \t");
                }

                //pula linha
                Console.Write("\n");
            }

            Console.WriteLine("\nExibindo o Vetor...");
            foreach (int valor in vetor)
            {
                Console.Write($"{valor} - ");
            }

            Console.ReadKey();
        }
    }
}