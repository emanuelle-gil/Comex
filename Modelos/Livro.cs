using SistemaBiblioteca.Menus;
namespace SistemaBiblioteca.Modelos;
public class Livro
{
    public string? Titulo { get; set; }
    public string? Autor { get; set; }
    public string? ISBN { get; set; }
    public DateTime DataPublicacao { get; set; }
    public bool EstaEmprestado { get; set; }

    public void Emprestar()
    {
        EstaEmprestado = true;
    }
    public void Devolver()
    {
        EstaEmprestado = false;
    }
    public void ExibirInformações()
    {
        Console.WriteLine($"Titulo:{Titulo}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Data da publicação: {DataPublicacao}");
        Console.WriteLine($"Disponibilidade: {EstaEmprestado}");
    }
}