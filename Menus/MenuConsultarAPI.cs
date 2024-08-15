using System.Runtime.CompilerServices;
using System.Text.Json;
using Comex.Modelos;

namespace Comex.Menus;

public class MenuConsultarAPI : Menu
{
    public override async Task ExecutarAsync()
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                string resposta = await client.GetStringAsync("https://fakestoreapi.com/products");
                var produtos = JsonSerializer.Deserialize<List<Produto>>(resposta)!;
                foreach (var produto in produtos)
                {
                    Console.WriteLine($"Nome: {produto.Nome}");
                    Console.WriteLine($"Descricao: {produto.Descricao}");
                    Console.WriteLine($"Valor: {produto.PrecoUnitario}\n");
                }
                Console.Write("\nDigite qualquer tecla para voltar ao menu");
                Console.ReadKey();
                Console.Clear();
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Temos um problema: {ex.Message}");
                Console.Write("\nDigite qualquer tecla para voltar ao menu");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}