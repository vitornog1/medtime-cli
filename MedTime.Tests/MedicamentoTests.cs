using System;
using MedTime.Models;

public class MedicamentoTests
{
    public static void DeveCriarMedicamento()
    {
        var med = new Medicamento("Dipirona", "08:00");

        if (med.Nome != "Dipirona")
        {
            Console.WriteLine("❌ Erro: Nome incorreto");
            return;
        }

        if (med.Tomado != false)
        {
            Console.WriteLine("❌ Erro: Status Tomado deveria ser false");
            return;
        }

        Console.WriteLine("✅ Teste passou!");
    }
}