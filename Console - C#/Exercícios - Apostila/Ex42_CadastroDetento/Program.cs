using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex42_CadastroDetento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 42
             * 
             * Faça um programa de cadastro. Solicite os seguintes dados:
             * 
             * Cadastro de Detento
             * 
             * codigo : integer (maior que zero)
             * nome : string (Obrigatorio pelo menos 1 letra)
             * condenacao : string (obrigatorio ao menos 5 letras)
             * pena : int (entre 1 e 500 anos)
             * 
             * Ao final do cadastro, exiba os dados:
             * 
             * Codigo: ______
             * Nome: ________
             * Condenacao:__________
             * Pena:_______
             * 
             * Pergunte se o usuário deseja cadastrar outro detento ou sair do programa.
             */

            int codigo = 1, pena = 1;
            string nome = "a", condenacao = "abcde", reset = "";

            do
            {
                Console.WriteLine("--- CADASTRO DO DETENTO ---\n");

                do
                {
                    if (codigo <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Código Inválido!!!\nDigite um código maior que zero\n");
                    }

                    Console.Write("Digite o código: ");
                    codigo = int.Parse(Console.ReadLine());

                } while (codigo <= 0);

                do
                {
                    if (nome.Length == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Nome Inválido!!!\nDigite um nome com pelo menos um caractere\n");
                    }

                    Console.Write("Digite o nome: ");
                    nome = Console.ReadLine();

                } while (nome.Length == 0);

                do
                {
                    if (condenacao.Length <= 4)
                    {
                        Console.Clear();
                        Console.WriteLine("Condenação Inválida!!!\nDigite uma condenação com pelo menos cinco caracteres\n");
                    }

                    Console.Write("Digite a condenação: ");
                    condenacao = Console.ReadLine();

                } while (condenacao.Length <= 4);


                do
                {
                    if (pena <= 0 || pena > 500)
                    {
                        Console.Clear();
                        Console.WriteLine("Pena Inválida!!!\n\nDigite uma pena entre 1 e 500 anos\n");
                    }

                    Console.Write("Digite quantos anos de pena: ");
                    pena = int.Parse(Console.ReadLine());

                } while (pena <= 0 || pena > 500);

                Console.WriteLine("\n--- DADOS DO DETENTO ---");
                Console.WriteLine("Código: " + codigo);
                Console.WriteLine("Nome: " + nome);
                Console.WriteLine("Condenação: " + condenacao);
                Console.WriteLine("Pena: " + pena + " anos");

                Console.WriteLine("\nDeseja cadastrar outro detento? (S/N)");
                reset = Console.ReadLine();

                reset = reset.Substring(0, 1);

            } while (reset.ToUpper() == "S");
        }
    }
}