using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex54_Automovel
{
    internal class Program
    {
        struct Modelo
        {
            public string marca, tipo;
        }

        struct Carro
        {
            public string placa;
            public int ano;
            public Modelo modelo;
        }

        static void Main(string[] args)
        {
            /*
            54.	 Automóvel
            Crie uma estrutura (MODELO) para guardar o modelo de um automóvel:
              string marca  (obrigatório)
              string tipo (obrigatório)

            Crie outra estrutura (CARRO) para guardar os dados de um determinado automóvel:
              string placa  (obrigatório 3 letras, um hífen, 4 números: EX: XXX-9999)
              int ano de fabricação    >= 2000
              MODELO modelo

            Crie um vetor para cadastrar até 10 carros. 
            Pergunte se o usuário deseja parar o  cadastro após cadastrar um carro.
            Ao final, exiba os dados em vídeo.
            */

            Carro[] carros = new Carro[10];
            int qtde = 0;
            char resp;

            for (int n = 0; n < carros.Length; n++)
            {
                qtde++;
                bool correto = false;
                do
                {
                    Console.WriteLine("Digite a placa no formato XXX-9999 :");
                    carros[n].placa = Console.ReadLine();
                    if (carros[n].placa.Length == 8 &&
                        carros[n].placa[3] == '-')
                    {
                        char placaCorreta = 'S';
                        //testar se os 3 primeiros são letra
                        for (int i = 0; i <= 2; i++)
                        {
                            if (Convert.ToInt16(carros[n].placa[i]) < 65 ||
                                Convert.ToInt16(carros[n].placa[i]) > 122)
                            {
                                placaCorreta = 'N';
                                break;
                            }
                        }

                        if (placaCorreta == 'S')
                        {
                            //vamos testar agora só os números
                            for (int i = 4; i <= 7; i++)
                            {
                                if (Convert.ToInt16(carros[n].placa[i]) < 48 ||
                                    Convert.ToInt16(carros[n].placa[i]) > 57)
                                {
                                    placaCorreta = 'N';
                                    break;
                                }
                            }
                        }

                        if (placaCorreta == 'S')
                            correto = true;
                    }
                }
                while (correto == false);

                do
                {
                    Console.WriteLine("Digite o ano: ");
                    carros[n].ano = Convert.ToInt32(Console.ReadLine());
                }
                while (carros[n].ano < 2000);

                do
                {
                    Console.WriteLine("Digite a marca do carro: ");
                    carros[n].modelo.marca = Console.ReadLine();
                }
                while (carros[n].modelo.marca.Length == 0);

                do
                {
                    Console.WriteLine("Digite o modelo do carro: ");
                    carros[n].modelo.tipo = Console.ReadLine();
                }
                while (carros[n].modelo.tipo.Length == 0);

                Console.WriteLine("Deseja continuar? <s/n> ");
                resp = Console.ReadLine().ToUpper()[0];
                if (resp != 'S')
                    break;
            }

            Console.WriteLine("\n\nCarros Cadastrados\n\n");

            for (int n = 0; n < qtde; n++)
            {
                Console.WriteLine("Placa: {0} - Ano: {1} - Marca: {2} - Modelo: {3}",
                    carros[n].placa, carros[n].ano, carros[n].modelo.marca,
                    carros[n].modelo.tipo);
            }

            Console.ReadKey();
        }
    }
}