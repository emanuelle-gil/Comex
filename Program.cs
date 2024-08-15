using Comex.Modelos;
using Comex.Menus;
//https://fakestoreapi.com/products

string boasVindas = "Boas vindas ao Comex!!";
List<Produto> produtos = new List<Produto>();
List<Cliente> clientes = new List<Cliente>();
List<Pedido> pedidos = new List<Pedido>();

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuCriarProdutos());
opcoes.Add(2, new MenuCriarPedido());
opcoes.Add(3, new MenuCriarCliente());
opcoes.Add(4, new MenuListarProdutos());
opcoes.Add(5, new MenuListaPedido());
opcoes.Add(6, new MenuListarCliente());
opcoes.Add(7, new MenuConsultarAPI());
opcoes.Add(8, new MenuNomesOrdenados());
opcoes.Add(9, new MenuValorOrdenado());
opcoes.Add(-1, new MenuSair());
void LogoComex()
{
    Console.WriteLine(@"
░█████╗░░█████╗░███╗░░░███╗███████╗██╗░░██╗
██╔══██╗██╔══██╗████╗░████║██╔════╝╚██╗██╔╝
██║░░╚═╝██║░░██║██╔████╔██║█████╗░░░╚███╔╝░
██║░░██╗██║░░██║██║╚██╔╝██║██╔══╝░░░██╔██╗░
╚█████╔╝╚█████╔╝██║░╚═╝░██║███████╗██╔╝╚██╗
░╚════╝░░╚════╝░╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝");
    Console.WriteLine(boasVindas);
}

async Task MenuComex()
{
    LogoComex();
    Console.WriteLine("\nDigite 1 para criar produto");
    Console.WriteLine("Digite 2 para criar pedido");
    Console.WriteLine("Digite 3 para cadastrar um cliente");
    Console.WriteLine("Digite 4 para listar produtos");
    Console.WriteLine("Digite 5 para listar pedidos");
    Console.WriteLine("Digite 6 para listar clientes");
    Console.WriteLine("Digite 7 para consultar produtos da API");
    Console.WriteLine("Digite 8 para exibir lista de produtos ordenados por nome");
    Console.WriteLine("Digite 9 para exibir lista de produtos ordenados por preço");
    Console.WriteLine("Digite -1 para sair");
    Console.Write("\nDigite a sua opção: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    if (opcoes.ContainsKey(opcaoEscolhida))
    {
        Menu menu = opcoes[opcaoEscolhida];
        if (menu is MenuConsultarAPI menuConsultarAPI)
        {
            await menuConsultarAPI.ExecutarAsync();
        }
        else if (opcaoEscolhida == 3 || opcaoEscolhida == 6)
        {
            menu.Executar(clientes);
        }
        else if (opcaoEscolhida == 2)
        {
            menu.Executar(produtos, clientes, pedidos);
        }
        else if (opcaoEscolhida == 5)
        {
            menu.Executar(pedidos);
        }
        else
        {
            menu.Executar(produtos);
        }

        if (opcaoEscolhida > 0) await MenuComex();
    }
    else
    {
        Console.WriteLine("Opção inválida, tente novamente!");
        Thread.Sleep(2000);
        Console.Clear();
        await MenuComex();
    }
}

await MenuComex();