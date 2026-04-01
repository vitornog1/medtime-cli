namespace MedTime.Models;

public class Medicamento
{
    public string Nome { get; set; }
    public string Horario { get; set; }
    public bool Tomado { get; set; }

    public Medicamento(string nome, string horario)
    {
        Nome = nome;
        Horario = horario;
        Tomado = false;
    }
}