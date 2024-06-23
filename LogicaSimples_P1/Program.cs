// Screen Sound
string mensagemDeBoasVindas = "\nBoas vindas ao Screen Sound";
//List<string> listaDasBandas = new List<string>() { "U2", "Calypso", "Beatles"};

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>(); 

bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6});
bandasRegistradas.Add("Beatles", new List<int>());

void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirMensagemDeBoasVindas();
    Console.WriteLine("\n[1] Registrar uma banda");
    Console.WriteLine("[2] Mostrar todas as bandas");
    Console.WriteLine("[3] Avaliar uma banda");
    Console.WriteLine("[4] Exibir média de uma banda");
    Console.WriteLine("[-1] Sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBandas();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: AvaliarBandas();
            break;
        case 4: ExibirMediaDaBanda();
            break;
        case -1:
            Console.WriteLine("Até logo!");
            break;
        default: Console.WriteLine("Opção inválida!");
            break;
    }
}

void RegistrarBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registrar bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");
    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda: {listaDasBandas[i]}");
    //}

    foreach(string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = "".PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarBandas()
{
    // digite a banda que deseja avaliar
    // se a banda existir no dicionario >> atribuir uma nota
    // se nao >> volta ao menu principal

    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void ExibirMediaDaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir médias de uma banda");
    Console.Write("Qual banda você deseja visualizar a média: ");
    string nomeDaBanda = Console.ReadLine()!;
    int somaDasNotas = 0;
    int quantidadeDeNotas = 0;
    foreach (string banda in bandasRegistradas.Keys) 
    { 
        if (bandasRegistradas.Keys.Contains(nomeDaBanda))
        {
            foreach (int nota in bandasRegistradas[banda])
            {
                somaDasNotas = somaDasNotas + nota;
                quantidadeDeNotas++;
            }
            double mediaDasNotas = somaDasNotas / quantidadeDeNotas;
            Console.WriteLine($"A média para a banda {nomeDaBanda} é: {mediaDasNotas}");
            break;
        }
        else
        {
            Console.WriteLine($"A banda {nomeDaBanda} não existe no banco de dados");
            break;
        }
    }
    Thread.Sleep( 2000 );
    Console.Clear();
    ExibirOpcoesDoMenu();
}

ExibirOpcoesDoMenu();