using SistemaBiblioteca.Modelos;
using System.Linq;

namespace SistemaBiblioteca.Menus;

internal class MenuRegistrarUsuario : Menu
{
    public override void Executar(Biblioteca biblioteca)
    {
        base.Executar(biblioteca);
        Console.Write("Digite o nome do usuario: ");
        string nomeUsuario = Console.ReadLine()!;
        Console.Write("Digite o CPF: ");
        string cpf = Console.ReadLine()!;

        if (biblioteca.Usuarios.Any(u => u.CPF == cpf))
        {
            Console.WriteLine("CPF ja cadastrado!");
            Console.Write("\nDigite qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
            return;
        }

        Usuario usuario = new Usuario
        {
            Nome = nomeUsuario,
            CPF = cpf
        };

        biblioteca.RegistrarUsuario(usuario);

    }
}
