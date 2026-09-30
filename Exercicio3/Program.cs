using System;

namespace Exercicio3;

public class Reserva
{
    public int Id { get; set; }
    public string NomeHospede { get; set; } = string.Empty;
    public int NumeroQuarto { get; set; }
    public int QuantidadeDiarias { get; set; }
    public decimal ValorDiaria { get; set; }
    public string StatusInterno { get; set; } = string.Empty;
    public string ObservacaoInterna { get; set; } = string.Empty;
}

public record RelatorioReservaDto(
    string NomeHospede,
    int NumeroQuarto,
    int QuantidadeDiarias,
    decimal ValorTotal,
    string Situacao);

public class Program
{
    public static RelatorioReservaDto Mapear(Reserva reserva)
    {
        var valorTotal = reserva.QuantidadeDiarias * reserva.ValorDiaria;

        return new RelatorioReservaDto(
            reserva.NomeHospede,
            reserva.NumeroQuarto,
            reserva.QuantidadeDiarias,
            valorTotal,
            "Reserva confirmada");
    }

    public static void ExibirRelatorio(RelatorioReservaDto relatorio)
    {
        Console.WriteLine("=== Relatório da Reserva ===");
        Console.WriteLine($"Hóspede: {relatorio.NomeHospede}");
        Console.WriteLine($"Quarto: {relatorio.NumeroQuarto}");
        Console.WriteLine($"Diárias: {relatorio.QuantidadeDiarias}");
        Console.WriteLine($"Valor Total: {relatorio.ValorTotal:C}");
        Console.WriteLine($"Situação: {relatorio.Situacao}");
    }

    public static void Main()
    {
        var reserva = new Reserva
        {
            Id = 1,
            NomeHospede = "João Pereira",
            NumeroQuarto = 205,
            QuantidadeDiarias = 3,
            ValorDiaria = 280.50m,
            StatusInterno = "Confirmada",
            ObservacaoInterna = "Check-in previsto para 15:00"
        };

        var relatorio = Mapear(reserva);
        ExibirRelatorio(relatorio);
    }
}
