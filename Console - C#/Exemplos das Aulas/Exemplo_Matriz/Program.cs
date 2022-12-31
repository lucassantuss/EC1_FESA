using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //matriz 4x3
            int[,] matriz = new int[4, 3]; //quantidade de linhas e colunas

            //matriz tridimensional
            //armazenar a quantidade de:
            //produtos vendidos, em um determinado mes, em um determinado dia
            //de um determinado ano
            //100 produtos, em 12 meses, nos ultimos 10 anos

            const int PRODUTOS = 100; //constantes
            const int MESES = 12;
            const int ANOS = 10;
            int[,,] vendas = new int[PRODUTOS, MESES, ANOS];

            int linha, coluna;

            //entrada de dados
            for (linha = 0; linha < 4; linha++)
            {
                for (coluna = 0; coluna < 3; coluna++)
                {
                    //solicitar os dados
                    Console.Write($"Digite o valor Matriz[{linha},{coluna}]: ");
                    //Console.Write("Digite o valor Matriz[{0}, {1}]: ", linha, coluna);
                    matriz[linha, coluna] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //exibir os dados
            for (linha = 0; linha < 4; linha++)
            {
                for (coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write($"{matriz[linha, coluna]} \t");
                }

                //pular uma linha
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}