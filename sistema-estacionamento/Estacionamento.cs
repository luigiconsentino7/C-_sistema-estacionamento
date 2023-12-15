using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_estacionamento
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal newPrecoInicial, decimal newPrecoPorHora)
        {
            precoInicial = newPrecoInicial;
            precoPorHora = newPrecoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do seu veículo para cadastrarmos: ");
            string placa = Console.ReadLine();

            veiculos.Add(placa);

            Console.WriteLine();
            Console.WriteLine("Veículo cadastrado.");

            Console.WriteLine();
        }

        public void ConsultarVeiculoCadastrado()
        {
            string placa = "";
            Console.WriteLine("Qual a placa do veículo?");
            placa = Console.ReadLine();

            Console.WriteLine();
            
            if (veiculos.Any(veiculo => veiculo.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine($"O veículo de placa: {placa} está cadastrado!");
            }
            else
            {
                Console.WriteLine($"O veículo de placa {placa} não está cadastrado em nosso sistema.");
            }

            Console.WriteLine();
        }

        public void ListarVeiculos()
        {

            int contador = 0;

            Console.WriteLine($"Os veículos cadastrados são: ");

            foreach (string veiculo in veiculos)
            {
                contador++;
                Console.WriteLine($"{contador} - {veiculo}");
            }

            Console.WriteLine();
        }

        public void RemoverVeiculo()
        {
            string placa = "";
            Console.WriteLine("Qual a placa do veículo que você deseja remover? ");
            placa = Console.ReadLine();

            Console.WriteLine();

            if (veiculos.Any(veiculo => veiculo.ToUpper() == placa.ToUpper()))
            {
                veiculos.Remove(placa);
                Console.WriteLine($"Veículo de placa: {placa} foi removido com sucesso.");
            }
            else
            {
                Console.WriteLine($"O veículo de placa: {placa} não está cadastrado em nosso sistema.");
            }

            Console.WriteLine();
        }

        public void CalculoValorVeiculo(decimal precoInicial, decimal precoPorHora)
        {
            decimal calculo = 0;
            decimal quantidadeHoras = 0;

            Console.WriteLine("Quantas horas o veículo ficou no estacionamento? ");
            quantidadeHoras = Convert.ToDecimal(Console.ReadLine());

            calculo = precoInicial + (quantidadeHoras * precoPorHora);

            Console.WriteLine();

            Console.WriteLine($"Valor total a se pagar: {calculo}");

            Console.WriteLine();
        }

    }
}
