using System;
using MedTime.Services;
using MedTime.Tests;

var service = new MedicamentoService();

while (true)
{
    Console.WriteLine("\n=== MedTime CLI ===");
    Console.WriteLine("1 - Cadastrar medicamento");
    Console.WriteLine("2 - Listar medicamentos");
    Console.WriteLine("3 - Marcar como tomado");
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

        case "9":
            // 👇 AQUI CHAMA O TESTE
            MedicamentoTests.DeveCriarMedicamento();
            break;

        case "0":
            return;
    }
}