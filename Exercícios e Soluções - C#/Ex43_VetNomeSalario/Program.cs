using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex43_VetNomeSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             43 - VetNomSal
             
             Faça um programa que permita cadastrar até 50 nomes e 50 salários.
             Os nomes devem ser preenchidos e os salários devem 
             estar entre R$ 0 e 15000.
             O usuário poderá parar o cadastro se quiser.
             
             Após o cadastro, exiba um menu com as seguintes opções:
             1-) Listar todos os cadastrados no formato:  nome - salário.
             2-) Exibir todas as ocorrências de quem tem o menor salário.
             3-) Exibir só o sobrenome  de todos os cadastrados. Se não houver sobrenome, exiba o primeiro nome.
             4-) Exibir a média salarial
             6-) Sair              
             */

            const int MAX = 50;

            string[] nomes = new string[MAX];
            double[] salarios = new double[MAX];

            char resp;
            int qtde = 0;

            for (int n = 0; n < MAX; n++)
            {
                qtde++;

                do
                {
                    Console.Write("Digite o nome: ");
                    nomes[n] = Console.ReadLine();
                }
                while (nomes[n].Length == 0);

                do
                {
                    Console.Write("Digite o salário: ");
                    salarios[n] = Convert.ToDouble(Console.ReadLine());
                }
                while (salarios[n] < 0 || salarios[n] > 15000);

                if (n < MAX - 1)
                {
                    Console.Write("Deseja continuar? <s/qualquer outra letra>: ");
                    resp = Console.ReadLine().ToUpper()[0];
                    if (resp != 'S')
                        break;
                }
            }

            do
            {
                Console.WriteLine("1-) Listar todos os cadastrados no formato:  nome - salário.");
                Console.WriteLine("2-) Exibir todas as ocorrências de quem tem o menor salário.");
                Console.WriteLine("3-) Exibir só o sobrenome de todos os cadastrados. Se não houver sobrenome, exiba o primeiro nome.");
                Console.WriteLine("4-) Exibir a média salarial");
                Console.WriteLine("6-) Sair   ");
                resp = Console.ReadLine().ToUpper()[0];

                switch (resp)
                {
                    case '1':
                        for (int i = 0; i < qtde; i++)
                        {
                            Console.WriteLine("{0} - R$ {1:F2}", nomes[i], salarios[i]);
                        }
                        break;

                    case '2':
                        double menor = salarios[0];
                        for (int i = 1; i < qtde; i++)
                        {
                            if (salarios[i] < menor)
                                menor = salarios[i];
                        }

                        for (int i = 0; i < qtde; i++)
                        {
                            if (salarios[i] == menor)
                                Console.WriteLine("{0} - R$ {1:F2}", nomes[i], salarios[i]);
                        }
                        break;

                    case '3':
                        for (int i = 0; i < qtde; i++)
                        {
                            int pos = nomes[i].IndexOf(' ');

                            if (pos == -1)
                                Console.WriteLine("{0}", nomes[i]);
                            else
                                Console.WriteLine("{0}", nomes[i].Substring(pos + 1));
                        }
                        break;

                    case '4':
                        double soma = 0;
                        for (int i = 0; i < qtde; i++)
                            soma += salarios[i];

                        Console.WriteLine("Média salarial: {0:F2}", soma / qtde);

                        break;
                }
            }
            while (resp != '6');
        }
    }
}