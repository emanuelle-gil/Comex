namespace Comex.Modelos;

public class Pedido
{
    public Cliente Cliente { get; set; }
    public DateTime Data { get; set; }
    public List<ItemDePedido> Itens = new List<ItemDePedido>();
    public decimal Total { get; set; }

    public void AdicionarItem(ItemDePedido item)
    {
        Itens.Add(item);
    }
}