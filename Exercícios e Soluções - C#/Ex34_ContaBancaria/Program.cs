using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex34_ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            34.	Conta Bancária

            Solicite os seguintes dados de uma conta bancária: 
            Saldo do cliente : Double
            Limite de cheque especial: Double.

            Então, seu programa deverá entrar em um loop, 
            solicitando as seguintes opção ao cliente:
            “D” depósito
            “S” saque
            “V” visualizar o saldo
            “X” sair do programa

            Caso o usuário tenha escolhido “D”epósito, de vê-se acrescentar o valor ao saldo do cliente.
            Caso o usuário tenha escolhido “S”aque, de vê-se  subtrair o valor do saldo do cliente. O saldo pode ficar negativo até o limite de cheque especial.
            Caso o usuário  tenha solicitado “V”isualizar o saldo, exiba o saldo no vídeo.
            Caso o usuário tenha solicitado para sair do programa, saia do loop e termine a aplicação.
            */

            Console.Write("Digite o saldo do cliente: ");
            double saldo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o limite do cliente: ");
            double limite = Convert.ToDouble(Console.ReadLine());

            char opcao;

            do
            {
                Console.WriteLine("'D' - Depósito");
                Console.WriteLine("'S' - Saque");
                Console.WriteLine("'V' - Visualizar o saldo");
                Console.WriteLine("'X' - Sair do programa");
                opcao = Console.ReadLine().ToUpper()[0];

                if (opcao == 'D')
                {
                    Console.Write("Digite o valor para depósito: ");
                    double valor = Convert.ToDouble(Console.ReadLine());
                    saldo = saldo + valor;
                }
                else if (opcao == 'S')
                {
                    Console.Write("Digite o valor para sacar: ");
                    double valor = Convert.ToDouble(Console.ReadLine());
                    if (saldo + limite - valor < 0)
                        Console.WriteLine("Limite excedido!");
                    else
                        saldo = saldo - valor;
                }
                else if (opcao == 'V')
                {
                    double limiteAtual = limite;
                    if (saldo < 0)
                        limiteAtual = limite - saldo * -1;

                    Console.WriteLine("Saldo atual: {0:F2}. Limite atual: {1:F2}",
                        saldo, limiteAtual);
                }
            }
            while (opcao != 'X');
        }
    }
}