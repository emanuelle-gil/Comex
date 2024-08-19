using SistemaBiblioteca.Modelos;
using System.ComponentModel;

namespace SistemaBiblioteca.Menus;

internal class MenuEmprestarLivro : Menu
{
    public override void Executar(Biblioteca biblioteca)
    {
        base.Executar(biblioteca);
        Console.Write("Digite o seu nome: ");
        string nomeUsuario = Console.ReadLine()!;
        Usuario usuarioNome = null;
        foreach (var usuario in biblioteca.Usuarios)
        {
            if (usuario.Nome.Equals(nomeUsuario))
            {
                usuarioNome = usuario;
                break;
            }
        }

        if (usuarioNome != null)
        {
            if (usuarioNome.LivrosEmprestados.Count >= 3)
            {
                Console.WriteLine("Você já possui 3 livros emprestados. Não é possível emprestar mais livros.");
                Console.Write("\nDigite qualquer tecla para voltar ao menu");
                Console.ReadKey();
                Console.Clear();
                return;
            }
            Console.Clear();
            Console.WriteLine("Livros disponiveis:");
            foreach (var livro in biblioteca.Livros)
            {
                if (livro.EstaEmprestado == false)
                {
                    Console.WriteLine($"Titulo:{livro.Titulo}");
                    Console.WriteLine($"Autor: {livro.Autor}");
                    Console.WriteLine($"ISBN: {livro.ISBN}");
                    Console.WriteLine("*****************************");
                }
            }
            Console.Write("\nDigite o nome do livro que deseja emprestrar: ");
            string nomeLivro = Console.ReadLine()!;
            Livro livroEscolhido = null;

            foreach (var livro in biblioteca.Livros)
            {
                if (livro.Titulo.Equals(nomeLivro))
                {
                    livroEscolhido = livro;
                    break;
                }

            }
            if (livroEscolhido != null)
            {
                usuarioNome.EmprestarLivro(livroEscolhido);
            }
            else
            {
                Console.WriteLine("Esse livro não está entre os disponiveis");
                Console.Write("\nDigite qualquer tecla para voltar ao menu");
                Console.ReadKey();
                Console.Clear();
            }
        }
        else
        {
            Console.WriteLine("O usuario inserido não foi encontrado");
            Console.Write("\nDigite qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Console.Clear();

        }
    }
}