using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex52_Caixa
{
    internal class Program
    {
        struct StructCaixa
        {
            public string data;
            public double entradas, saidas;
        }

        static void Main(string[] args)
        {
            /*
             52. Caixa

             Faça um programa para armazenar o caixa de uma empresa.
             
             O caixa é registrado diariamente  informando se:
             
             * DATA (DD/MM/AA)  (para simplificar a validação: DD entre 1 e 31, 
             * MM entre 1 e 12 e AA > 00 ) com 8 posições.
             * Total de Entradas (>=0 )
             * Total de Saidas (>= 0)
             
             Permita a digitação de um caixa de até 30 dias.
             
             O usuário poderá parar a qualquer momento.
             Ao termino da digitação, exiba um menu com as seguintes opções:
             
             1-) Exibir o caixa  no formato :  DATA - Entradas - Saídas
             2-) Exibir o Total geral de entradas
             3-) Exibir o Total geral de saídas
             4-) Exibir o saldo : Total de entradas - Total de Saídas
             5-) Exibir o caixa por mês. Solicite o mês e exiba somente (MM) os dados pertinentes no mesmo formato da opção 1.
             7-) Sair.
             */

            StructCaixa[] caixa = new StructCaixa[30];

            char resp;
            int qtde = 0;
            for (int n = 0; n < caixa.Length; n++)
            {
                qtde++;

                bool correto = false;
                do
                {
                    Console.Write("Digite a data no formato dd/mm/yy: ");
                    caixa[n].data = Console.ReadLine();
                    if (caixa[n].data.Length == 8)
                    {
                        int dia = Convert.ToInt16(caixa[n].data.Substring(0, 2));
                        if (dia >= 1 && dia <= 31)
                        {
                            int mes = Convert.ToInt16(caixa[n].data.Substring(3, 2));
                            if (mes >= 1 && mes <= 12)
                            {
                                int ano = Convert.ToInt16(caixa[n].data.Substring(6, 2));
                                if (ano > 0)
                                {
                                    correto = true;
                                }
                            }
                        }
                    }
                }
                while (!correto);

                do
                {
                    Console.Write("Digite o valor das entradas do dia: ");
                    caixa[n].entradas = Convert.ToDouble(Console.ReadLine());
                }
                while (caixa[n].entradas < 0);

                do
                {
                    Console.Write("Digite o valor das saídas do dia: ");
                    caixa[n].saidas = Convert.ToDouble(Console.ReadLine());
                }
                while (caixa[n].saidas < 0);

                Console.Write("Deseja continuar? <s/n> ");
                resp = Console.ReadLine().ToUpper()[0];
                if (resp != 'S')
                    break;
            }

            double totalE = 0, totalS = 0;
            for (int n = 0; n < qtde; n++)
            {
                totalE = totalE + caixa[n].entradas;
                totalS = totalS + caixa[n].saidas;
            }

            do
            {
                Console.WriteLine("1-) Exibir o caixa  no formato :  DATA - Entradas - Saídas");
                Console.WriteLine("2-) Exibir o Total geral de entradas");
                Console.WriteLine("3-) Exibir o Total geral de saídas");
                Console.WriteLine("4-) Exibir o saldo : Total de entradas - Total de Saídas");
                Console.WriteLine("5-) Exibir o caixa por mês.");
                Console.WriteLine("7-) Sair.");
                resp = Console.ReadLine()[0];

                switch (resp)
                {
                    case '1':
                        for (int n = 0; n < qtde; n++)
                        {
                            Console.WriteLine("{0} - R$ {1:F2}  -  R$ {2:F2}",
                                 caixa[n].data, caixa[n].entradas,
                                 caixa[n].saidas);
                        }
                        break;
                    case '2':
                        Console.WriteLine("Total de entradas: R$ {0:F2}", totalE);
                        break;
                    case '3':
                        Console.WriteLine("Total de saídas: R$ {0:F2}", totalS);
                        break;
                    case '4':
                        Console.WriteLine("Saldo: R$ {0:F2}", totalE - totalS);
                        break;
                    case '5':

                        Console.WriteLine("Digite um mês para ver o caixa: ");
                        int mes = Convert.ToInt16(Console.ReadLine());

                        for (int n = 0; n < qtde; n++)
                        {
                            int mesCaixa = Convert.ToInt16(caixa[n].data.Substring(3, 2));
                            if (mesCaixa == mes)
                            {
                                Console.WriteLine("{0} - R$ {1:F2}  -  R$ {2:F2}",
                                caixa[n].data, caixa[n].entradas,
                                caixa[n].saidas);
                            }
                        }

                        break;
                    case '6':
                        break;
                }
            }
            while (resp != '7');
        }
    }
}