using SistemaBiblioteca.Menus;
namespace SistemaBiblioteca.Modelos;

public class Usuario
{
    public string? Nome { get; set; }
    public string? CPF { get; set; }
    public List<Livro> LivrosEmprestados { get; set; } = new List<Livro>();

    public void EmprestarLivro(Livro livro)
    {
        livro.EstaEmprestado = true;
        LivrosEmprestados.Add(livro);
        Console.WriteLine($"O livro {livro.Titulo} foi emprestado pelo usuario {Nome} com sucesso!!");
        Console.Write("\nDigite qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
    }
    public void DevolverLivro(Livro livro)
    {
        livro.EstaEmprestado = false;
        LivrosEmprestados.Remove(livro);
        Console.WriteLine($"O livro {livro.Titulo} foi devolvido pelo usuario {Nome} com sucesso!!");
        Console.Write("\nDigite qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
    }
    public void ExibirHistoricoEmprestimos()
    {
        if (LivrosEmprestados.Count > 0)
        {
            Console.WriteLine($"Histórico de empréstimos *{Nome}*");
            foreach (var livro in LivrosEmprestados)
            {
                Console.WriteLine($"Titulo:{livro.Titulo}");
                Console.WriteLine($"Autor: {livro.Autor}");
            }
            Console.Write("\nDigite qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
        }

        else
        {
            Console.WriteLine("Nehum livro foi emprestado");
            Console.Write("\nDigite qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
