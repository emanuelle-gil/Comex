using Comex.Modelos;
namespace Comex.Menus;

public class MenuCriarProdutos : Menu
{
    public override void Executar(List<Produto> produtos)
    {
            base.Executar(produtos);
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
    }
}