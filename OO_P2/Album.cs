class Album
{
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public Genero Genero = new Genero();

    public Album(string nome)
    {
        Nome = nome;
    }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}");
        foreach (var musica in musicas)
        {
            Console.WriteLine(musica.Nome);
        }
        Console.WriteLine($"Duração total do álbum: {DuracaoTotal}");
        Console.WriteLine($"Gênero do álbum: {Genero.Nome}");
    }
}