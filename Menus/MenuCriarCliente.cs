using Comex.Modelos;

namespace Comex.Menus;

internal class MenuCriarCliente : Menu
{
        public override void Executar(List<Cliente> clientes)
        {
            base.Executar(clientes);
            Console.WriteLine("Registro de clientes");
            Console.Write("\nDigite o nome do cliente que você deseja adicionar: ");
            string nomeCliente = Console.ReadLine()!;

            Console.Write("Digite o cpf do cliente que você deseja adicionar: ");
            string cpfCliente = Console.ReadLine()!;

            Console.Write("Digite a profissao do cliente: ");
            string profissaoCliente = Console.ReadLine()!;

            Console.Write("Digite o telefone do cliente: ");
            string telCliente = Console.ReadLine()!;

            Console.WriteLine("Digite o endereço do cliente: ");
            Console.Write("Bairro: ");
            string bairro = Console.ReadLine()!;
            Console.Write("Cidade: ");
            string cidade = Console.ReadLine()!;
            Console.Write("Complemento: ");
            string complemento = Console.ReadLine()!;
            Console.Write("Estado: ");
            string estado = Console.ReadLine()!;
            Console.Write("Rua: ");
            string rua = Console.ReadLine()!;
            Console.Write("Numero: ");
            string numero = Console.ReadLine()!;

            Cliente cliente = new Cliente();
            cliente.Nome = nomeCliente;
            cliente.CPF = cpfCliente;
            cliente.Profissao = profissaoCliente;
            cliente.Telefone = telCliente;
            cliente.Endereco = new Endereco
            {
                Bairro = bairro,
                Cidade = cidade,
                Complemento = complemento,
                Estado = estado,
                Rua = rua,
                Numero = numero
            };

            clientes.Add(cliente);
            Console.WriteLine($"\nO cliente {nomeCliente} foi registrado com sucesso!");
            Thread.Sleep(2000);
            Console.Clear();
        }
}