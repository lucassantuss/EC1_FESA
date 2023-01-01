using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_SaldoMedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis 
            double saldo_medio, credito;

            Console.Write("Digite seu saldo médio: ");
            saldo_medio = Convert.ToDouble(Console.ReadLine());

            if (saldo_medio <= 500)
            {
                Console.WriteLine($"\nSeu saldo médio é R$ {saldo_medio}");
                Console.WriteLine($"Você não tem crédito.");
            }
            else if (saldo_medio <= 1000)
            {
                credito = (saldo_medio * 0.3);
                Console.WriteLine($"\nSeu saldo médio é R$ {saldo_medio}");
                Console.WriteLine($"Seu crédito é de R$ {credito}.");
            }
            else if (saldo_medio <= 3000)
            {
                credito = (saldo_medio * 0.4);
                Console.WriteLine($"\nSeu saldo médio é R$ {saldo_medio}");
                Console.WriteLine($"Seu crédito é de R$ {credito}.");
            }
            else if (saldo_medio > 3000)
            {
                credito = (saldo_medio * 0.5);
                Console.WriteLine($"\nSeu saldo médio é R$ {saldo_medio}");
                Console.WriteLine($"Seu crédito é de R$ {credito}.");
            }

            Console.ReadKey();
        }
    }
}