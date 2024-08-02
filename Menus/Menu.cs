using Comex.Modelos;
namespace Comex.Menus;

internal class Menu
{
    public virtual void Executar(List<Produto> produtos)
    {
        Console.Clear();
    }
}