using SistemaBiblioteca.Modelos;

namespace SistemaBiblioteca.Menus;

internal class MenuSair : Menu
{
    public override void Executar(Biblioteca biblioteca)
    {
        Console.WriteLine("Tchau :)");
    }
}