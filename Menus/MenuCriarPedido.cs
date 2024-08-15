using Comex.Modelos;

namespace Comex.Menus;

internal class MenuCriarPedido : Menu
{
        public override void Executar(List<Produto> produtos, List<Cliente> clientes, List<Pedido> pedidos)
        {
                base.Executar(produtos, clientes, pedidos);
                Console.WriteLine("Digite o nome do cliente para criar o pedido:");
                string nomeCliente = Console.ReadLine()!;
                Cliente? clientePedido = null;

                foreach (var cliente in clientes)
                {
                        if (cliente.Nome.Equals(nomeCliente))
                        {
                                clientePedido = cliente;
                                break;
                        }
                }

                if (clientePedido != null)
                {
                        Pedido pedido = new Pedido
                        {
                                Cliente = clientePedido,
                                Data = DateTime.Now
                        };

                        while (true)
                        {
                                Console.Clear();
                                Console.WriteLine("\nLista de produtos disponíveis:");
                                if (produtos.Count > 0)
                                {
                                        foreach (var produto in produtos)
                                        {
                                                Console.WriteLine($"{produto.Nome} - Preço: {produto.PrecoUnitario}");
                                        }
                                }
                                else
                                {
                                        Console.WriteLine("Nenhum produto cadastrado, cadastre um produto e tente novamente!");
                                        Console.Write("\nDigite qualquer tecla para voltar ao menu");
                                        Console.ReadKey();
                                        Console.Clear();
                                        return;
                                }

                                Console.WriteLine("\nDigite o nome do produto que deseja adicionar ao pedido:");
                                string nomeProduto = Console.ReadLine()!;
                                Produto? produtoSelecionado = null;

                                foreach (var produto in produtos)
                                {
                                        if (produto.Nome.Equals(nomeProduto))
                                        {
                                                produtoSelecionado = produto;
                                                break;
                                        }
                                }

                                if (produtoSelecionado != null)
                                {
                                        Console.WriteLine("Digite a quantidade do produto:");
                                        int quantidade = int.Parse(Console.ReadLine()!);

                                        ItemDePedido item = new ItemDePedido
                                        {
                                                Produto = produtoSelecionado,
                                                Quantidade = quantidade,
                                                PrecoUnitario = (decimal)produtoSelecionado.PrecoUnitario
                                        };

                                        pedido.AdicionarItem(item);
                                        Console.WriteLine($"Item {produtoSelecionado.Nome} adicionado ao pedido.");
                                }
                                else
                                {
                                        Console.WriteLine("\nProduto não encontrado! Certifique-se de que o produto está cadastrado.");
                                        Console.Write("Digite qualquer tecla para voltar ao menu");
                                        Console.ReadKey();
                                        Console.Clear();
                                        return;
                                }

                                Console.WriteLine("Deseja adicionar mais itens? (s/n)");
                                string resposta = Console.ReadLine()!;
                                if (!resposta.Equals("s"))
                                {
                                        break;
                                }
                        }

                        pedido.Total = pedido.Itens.Sum(item => item.SubTotal);
                        pedidos.Add(pedido);
                        Console.WriteLine($"\nPedido criado para o cliente {clientePedido.Nome} com total de {pedido.Total:C}");
                        Console.Write("\nDigite qualquer tecla para voltar ao menu");
                        Console.ReadKey();
                        Console.Clear();
                }
                else
                {
                        Console.WriteLine("Cliente não encontrado! Certifique-se de que o cliente está cadastrado.");
                        Console.Write("\nDigite qualquer tecla para voltar ao menu");
                        Console.ReadKey();
                        Console.Clear();
                        return;
                }
        }
}
