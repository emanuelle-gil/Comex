namespace Comex.Modelos;

public class ItemDePedido
{
    public Produto Produto { get; set; }
    public int Quantidade { get; set; }
    public decimal PrecoUnitario { get; set; }
    public decimal SubTotal => Quantidade*PrecoUnitario;
}
