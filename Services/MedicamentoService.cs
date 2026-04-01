using MedTime.Models;

namespace MedTime.Services;

public class MedicamentoService
{
    private List<Medicamento> lista = new();

    public void Adicionar(string nome, string horario)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("Nome inválido!");
            return;
        }

        lista.Add(new Medicamento(nome, horario));
        Console.WriteLine("Medicamento cadastrado!");
    }

    public List<Medicamento> ObterTodos()
    {
        return lista;
    }

    public void Listar()
    {
        if (!lista.Any())
        {
            Console.WriteLine("Nenhum medicamento cadastrado.");
            return;
        }

        foreach (var m in lista)
        {
            Console.WriteLine($"{m.Nome} - {m.Horario} - {(m.Tomado ? "Tomado" : "Pendente")}");
        }
    }

    public void MarcarComoTomado(string nome)
    {
        var med = lista.FirstOrDefault(m => m.Nome == nome);

        if (med == null)
        {
            Console.WriteLine("Medicamento não encontrado.");
            return;
        }

        med.Tomado = true;
        Console.WriteLine("Marcado como tomado!");
    }

    public List<Medicamento> ObterPendentes()
    {
        return lista.Where(m => !m.Tomado).ToList();
    }

    public void ListarPendentes()
    {
        var pendentes = ObterPendentes();

        if (!pendentes.Any())
        {
            Console.WriteLine("Nenhum medicamento pendente.");
            return;
        }

        foreach (var m in pendentes)
        {
            Console.WriteLine($"{m.Nome} - {m.Horario}");
        }
    }
}