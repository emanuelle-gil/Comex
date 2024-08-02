namespace Comex.Modelos;

internal class Cliente : IIdentificar
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string Profissao { get; set; }
    public string Telefone { get; set; }
    public Endereco Endereco { get; set; }

    public string Identificar()
    {
        return $"{Nome}, {CPF}";
    }
}