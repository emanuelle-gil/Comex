using Comex.Modelos;
using Comex.Menus;

string boasVindas = "Boas vindas ao Comex!!";
List<Produto> produtos = new List<Produto>();
Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuCriarProdutos());
opcoes.Add(2, new MenuListarProdutos());
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

void MenuComex()
{
    LogoComex();
    Console.WriteLine("\nDigite 1 para criar produto");
    Console.WriteLine("Digite 2 para listar produtos");
    Console.WriteLine("Digite -1 para sair");
    Console.Write("\nDigite a sua opção: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);
    if(opcoes.ContainsKey(opcaoEscolhida))
    {
        Menu menu = opcoes[opcaoEscolhida];
        menu.Executar(produtos);
        if(opcaoEscolhida > 0) MenuComex();
    }
    else
    {
        Console.WriteLine("Opção inválida, tente novamente!");
        Thread.Sleep(2000);
        Console.Clear();
        MenuComex();
    }
}

MenuComex();