using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex49_StructCadastroDetento
{
    internal class Program
    {
        struct Detento
        {
            public string nome, condenacao;
            public int pena;
        }

        static void Main(string[] args)
        {
            /*
            49. Faça um programa para gravar os seguintes dados de um detento:

            nome : string;  Não pode estar vazio
            pena : int ;  Entre 1 e 500 anos
            condenação : string ; Obrigatória pelo menos 5 letras

            Ao final exiba os dados no formato nome - pena - condenação 
            */

            Detento d = new Detento();

            do
            {
                Console.WriteLine("Digite o nome do detento: ");
                d.nome = Console.ReadLine();
            }
            while (d.nome.Length == 0);

            do
            {
                Console.WriteLine("Digite a pena entre 1 e 500 anos: ");
                d.pena = Convert.ToInt32(Console.ReadLine());
            }
            while (d.pena < 1 || d.pena > 500);

            do
            {
                Console.WriteLine("Digite a condenação: ");
                d.condenacao = Console.ReadLine();
            }
            while (d.condenacao.Length <= 4);

            Console.WriteLine("{0} - {1} - {2}", d.nome, d.pena, d.condenacao);
            Console.ReadLine();
        }
    }
}