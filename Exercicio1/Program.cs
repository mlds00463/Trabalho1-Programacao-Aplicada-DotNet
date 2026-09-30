using System;

namespace Exercicio1;

public class UsuarioBiblioteca
{
    public string Nome { get; set; } = string.Empty;
    public int QuantidadeEmprestimosAtivos { get; set; }
}

public class Aluno : UsuarioBiblioteca
{
    public string Matricula { get; set; } = string.Empty;
}

public class Professor : UsuarioBiblioteca
{
    public string Departamento { get; set; } = string.Empty;
}

public class Visitante : UsuarioBiblioteca
{
    public string Documento { get; set; } = string.Empty;
}

public class Program
{
    public static string VerificarEmprestimo(object? obj) =>
        obj switch
        {
            null => "Usuário inválido",
            Aluno { QuantidadeEmprestimosAtivos: < 3 } => "Empréstimo autorizado para aluno",
            Aluno { QuantidadeEmprestimosAtivos: >= 3 } => "Limite de empréstimos atingido para aluno",
            Professor { QuantidadeEmprestimosAtivos: < 5 } => "Empréstimo autorizado para professor",
            Professor { QuantidadeEmprestimosAtivos: >= 5 } => "Limite de empréstimos atingido para professor",
            Visitante => "Visitantes não podem realizar empréstimos",
            _ => "Usuário não classificado"
        };

    public static void Main()
    {
        var aluno = new Aluno
        {
            Nome = "Maria Silva",
            Matricula = "20240210",
            QuantidadeEmprestimosAtivos = 2
        };

        var professor = new Professor
        {
            Nome = "Carlos Mendes",
            Departamento = "Engenharia",
            QuantidadeEmprestimosAtivos = 5
        };

        var visitante = new Visitante
        {
            Nome = "Ana Costa",
            Documento = "12345678900",
            QuantidadeEmprestimosAtivos = 1
        };

        Console.WriteLine($"Aluno: {VerificarEmprestimo(aluno)}");
        Console.WriteLine($"Professor: {VerificarEmprestimo(professor)}");
        Console.WriteLine($"Visitante: {VerificarEmprestimo(visitante)}");
        Console.WriteLine($"Nulo: {VerificarEmprestimo(null)}");
        Console.WriteLine($"Sem classificação: {VerificarEmprestimo(new DateTime())}");
    }
}
