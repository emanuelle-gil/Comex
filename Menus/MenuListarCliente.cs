namespace Comex.Menus;
using Comex.Modelos;

public class MenuListarCliente : Menu
{
    public override void Executar(List<Cliente> clientes)
    {
        base.Executar(clientes);
        if (clientes.Count > 0)
        {
            Console.WriteLine("Exibindo todos os clientes registrados\n");
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine($"Nome do Cliente: {cliente.Nome}");
                Console.WriteLine($"Cpf do cliente: {cliente.CPF}\n");
            }
            Console.Write("\nDigite qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine("Nenhum cliente cadastrado, cadastre um cliente e tente novamente!");
            Console.Write("\nDigite qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
        }
    }
    
}