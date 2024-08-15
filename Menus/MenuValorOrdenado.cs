using Comex.Modelos;
using Microsoft.VisualBasic;
namespace Comex.Menus;

internal class MenuValorOrdenado : Menu
{
    public override void Executar(List<Produto> produtos)
    {
        base.Executar(produtos);
        if (produtos.Count > 0)
        {
            var valoresOrdenados = produtos.OrderBy(produto => produto.PrecoUnitario).ToList();
            Console.WriteLine("Lista de produtos ordenados por preço:");
            foreach (var produto in valoresOrdenados)
            {
                Console.WriteLine($"{produto.Nome} - {produto.PrecoUnitario}");
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