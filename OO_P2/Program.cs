Banda tyler = new Banda("Tyler");

Album IGOR = new Album("IGOR");
IGOR.Genero.Nome = "Melodic Rap";

Musica earthquake = new Musica(tyler, "Earthquake")
{
    Duracao = 180,
    Disponivel = true,
};

Musica puppet = new Musica(tyler, "Puppet")
{
    Duracao = 276,
    Disponivel = false,
};

IGOR.AdicionarMusica(earthquake);
IGOR.AdicionarMusica(puppet);

earthquake.ExibirFichaTecnica();

tyler.AdicionarAlbum(IGOR);
tyler.ExibirDiscografia();