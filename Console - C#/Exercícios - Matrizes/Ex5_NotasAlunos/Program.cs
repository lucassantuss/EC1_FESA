using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_NotasAlunos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 5
             * 
             * - Faça um programa que possibilite o controle de 2
             * alunos com duas disciplinas cada um e com 4 notas para cada disciplina/aluno.
             * Você deverá solicitar também os nomes dos alunos e das disciplinas.
             * Ao final exiba os alunos e as disciplinas que ele foi aprovado de acordo com a
             * média aritmética calculada. A média para ser aprovado é 6.0
             * 
             * Dica: Usar uma matriz tridimensional.
             */

            String[] nome = new String[2];
            String[,] disciplina = new String[2, 2];

            //cria a matriz
            Double[,,] notas = new Double[2, 2, 4];
            Int16 linha, coluna;

            //Preenchendo os dados
            for (linha = 0; linha < 2; linha++)
            {
                Console.Write("Qual o nome do Aluno {0}: ",
                            linha);
                nome[linha] = Console.ReadLine();
            }

            for (int aluno = 0; aluno < 2; aluno++)
            {
                Console.Write("Disciplinas e notas para {0}\n",
                        nome[aluno]);
                for (int disc = 0; disc < 2; disc++)
                {
                    Console.Write("Qual a Disciplina: ");
                    disciplina[aluno, disc] = Console.ReadLine();

                    for (int not = 0; not < 4; not++)
                    {
                        Console.Write("Digite a {0}ª Nota:",
                                not + 1);
                        notas[aluno, disc, not] = Convert.ToDouble(
                            Console.ReadLine());
                    }
                }
            }

            //calculando a media das disciplinas
            for (int aluno = 0; aluno < 2; aluno++) //aluno
            {
                for (int disc = 0; disc < 2; disc++) //disciplina
                {
                    Double soma = 0;
                    for (int not = 0; not < 4; not++) //notas
                    {
                        soma += notas[aluno, disc, not];
                    }

                    if (soma / 4 >= 6) //aprovado
                    {
                        Console.WriteLine("O aluno {0}, foi" +
                            " aprovado na disciplina {1}, " +
                            "com média {2}", nome[aluno],
                            disciplina[aluno, disc],
                            soma / 4);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}