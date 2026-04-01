using MedTime.Models;
using Xunit;

namespace MedTime.Tests;
public class MedicamentoTests
{
    [Fact]
    public void DeveCriarMedicamento()
    {
        var med = new Medicamento("Dipirona", "08:00");

        Assert.Equal("Dipirona", med.Nome);
        Assert.False(med.Tomado);
    }
}