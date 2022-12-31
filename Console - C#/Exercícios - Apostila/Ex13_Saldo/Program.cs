using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13_Saldo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 13
             * 
             * Saldo
             * 
             * Solicite:
             * 
             * nome
             * salário
             * despesas com saúde (ds)
             * despesas com lazer (dl)
             * despesas com alimentação (da)
             * Calcule o saldo: saldo = salario - (ds+dl+da)
             * 
             * Exiba o saldo e a situação dependendo das condições a seguir:
             * 
             * se saldo <=0 exiba "gaste menos..."
             * se saldo entre 0 e 3000 exiba "melhor fazer uma poupança...”
             * se saldo entre 3001 e 5000 exiba "sobrou bastante hein!”
             * se saldo > 5000 exiba "parabéns corintiano!!!" 
             */

            string nome;
            float salario, ds, dl, da, saldo;

            Console.Write("Digite o nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite o salário: ");
            salario = float.Parse(Console.ReadLine());

            Console.Write("Digite as despesas com saúde: ");
            ds = float.Parse(Console.ReadLine());

            Console.Write("Digite as despesas com lazer: ");
            dl = float.Parse(Console.ReadLine());

            Console.Write("Digite as despesas com alimentação: ");
            da = float.Parse(Console.ReadLine());

            saldo = salario - (ds + dl + da);

            Console.WriteLine("\nNome: " + nome + "\nSaldo: " + saldo);

            if (saldo <= 0)
                Console.WriteLine("Situação Financeira: gaste menos...");
            else if (saldo > 0 && saldo <= 3000)
                Console.WriteLine("Situação Financeira: melhor fazer uma poupança...");
            else if (saldo > 3000 && saldo <= 5000)
                Console.WriteLine("Situação Financeira: sobrou bastante hein!");
            else if (saldo > 5000)
                Console.WriteLine("Situação Financeira: parabéns corintiano!!!");

            Console.ReadKey();
        }
    }
}