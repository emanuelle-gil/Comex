using Comex.Modelos;
namespace Comex.Menus;

public class Menu
{
    public virtual void Executar(List<Produto> produtos)
    {
        Console.Clear();
    }

    public virtual Task ExecutarAsync()
    {
        Console.Clear();
        return Task.CompletedTask;
    }
}