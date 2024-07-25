string boasVindas = "Boas vindas ao Comex!!";
List<string> produtos = new List<string>();

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
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaOk = int.Parse(opcaoEscolhida);

    switch(opcaoEscolhidaOk)
    {
        case 1: CriarProduto();
            break;
        case 2: ListarProdutos();
            break;
        case -1: Console.WriteLine("Tchau :)");
            break;
        default: Console.WriteLine("Opção inválida, tente novamente!");
                 Thread.Sleep(2000);
                 Console.Clear();
                 MenuComex();
            break;
    }
}

void CriarProduto()
{
    Console.Clear();
    Console.WriteLine("Registro de produtos");
    Console.Write("\nDigite o nome do produto que você deseja adicionar: ");
    string novoProduto = Console.ReadLine()!;
    produtos.Add(novoProduto);
    Console.WriteLine($"\nO produto {novoProduto} foi registrado com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    MenuComex();

}

void ListarProdutos()
{
    Console.Clear();
    Console.WriteLine("Exibindo todos os produtos registrados\n");
    foreach(string produto in produtos)
    {
        Console.WriteLine($"Produto: {produto}");
    }
    Console.Write("\nDigite qualquer tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    MenuComex();
}

MenuComex();
