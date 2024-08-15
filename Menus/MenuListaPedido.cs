using Comex.Modelos;

namespace Comex.Menus
{
    public class MenuListaPedido : Menu
    {
        public override void Executar(List<Pedido> pedidos)
        {
            base.Executar(pedidos);

            if (pedidos.Count == 0)
            {
                Console.WriteLine("Nenhum pedido registrado. Não é possível listar pedidos.");
                Console.Write("\nDigite qualquer tecla para voltar ao menu");
                Console.ReadKey();
                Console.Clear();
                return;
            }
            var pedidosOrdenados = pedidos.OrderBy(p => p.Cliente.Nome).ToList();

            Console.WriteLine("Lista de todos os pedidos:");

            foreach (var pedido in pedidosOrdenados)
            {
                Console.WriteLine($"\nCliente: {pedido.Cliente.Nome}");
                Console.WriteLine($"Data: {pedido.Data}");
                Console.WriteLine($"Total: {pedido.Total:C}");
                Console.Write("Itens:");
                foreach (var item in pedido.Itens)
                {
                    Console.WriteLine($"{item.Produto.Nome} (Quantidade: {item.Quantidade}, Preço Unitário: {item.PrecoUnitario:C}, Subtotal: {item.SubTotal:C})\n");
                }
            }

            Console.Write("\nDigite qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
