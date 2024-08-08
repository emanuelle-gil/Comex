using Comex.Modelos;
using Comex.Menus;
//https://fakestoreapi.com/products

string boasVindas = "Boas vindas ao Comex!!";
List<Produto> produtos = new List<Produto>();
Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuCriarProdutos());
opcoes.Add(2, new MenuListarProdutos());
opcoes.Add(3, new MenuConsultarAPI());
opcoes.Add(4, new MenuNomesOrdenados());
opcoes.Add(5, new MenuValorOrdenado());
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
    Console.WriteLine("Digite 2 para listar produtos");
    Console.WriteLine("Digite 3 para consultar produtos da API");
    Console.WriteLine("Digite 4 para exibir lista de produtos ordenados por nome");
    Console.WriteLine("Digite 5 para exibir lista de produtos ordenados por preço");
    Console.WriteLine("Digite -1 para sair");
    Console.Write("\nDigite a sua opção: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);
    if(opcoes.ContainsKey(opcaoEscolhida))
    {
        Menu menu = opcoes[opcaoEscolhida];
        if (menu is MenuConsultarAPI menuConsultarAPI)
        {
            await menuConsultarAPI.ExecutarAsync();
        }
        else
        {
            menu.Executar(produtos);
        }
        
        if(opcaoEscolhida > 0) await MenuComex();
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