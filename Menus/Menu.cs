using Comex.Modelos;
namespace Comex.Menus;

public class Menu
{
    public virtual void Executar(List<Produto> produtos)
    {
        Console.Clear();
    }

    public virtual void Executar(List<Cliente> clientes)
    {
        Console.Clear();
    }

    public virtual void Executar(List<Produto> produtos, List<Cliente> clientes, List<Pedido> pedidos)
    {
        Console.Clear();
    }

    public virtual void Executar(List<Pedido> pedidos)
    {
        Console.Clear();
    }

    public virtual Task ExecutarAsync()
    {
        Console.Clear();
        return Task.CompletedTask;
    }
}