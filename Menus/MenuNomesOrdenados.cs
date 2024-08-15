using Comex.Modelos;
using Microsoft.VisualBasic;
namespace Comex.Menus;

internal class MenuNomesOrdenados : Menu
{
    public override void Executar(List<Produto> produtos)
    {
        base.Executar(produtos);
        if (produtos.Count > 0)
        {
            var nomesOrdenados = produtos.OrderBy(produto => produto.Nome).Select(produto => produto.Nome).ToList();
            Console.WriteLine("Lista de produtos ordenados por nome:");
            foreach (var produto in nomesOrdenados)
            {
                Console.WriteLine($"- {produto}");
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
