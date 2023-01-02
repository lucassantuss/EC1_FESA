using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex29_CadastroDetento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            29.	Faca um programa de cadastro. Solicite os seguintes dados:

            Cadastro de Detento

            codigo : integer (maior que zero)
            nome   : string  (Obrigatorio  pelo menos 1 letra)
            condenacao : string  (obrigatorio ao menos 5 letras)
            pena : int (entre 1 e 500 anos)

            Ao final do cadastro, exiba os dados:
            Codigo: ______
            Nome: ________
            Condenacao:__________
            Pena:_______

            Pergunte se o usuário deseja cadastrar outro detento ou sair do programa. 
            */

            char resp;
            int codigo;
            string nome;
            string condenacao;
            int pena;

            do
            {
                do
                {
                    Console.Write("Digite o codigo o preso: ");
                    codigo = Convert.ToInt16(Console.ReadLine());

                    if (codigo <= 0)
                        Console.WriteLine("Código tem que ser positivo.");
                }
                while (codigo <= 0);

                do
                {
                    Console.Write("Digite o nome do preso: ");
                    nome = Console.ReadLine();
                }
                while (nome.Length == 0);

                do
                {
                    Console.Write("Digite a pena em anos: ");
                    pena = Convert.ToInt16(Console.ReadLine());
                }
                while (pena < 1 || pena > 500);

                do
                {
                    Console.Write("Digite a condenação: ");
                    condenacao = Console.ReadLine();
                }
                while (condenacao.Length < 5);

                Console.WriteLine("\n\n**** RESUMO **** \n\n");
                Console.WriteLine("Código: {0}", codigo);
                Console.WriteLine("Nome: {0}", nome);
                Console.WriteLine("Pena: {0}", pena);
                Console.WriteLine("Condenação: {0}", condenacao);

                Console.Write("Deseja continuar? <S/N>: ");
                resp = Console.ReadLine()[0];
            }
            while (resp == 'S' || resp == 's');
        }
    }
}