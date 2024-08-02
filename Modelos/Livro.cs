namespace Comex.Modelos;

internal class Livro : Produto, IIdentificar
{
    public Livro(string nome) : base(nome)
    {

    }
    public string Isbn { get; set; }
    public int Total_pag { get; set; }

    public string Identificar()
    {
        return $"{Nome}, {Isbn}";
    }
}