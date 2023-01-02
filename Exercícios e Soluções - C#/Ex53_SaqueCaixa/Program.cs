using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex53_SaqueCaixa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] caixa24 = {100,
                                50,
                                20,
                                10,
                                5,
                                2,
                                1,
                                0.50,
                                0.25,
                                0.10,
                                0.05
                                };

            Console.WriteLine("Digite o valor para sacar: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            for (int n = 0; n < caixa24.Length && valor > 0; n++)
            {
                if (valor / caixa24[n] >= 1)
                {
                    double qtde = Math.Truncate(valor / caixa24[n]);
                    valor = valor % caixa24[n];
                    Console.WriteLine("{0} notas de {1}", qtde, caixa24[n]);
                }
            }

            Console.ReadKey();
        }
    }
}