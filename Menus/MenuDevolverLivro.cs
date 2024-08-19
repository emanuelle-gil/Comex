using SistemaBiblioteca.Modelos;
using System.Globalization;

namespace SistemaBiblioteca.Menus;
internal class MenuDevolverLivro : Menu
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
            Console.Write("Digite o nome do livro que deseja remover: ");
            string nomeLivro = Console.ReadLine()!;
            Livro livroRemover = null;
            foreach (var livro in biblioteca.Livros)
            {
                if (livro.Titulo.Equals(nomeLivro))
                {
                    livroRemover = livro;
                    break;
                }
            }
            if (livroRemover != null)
            {
                usuarioNome.DevolverLivro(livroRemover);
            }
            else
            {
                Console.WriteLine("O livro inserido não foi encontrado");
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
