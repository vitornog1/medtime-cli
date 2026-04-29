using System;
using MedTime.Services;
using MedTime.Tests;

internal class Program
{
    private static async Task Main(string[] args)
    {
        var service = new MedicamentoService();

        while (true)
        {
            Console.WriteLine("\n=== MedTime CLI ===");
            Console.WriteLine("1 - Cadastrar medicamento");
            Console.WriteLine("2 - Listar medicamentos");
            Console.WriteLine("3 - Marcar como tomado");
            Console.WriteLine("5 - Buscar cidade por CEP");
            Console.WriteLine("4 - Ver pendentes");
            Console.WriteLine("9 - Rodar teste");
            Console.WriteLine("0 - Sair");

            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Nome: ");
                    var nome = Console.ReadLine();

                    Console.Write("Horário: ");
                    var horario = Console.ReadLine();

                    service.Adicionar(nome, horario);
                    break;

                case "2":
                    service.Listar();
                    break;

                case "3":
                    Console.Write("Nome do medicamento: ");
                    var nomeTomado = Console.ReadLine();

                    service.MarcarComoTomado(nomeTomado);
                    break;

                case "4":
                    service.ListarPendentes();
                    break;


                case "5":
                    Console.Write("Digite o CEP: ");
                    var cep = Console.ReadLine();

                    var cepService = new CepService();
                    var cidadeNome = await cepService.BuscarEndereco(cep);

                    Console.WriteLine($"\nCidade encontrada: {cidadeNome}");
                    break;

                case "8":
                      CepServiceTests.TesteBuscarCep();
                      break;

                case "9":
                    // 👇 AQUI CHAMA O TESTE
                    MedicamentoTests.DeveCriarMedicamento();
                    break;

                case "0":
                    return;
            }
        }
    }
}