using Comex;
string boasVindas = "Boas vindas ao Comex!!";
List<Produto> produtos = new List<Produto>();

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

    switch(opcaoEscolhida)
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
    string nomeProduto = Console.ReadLine()!;

    Console.Write("Digite a descrição do produto que você deseja adicionar: ");
    string descricaoProduto = Console.ReadLine()!;

    Console.Write("Digite o valor unitario do produto que você deseja adicionar: ");
    double valorProduto = double.Parse(Console.ReadLine()!);

    Console.Write("Digite a quantidade do produto que você deseja adicionar: ");
    int qtdProduto = int.Parse(Console.ReadLine()!);

    Produto produto = new Produto(nomeProduto);
    produto.Nome = nomeProduto;
    produto.Descricao = descricaoProduto;
    produto.PrecoUnitario = valorProduto;
    produto.Quantidade = qtdProduto;

    produtos.Add(produto);
    Console.WriteLine($"\nO produto {nomeProduto} foi registrado com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    MenuComex();

}

void ListarProdutos()
{
    Console.Clear();
    if (produtos.Count > 0)
    {
        Console.WriteLine("Exibindo todos os produtos registrados\n");
        foreach (Produto produto in produtos)
        {
            Console.WriteLine($"Produto: {produto.Nome}");
            Console.WriteLine($"Descrição: {produto.Descricao}");
            Console.WriteLine($"Valor Unitario: {produto.PrecoUnitario}");
            Console.WriteLine($"Quantidade: {produto.Quantidade}\n");
        }
        Console.Write("\nDigite qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        MenuComex();
    }
    else
    {
        Console.WriteLine("Nenhum produto cadastrado, cadastre um produto e tente novamente!");
        Console.Write("\nDigite qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        MenuComex();
    }
}

MenuComex();