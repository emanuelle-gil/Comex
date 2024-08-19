using SistemaBiblioteca.Menus;
namespace SistemaBiblioteca.Modelos;
public class Biblioteca
{
    public List<Livro> Livros { get; set; } = new List<Livro>();
    public List<Usuario> Usuarios { get; set; } = new List<Usuario>();

    public void AdicionarLivro(Livro livro)
    {

        Livros.Add(livro);
        Console.WriteLine($"O livro {livro.Titulo} foi adicionado com sucesso!");
        Console.Write("\nDigite qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
    }
    public void RemoverLivro(Livro livro)
    {
        Livros.Remove(livro);
        Console.WriteLine($"O livro {livro.Titulo} foi removido!");
        Console.Write("\nDigite qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
    }
    public void RegistrarUsuario(Usuario usuario)
    {
        Usuarios.Add(usuario);
        Console.WriteLine($"O usuario {usuario.Nome} foi adicionado com sucesso!!");
        Console.Write("\nDigite qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
    }
    public void ExibirLivrosDisponiveis()
    {
        Console.WriteLine("Livros disponiveis:");
        foreach (var livro in Livros)
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
