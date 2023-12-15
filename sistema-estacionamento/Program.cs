// See https://aka.ms/new-console-template for more information
using sistema_estacionamento;

class Program
{
    public static void Main(string[] args)
    {
        decimal definirPrecoInicial = 0;
        decimal definirPrecoPorHora = 0;
        int resposta;

        Console.WriteLine("Define o preço inicial a ser pago: ");
        definirPrecoInicial = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("Define o preço a ser pago por hora: ");
        definirPrecoPorHora = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("Seja Bem Vindo ao Estacionamento Local Bacana!\n" +
            "Deseja prosseguir? \n" +
            "Digite: 1 - Sim, 2 - Não");
        resposta = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();


        Estacionamento estacionamento = new Estacionamento(definirPrecoInicial, definirPrecoPorHora);
        
        while(resposta == 1) {
            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine("1 - Cadastrar veículo");
            Console.WriteLine("2 - Remover veículo");
            Console.WriteLine("3 - Listar veículos");
            Console.WriteLine("4 - Consultar se veículo está cadastrado");
            Console.WriteLine("5 - Calcular valor total a se pagar");
            Console.WriteLine("6 - Encerrar");

            switch(Console.ReadLine())
            {
                case "1":
                    estacionamento.AdicionarVeiculo();
                    break;
                
                case "2":
                    estacionamento.RemoverVeiculo();
                    break;

                case "3":
                    estacionamento.ListarVeiculos();
                    break;

                case "4":
                    estacionamento.ConsultarVeiculoCadastrado();
                    break;

                case "5":
                    estacionamento.CalculoValorVeiculo(definirPrecoInicial, definirPrecoPorHora);
                    break;

                case "6":
                    Console.WriteLine("Sistema encerrado, Volte Sempre!");
                    break;
            }
            Console.WriteLine();

            Console.WriteLine("Seja Bem Vindo ao Estacionamento Local Bacana!\n" +
            "Deseja prosseguir? \n" +
            "Digite: 1 - Sim, 2 - Não");
            resposta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
        }

        
    }
}

