namespace Comex.Menus;
using Comex.Modelos;

internal class MenuListarProdutos : Menu
{
    public override void Executar(List<Produto> produtos)
    {
        base.Executar(produtos);
        if (produtos.Count > 0)
        {
            Console.WriteLine("Exibindo todos os produtos registrados\n");
            foreach (Produto produto in produtos)
            {
                Console.WriteLine($"Produto: {produto.Nome}");
                Console.WriteLine($"Descricao: {produto.Descricao}");
                Console.WriteLine($"Valor Unitario: {produto.PrecoUnitario}");
                Console.WriteLine($"Quantidade: {produto.Quantidade}\n");
            }
            Console.Write("\nDigite qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine("Nenhum produto cadastrado, cadastre um produto e tente novamente!");
            Console.Write("\nDigite qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
        }
    }
    
}