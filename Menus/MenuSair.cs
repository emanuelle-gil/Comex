namespace Comex.Menus;
using Comex.Modelos;

internal class MenuSair : Menu
{
    public override void Executar(List<Produto> produtos)
    {
        Console.WriteLine("Tchau :)");
    }
}