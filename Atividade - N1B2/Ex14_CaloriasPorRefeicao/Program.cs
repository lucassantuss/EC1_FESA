using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14_CaloriasPorRefeicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis
            int prato = 0, sobremesa = 0, bebida = 0;
            int CALprato = 0, CALsobremesa = 0, CALbebida = 0;
            int total_calorias;

            while (prato < 1 || prato > 4)
            {
                // Entrada de dados da escolha do prato
                Console.WriteLine("Digite o número do prato que deseja:");
                Console.WriteLine("1 - Vegetariano");
                Console.WriteLine("2 - Peixe");
                Console.WriteLine("3 - Frango");
                Console.WriteLine("4 - Carne\n");

                prato = Convert.ToInt32(Console.ReadLine());

                if (prato < 1 || prato > 4)
                {
                    Console.WriteLine("\n- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                    Console.WriteLine("| Número incorreto!! Por favor, digite um número entre 1 a 4 |");
                    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n");
                    continue;
                }

                // Alteração de variável de acordo com o prato
                if (prato == 1)
                    CALprato = 180;
                else if (prato == 2)
                    CALprato = 230;
                else if (prato == 3)
                    CALprato = 250;
                else if (prato == 4)
                    CALprato = 350;
            }

            while (sobremesa < 1 || sobremesa > 4)
            {
                // Entrada de dados da escolha da sobremesa
                Console.WriteLine("\nDigite o número da sobremesa que deseja:");
                Console.WriteLine("1 - Abacaxi");
                Console.WriteLine("2 - Sorvete diet");
                Console.WriteLine("3 - Mousse diet");
                Console.WriteLine("4 - Mousse de chocolate\n");

                sobremesa = Convert.ToInt32(Console.ReadLine());

                if (sobremesa < 1 || sobremesa > 4)
                {
                    Console.WriteLine("\n- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                    Console.WriteLine("| Número incorreto!! Por favor, digite um número entre 1 a 4 |");
                    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n");
                    continue;
                }

                // Alteração da variável de acordo com a escolha da sobremesa
                if (sobremesa == 1)
                    CALsobremesa = 75;
                else if (sobremesa == 2)
                    CALsobremesa = 110;
                else if (sobremesa == 3)
                    CALsobremesa = 170;
                else if (sobremesa == 4)
                    CALsobremesa = 200;
            }

            while (bebida < 1 || bebida > 4)
            {
                // Entrada de dados da escolha da bebida
                Console.WriteLine("\nDigite o número da bebida que deseja:");
                Console.WriteLine("1 - Chá");
                Console.WriteLine("2 - Suco de laranja");
                Console.WriteLine("3 - Suco de melão");
                Console.WriteLine("4 - Refrigerante diet\n");

                bebida = Convert.ToInt32(Console.ReadLine());

                if (bebida < 1 || bebida > 4)
                {
                    Console.WriteLine("\n- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                    Console.WriteLine("| Número incorreto!! Por favor, digite um número entre 1 a 4 |");
                    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n");
                    continue;
                }

                // Alteração da variável de acordo com a escolha da bebida
                if (bebida == 1)
                    CALbebida = 20;
                else if (bebida == 2)
                    CALbebida = 70;
                else if (bebida == 3)
                    CALbebida = 100;
                else if (bebida == 4)
                    CALbebida = 65;

                total_calorias = CALprato + CALsobremesa + CALbebida;

                Console.WriteLine($"\nA quantidade de calorias dessa refeição é de {total_calorias} calorias");
            }

            Console.ReadKey();
        }
    }
}