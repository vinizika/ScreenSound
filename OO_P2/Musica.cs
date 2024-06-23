class Musica
{
    public string nome, artista;
    public int duracao;
    public bool disponivel;

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");
        if( disponivel)
        {
            Console.WriteLine($"Disponível no seu plano");
        }
        else
        {
            Console.WriteLine($"Não disponível no seu plano");
        }
    }
}