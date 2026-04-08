
using MedTime.Models;

namespace MedTime.Tests
{
    public static class MedicamentoTests
    {
        public static void Rodar()
        {
            Console.WriteLine("🔎 Rodando testes...\n");

            TesteCriarMedicamento();

            Console.WriteLine("\n✅ Todos os testes finalizaram.");
        }

        private static void TesteCriarMedicamento()
        {
            var med = new Medicamento("Dipirona", "08:00");

            if (med.Nome == "Dipirona" && med.Tomado == false)
            {
                Console.WriteLine("✅ TesteCriarMedicamento passou");
            }
            else
            {
                Console.WriteLine("❌ TesteCriarMedicamento falhou");
            }
        }
    }
}