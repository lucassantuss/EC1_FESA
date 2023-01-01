using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex55_Menu30Nomes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 55
             * 
             * Solicite até 30 nomes. Após ler os 30 nomes, exiba um menu com as seguintes opções:
             * 
             * 1-> exibir todos os nomes
             * 
             * 2-> exibir o maior nome (que tem mais letras). Se, por exemplo, os 2 maiores nomes tiverem o mesmo número de
             * de letras, exibir os 2.
             * 
             * 3-> exibir apenas o primeiro nome de todos os nomes informados
             * 
             * 4-> Exibir apenas os nomes que inicial com vogal.
             * 
             * 5-> Sair 
             */

            Console.ForegroundColor = ConsoleColor.Green;

            Console.Clear();

            String[] nomes = new string[30];
            int qtd = -1, opc, maiorQtdLetra = 0;
            String resp;

            do
            {
                qtd++;
                Console.Write("Digite o nome {0}:", qtd);
                nomes[qtd] = Console.ReadLine();

                //descobre a maior qtd de letras
                if (nomes[qtd].Length > maiorQtdLetra)
                    maiorQtdLetra = nomes[qtd].Length;

                Console.Write("Quer cadastrar outro? (S/N):");
                resp = Console.ReadLine();

            } while (resp.ToUpper() == "S" && qtd < 30);

            //exibir o menu
            do
            {
                Console.Clear(); //limpa a tela
                Console.WriteLine("1->exibir todos os nomes");
                Console.WriteLine("2->exibir o maior nome(que tem mais letras).");
                Console.WriteLine("3->exibir apenas o primeiro nome de todos os nomes informados");
                Console.WriteLine("4->Exibir apenas os nomes que inicial com vogal.");
                Console.WriteLine("5->Sair");

                Console.Write("Qual opção: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1: //exibir todos os nomes
                        for (int i = 0; i <= qtd; i++)
                        {
                            Console.WriteLine("Nome: {0}",
                                nomes[i]);
                        }
                        break;
                    case 2: //maiores nomes
                        foreach (String x in nomes)
                        {
                            if (x != null && x.Length == maiorQtdLetra)
                                Console.WriteLine(x);
                        }
                        //for normal
                        for (int i = 0; i <= qtd; i++)
                        {
                            if (nomes[i].Length == maiorQtdLetra)
                                Console.WriteLine(nomes[i]);
                        }
                        break;
                    case 3:
                        for (int i = 0; i <= qtd; i++)
                        {
                            int pos = nomes[i].IndexOf(' ');
                            Console.WriteLine("{0}",
                                nomes[i].Substring(0, pos));
                        }
                        break;
                    case 4:
                        for (int i = 0; i <= qtd; i++)
                        {
                            char primeiraLetra = nomes[i][0];
                            if ("aeiou".IndexOf(primeiraLetra) != -1)
                            {
                                Console.WriteLine(nomes[i]);
                            }
                        }
                        break;
                }

                //espera uma tecla
                Console.Write("Pressione qualquer tecla para continuar");
                Console.ReadKey();
            } while (opc < 5); //loop infinito

            Console.ReadKey();
        }
    }
}