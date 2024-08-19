using SistemaBiblioteca.Modelos;
namespace SistemaBiblioteca.Menus;

internal class MenuAdicionarLivro : Menu
{
    public override void Executar(Biblioteca biblioteca)
    {
        base.Executar(biblioteca);
        Console.Write("Digite o titulo do livro que deseja adicionar: ");
        string nomeLivro = Console.ReadLine()!;
        Console.Write("Digite o nome do autor: ");
        string nomeAutor = Console.ReadLine()!;
        Console.Write("Digite o ISBN: ");
        string isbn = Console.ReadLine()!;

        Livro livro = new Livro
        {
            Titulo = nomeLivro,
            Autor = nomeAutor,
            ISBN = isbn,
            DataPublicacao = DateTime.Now,
            EstaEmprestado = false
        };
        biblioteca.AdicionarLivro(livro);
    }
}