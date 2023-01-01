using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_PesquisaEMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 4
             * 
             * Crie um projeto que solicite do usuário o
             * preenchimento de uma matriz 4x3 de inteiros. Depois de toda a entrada de
             * dados, solicite do usuário um número para se fazer uma pesquisa dentro da
             * matriz digitada. Depois de fornecido esse número faça uma varredura na matriz
             * e ao final informe quantas vezes o número informado aparece dentro da matriz.
             * 
             * Sugestão para o uso de métodos, crie um método para a entrada de
             * dados da matriz, e depois um método para pesquisa, onde esse método deverá
             * retornar a quantidade de vezes que esse número aparece na matriz.
             */

            //usar classe de numeros randomicos
            Random gerador = new Random();

            int[,] matriz = new int[4, 3];
            int linha, coluna, pesq, qtd = 0;

            //entrada de dados
            for (linha = 0; linha < 4; linha++)
            {
                for (coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write($"\nDigite o valor para matriz {linha},{coluna}:");
                    //entrada manual
                    //matriz[linha, coluna] = Convert.ToInt32(Console.ReadLine());
                    //gera numeros entre 0 e 99
                    matriz[linha, coluna] = gerador.Next(0, 11);
                    Console.Write(matriz[linha, coluna]);
                }
            }

            Console.Write("Informe o numero para pesquisar: ");
            pesq = Convert.ToInt32(Console.ReadLine());

            //pesquisa
            for (linha = 0; linha < 4; linha++)
            {
                for (coluna = 0; coluna < 3; coluna++)
                {
                    if (pesq == matriz[linha, coluna])
                    {
                        qtd++;
                    }
                }
            }

            //outra forma de pesquisar
            qtd = 0;
            foreach (int aux in matriz)
            {
                if (pesq == aux)
                {
                    qtd++;
                }
            }

            Console.WriteLine($"O numero {pesq} aparece {qtd} vezes na matriz");
            Console.ReadKey();
        }
    }
}