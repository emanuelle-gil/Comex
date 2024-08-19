using SistemaBiblioteca.Modelos;

namespace SistemaBiblioteca.Menus;

internal class MenuLivrosDisponiveis : Menu
{
    public override void Executar(Biblioteca biblioteca)
    {
        base.Executar(biblioteca);
        Console.WriteLine("Livros disponiveis:");
        foreach (var livro in biblioteca.Livros)
        {
            if (livro.EstaEmprestado == false)
            {
                Console.WriteLine($"\nTitulo:{livro.Titulo}");
                Console.WriteLine($"Autor: {livro.Autor}");
                Console.WriteLine($"ISBN: {livro.ISBN}");
            }
        }
        Console.Write("\nDigite qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
    }
}