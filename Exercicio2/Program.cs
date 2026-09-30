using System;
using System.Reflection;

namespace Exercicio2;

[AttributeUsage(AttributeTargets.Property)]
public class ExibirAttribute : Attribute
{
}

public class Equipamento
{
    public int Id { get; set; }
    [Exibir]
    public string Nome { get; set; } = string.Empty;
    [Exibir]
    public string Fabricante { get; set; } = string.Empty;
    public string NumeroSerie { get; set; } = string.Empty;
    [Exibir]
    public decimal Valor { get; set; }
    [Exibir]
    public string Localizacao { get; set; } = string.Empty;
}

public class Program
{
    public static void ExibirDadosAberto(object objeto)
    {
        var propriedades = objeto.GetType().GetProperties();

        foreach (var propriedade in propriedades)
        {
            var valor = propriedade.GetValue(objeto);
            Console.WriteLine($"{propriedade.Name}: {valor ?? "null"}");
        }
    }

    public static void ExibirDadosControlado(object objeto)
    {
        var propriedades = objeto.GetType().GetProperties();

        foreach (var propriedade in propriedades)
        {
            var atributo = propriedade.GetCustomAttribute<ExibirAttribute>();

            if (atributo is not null)
            {
                var valor = propriedade.GetValue(objeto);
                Console.WriteLine($"{propriedade.Name}: {valor ?? "null"}");
            }
        }
    }

    public static void Main()
    {
        var equipamento = new Equipamento
        {
            Id = 101,
            Nome = "Notebook Dell",
            Fabricante = "Dell",
            NumeroSerie = "DL-2024-001",
            Valor = 4200.00m,
            Localizacao = "Sala de TI"
        };

        Console.WriteLine("=== Dados abertos ===");
        ExibirDadosAberto(equipamento);

        Console.WriteLine();
        Console.WriteLine("=== Dados controlados ===");
        ExibirDadosControlado(equipamento);
    }
}
