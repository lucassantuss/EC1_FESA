using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex42_MenuNomes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            42.	Solicite até 30 nomes. Após ler os 30 nomes, exiba um menu com as seguintes opções:

            1-> exibir todos os nomes
            2-> exibir o maior nome (que tem mais letras). Se, por exemplo, os 2 maiores nomes tiverem o mesmo número de de letras, exibir os 2.
            3-> exibir apenas o primeiro nome de todos os nomes informados
            4-> Exibir apenas os nomes que inicial com vogal.
            5-> Sair
            */

            const int MAX = 3;

            string[] nomes = new string[MAX];
            char resp;
            int qtde = 0;

            for (int n = 0; n < MAX; n++)
            {
                Console.Write("Digite um nome: ");
                nomes[n] = Console.ReadLine();
                qtde++;

                if (n < MAX - 1)
                {
                    Console.Write("Deseja continuar? <s/n>: ");
                    resp = Console.ReadLine().ToUpper()[0];
                    if (resp != 'S')
                        break;
                }
            }

            do
            {
                Console.WriteLine("1-> exibir todos os nomes");
                Console.WriteLine("2-> exibir o maior nome (que tem mais letras). ");
                Console.WriteLine("3-> exibir apenas o primeiro nome de todos os nomes informados");
                Console.WriteLine("4-> Exibir apenas os nomes que inicial com vogal.");
                Console.WriteLine("5-> Sair");
                resp = Console.ReadLine().ToUpper()[0];

                if (resp == '1')
                {
                    for (int n = 0; n < qtde; n++)
                        Console.WriteLine(nomes[n]);
                }
                else if (resp == '2')
                {
                    //primeira etapa: descobrir quantas letras tem o maior nome
                    int maior = nomes[0].Length;
                    for (int n = 1; n < qtde; n++)
                    {
                        if (nomes[n].Length > maior)
                            maior = nomes[n].Length;
                    }

                    //segunda etapa: exibir todos os nomes que tenham a quantidade de letras = maior
                    for (int n = 0; n < qtde; n++)
                    {
                        if (nomes[n].Length == maior)
                            Console.WriteLine(nomes[n]);
                    }
                }
                else if (resp == '3')
                {
                    for (int n = 0; n < qtde; n++)
                    {
                        int pos = nomes[n].IndexOf(' ');
                        if (pos == -1)
                            Console.WriteLine(nomes[n]);
                        else
                            Console.WriteLine(nomes[n].Substring(0, pos));
                    }
                }
                else if (resp == '4')
                {
                    for (int n = 0; n < qtde; n++)
                    {
                        char letra = nomes[n].ToUpper()[0];
                        if (letra == 'A' || letra == 'E' ||
                            letra == 'I' || letra == 'O' ||
                            letra == 'U')
                        {
                            Console.WriteLine(nomes[n]);
                        }
                    }
                }
            }
            while (resp != '5');
        }
    }
}