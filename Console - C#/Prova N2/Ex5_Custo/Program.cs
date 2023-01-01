using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_Custo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double custoFabrica, porcentagem, imposto, custoConsumidor;

            Console.WriteLine("Digite o custo de fábrica do carro: ");
            custoFabrica = Convert.ToDouble(Console.ReadLine());

            porcentagem = 0.12 * custoFabrica;

            imposto = 0.45 * custoFabrica;

            custoConsumidor = custoFabrica + porcentagem + imposto;

            Console.Write("\nO custo do consumidor é: " + custoConsumidor);
            Console.ReadKey();
        }
    }
}