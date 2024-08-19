using SistemaBiblioteca.Menus;
using SistemaBiblioteca.Modelos;

Biblioteca biblioteca = new Biblioteca();

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarUsuario());
opcoes.Add(2, new MenuAdicionarLivro());
opcoes.Add(3, new MenuLivrosDisponiveis());
opcoes.Add(4, new MenuEmprestarLivro());
opcoes.Add(5, new MenuDevolverLivro());
opcoes.Add(-1, new MenuSair());
void MenuBiblioteca()
{
    Console.WriteLine("Digite 1 para registrar usuário");
    Console.WriteLine("Digite 2 para adicionar livro");
    Console.WriteLine("Digite 3 para exibir livros disponíveis");
    Console.WriteLine("Digite 4 para emprestar livro");
    Console.WriteLine("Digite 5 para devolver livro");
    Console.WriteLine("Digite -1 para sair");
    Console.Write("Digite a sua opcão: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    if(opcoes.ContainsKey(opcaoEscolhida))
    {
        Menu menu = opcoes[opcaoEscolhida];
        menu.Executar(biblioteca);
        if(opcaoEscolhida > 0) MenuBiblioteca();
    }
    else
    {
        Console.WriteLine("Opção inválida, tente novamente!");
        Thread.Sleep(2000);
        Console.Clear();
        MenuBiblioteca();
    }
}
MenuBiblioteca();
