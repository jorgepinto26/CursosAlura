// O C# é uma linguagem fortimente tipada, ou seja, preciso dizer o tipo da variável no momento de declarar


string mensagemDeBoasVindas = "Bem-vindos ao Screen Sound!";
//List<string> listaDeBandas = new List<string> {"U2", "Calypso", "Mariah Carey"};

Dictionary<string, List<int>> bandasENotas = new Dictionary<string, List<int>>();
bandasENotas.Add("Linkin Park", new List<int> { 10, 9, 8 });
bandasENotas.Add("Coldplay", new List<int>());    


ExibirOpcoesDoMenu();


void ExibirMensagemDeBoasVindas() // o nome de funções se utiliza o padrão PascalCase, ou seja, cada palavra começa com letra maiúscula e não se utiliza underline.
{

    Console.WriteLine("\n" + mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    ExibirMensagemDeBoasVindas();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");//Não quebra a linha, ou seja, o cursor fica na mesma linha da mensagem.
    string opcaoEscolhida = Console.ReadLine()!;
   
    if (int.TryParse(opcaoEscolhida, out int opcaoEscolhidaInt))
    {
        switch (opcaoEscolhidaInt)
        {
            case 1:
                RegistrarBanda();
                break;
            case 2:
                MostrarTodasAsBandas();
                break;
            case 3:
                AvaliarUmaBanda();
                break;
            case 4:
                ExibirMediaDeUmaBanda();
                break;
            case -1:
                Console.WriteLine("Saindo do programa...");
                break;
            default:
                Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                break;
        }

    }
    else
    {
        Console.Clear();
        Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
        Thread.Sleep(2000);
        ExibirOpcoesDoMenu();

    }
}

void ExibirLogo()
{
    Console.Clear();
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");

}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTitulo("Registro das Bandas escolhidas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    
    if (bandasENotas.ContainsKey(nomeDaBanda))
    {
        Console.Clear();
        Console.WriteLine("Esta banda já foi registrada!");
        Thread.Sleep(2000);
        Console.WriteLine("\nRegistre outra banda!");
        Thread.Sleep(2000);
        RegistrarBanda();
    }
    else
    {
        bandasENotas.Add(nomeDaBanda, new List<int>());
        Console.Clear();
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Thread.Sleep(2000);
        ExibirOpcoesDoMenu();
    }

}

void MostrarTodasAsBandas()
{
    Console.Clear();
    ExibirTitulo("Exibindo Bandas Registradas");

    if(bandasENotas.Count == 0)
    {
        Console.WriteLine("Nenhuma banda registrada ainda! Por favor, registre uma banda para que ela apareça aqui.");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        ExibirLogo();  
        ExibirOpcoesDoMenu();   
    }
    else
    {
        foreach (string banda in bandasENotas.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
        }

        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        ExibirLogo();
        ExibirOpcoesDoMenu();
    }
}

void ExibirTitulo(string titulo)
{
    int quantidadeDeCaracteres = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeCaracteres, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo); 
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTitulo("Avaliação de Bandas");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string bandaAvaliada = Console.ReadLine()!;

    if (!bandasENotas.ContainsKey(bandaAvaliada))
    {
        Console.WriteLine("Esta banda não foi registrada ainda! Por favor, registre a banda antes de avaliá-la.");
        Console.WriteLine("Deseja registrar a banda agora? (S/N)");

        string resposta = Console.ReadLine()!;

        if (resposta == "S")
        {
            RegistrarBanda();
        }
        else if(resposta == "N") 
        {
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
        else
        {
            Console.WriteLine("Resposta inválida. Retornando ao menu principal...");
            Thread.Sleep(2000);
            ExibirOpcoesDoMenu();

        }

    }
    else
    {
        Console.Write($"\nDigite a nota que deseja dar para a banda {bandaAvaliada}: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasENotas[bandaAvaliada].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi atribuída a banda {bandaAvaliada} com sucesso!");
        Thread.Sleep(5000);
        ExibirOpcoesDoMenu();
    }
}

void ExibirMediaDeUmaBanda()
{
    Console.Clear();
    ExibirTitulo("Exibir média da banda");
    Console.Write("Digite o nome da banda que deseja ver a média: ");
    string bandaEscolhida = Console.ReadLine()!;

    if (bandasENotas.ContainsKey(bandaEscolhida))
    {
        double media = bandasENotas[bandaEscolhida].Average();
        Console.WriteLine($"A média de notas da banda {bandaEscolhida} é: {media}");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine("Esta banda não foi registrada ainda! Por favor, registre a banda antes de exibir a média.");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        ExibirOpcoesDoMenu();
    }
}

//Escreva o programa aqui

/*
 

//EXERCICIO MEDIA DE VENDAS DOS CARROS MAIS RÁPIDOS****************************************************************************************************************************************************************************

Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
    { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
    { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
    { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
    { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
    { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
};

MenuPrincipal();

void MenuPrincipal()
{
    Console.Clear();
    Console.WriteLine("***************************************");
    Console.WriteLine("Média de vendas dos carros mais rápidos");
    Console.WriteLine("***************************************\n");
    Console.Write("Digite o modelo do veículo: ");
    string modeloDoVeiculo = Console.ReadLine()!;
    double mediaDasVendas = ExibirMediaDeVendas(modeloDoVeiculo);
    Console.WriteLine($"A média de vendas do modelo {modeloDoVeiculo} é: {mediaDasVendas}");


}

double ExibirMediaDeVendas(string modelo)
{
    double mediaDeVendas = 0;
    if (vendasCarros.ContainsKey(modelo))
    {
        foreach (var venda in vendasCarros[modelo])
        {
            mediaDeVendas = mediaDeVendas + venda;
        }
    }
    else
    {
        Console.WriteLine("Modelo de veículo não encontrado. Por favor, digite um modelo válido.");
        Thread.Sleep(3000);
        Console.WriteLine("Retornando ao menu principal...");
        Thread.Sleep(2000);
        MenuPrincipal();

    }
    return mediaDeVendas = mediaDeVendas / vendasCarros[modelo].Count;
}




//EXERCICIO LOGIN E SENHA****************************************************************************************************************************************************************************

Dictionary<string, string> usuarioESenha = new Dictionary<string, string> 
{
    { "Jorge", "12345" },
    {"Maria", "54321"},
    {"Sergio", "98765"},
    {"Letícia", "56789"},
    {"Leonardo", "13579"} 
};

ExibirMenu();

void ExibirMenu()
{
    Console.Clear();
    ExibirTitulo("Sistema de Login");
    Console.Write("Digite o nome de usuário: ");
    string usuario = Console.ReadLine()!;
    Console.Write("Digite a senha: ");
    string senha = Console.ReadLine()!;
    if (usuarioESenha.ContainsKey(usuario) && usuarioESenha[usuario] == senha)
    {
        Console.WriteLine("\nLogin bem-sucedido! Bem-vindo, " + usuario + "!");
    }
    else
    {
        Console.WriteLine("\nLogin falhou! Nome de usuário ou senha incorretos.");
    }
}

void ExibirTitulo(string titulo)
{
    int asteriscos = titulo.Length;
    string linhaDeAsteriscos = string.Empty.PadLeft(asteriscos, '*');
    Console.WriteLine(linhaDeAsteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(linhaDeAsteriscos + "\n");
}

//EXERCICIO QUIZ****************************************************************************************************************************************************************************

Dictionary<string, string> perguntasERespostas = new Dictionary<string, string>
{
    {"Qual é a capital da França?", "Paris"},
    {"Qual é o maior planeta do sistema solar?", "Júpiter"},
    {"Quem pintou a Mona Lisa?", "Leonardo da Vinci"},
    {"Qual é a fórmula química da água?", "H2O"},
    {"Quem escreveu 'Dom Quixote'?", "Miguel de Cervantes"}
};

ExibirMenu();

void ExibirMenu()
{
    Console.Clear();
    ExibirTitulo("Quiz do Jorge");

    foreach (var pergunta in perguntasERespostas.Keys)
    {
        Console.WriteLine(pergunta);
        string respostaDoUsuario = Console.ReadLine()!;
        //if (respostaDoUsuario.Equals(perguntasERespostas[pergunta], StringComparison.OrdinalIgnoreCase))
        if (perguntasERespostas[pergunta].Equals(respostaDoUsuario, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Resposta correta!");
        }
        else
        {
            Console.WriteLine($"Resposta incorreta! A resposta correta é: {perguntasERespostas[pergunta]}");
        }
        Console.WriteLine();
    }
}

void ExibirTitulo(string titulo)
{
    int asteriscos = titulo.Length;
    string linhaDeAsteriscos = string.Empty.PadLeft(asteriscos, '*');
    Console.WriteLine(linhaDeAsteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(linhaDeAsteriscos + "\n");
}


//CONSIDERAÇÕES SOBRE DICIONÁRIOS****************************************************************************************************************************************************************************

 Declaração do dicionário: Dictionary<string, int> nomeDoDicionario = new Dictionary<string, int>(); Aqui escolhi para o tipo da chave string, e para o tipo do valor int, ou seja, o dicionário irá armazenar uma chave do tipo string e um valor do tipo inteiro.
 Inserir uma chave no dicionário: nomeDoDicionario.Add("chave", valor); Aqui estou utilizando o método Add para inserir uma chave e um valor no dicionário. A chave é "chave" e o valor é valor, que deve ser do tipo inteiro, conforme a declaração do dicionário.
 Inserir um valor no dicionário: nomeDoDicionario["chave"] = valor; Aqui estou utilizando a sintaxe de indexação para inserir um valor no dicionário. A chave é "chave" e o valor é valor, que deve ser do tipo inteiro, conforme a declaração do dicionário. Se a chave "chave" já existir no dicionário, o valor associado a essa chave será atualizado para o novo valor fornecido.
 Acessar um valor no dicionário: int valor = nomeDoDicionario["chave"]; Aqui estou utilizando a sintaxe de indexação para acessar o valor associado à chave "chave" no dicionário. O valor será armazenado na variável valor, que deve ser do tipo inteiro, conforme a declaração do dicionário. Se a chave "chave" não existir no dicionário, uma exceção será lançada.
 Acessar uma chave no meio do dicionário não é possível, pois os dicionários não possuem uma ordem definida para as chaves. Para acessar um valor específico, é necessário conhecer a chave associada a esse valor. Se você deseja acessar um valor específico, pode utilizar o método TryGetValue para verificar se a chave existe no dicionário e obter o valor associado a essa chave de forma segura, sem lançar uma exceção caso a chave não exista.
 Acessar a primeira chave do dicionário: string primeiraChave = nomeDoDicionario.Keys.First(); Aqui estou utilizando a propriedade Keys do dicionário para obter uma coleção de todas as chaves presentes no dicionário, e em seguida, utilizando o método First() para acessar a primeira chave dessa coleção. A chave será armazenada na variável primeiraChave, que deve ser do tipo string, conforme a declaração do dicionário. Vale ressaltar que a ordem das chaves em um dicionário não é garantida, portanto, a "primeira" chave pode variar dependendo da implementação do dicionário e da ordem de inserção das chaves.


//EXERCICIO ESTOQUE DE PRODUTOS****************************************************************************************************************************************************************************

Dictionary<string, int> produto = new Dictionary<string, int>();
ExibirMenu();

void ExibirMenu()
{

    Console.Clear();
    ExibirTitulo("Bem-vindo ao estoque de produtos");
    Console.WriteLine("1 - Registrar um produto");
    Console.WriteLine("2 - Registrar a quantidade de um produto");
    Console.WriteLine("3 - Exibir o estoque de um produto");
    Console.WriteLine("4 - Sair");
    Console.Write("Digite uma opção para continuar: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);
    switch (opcaoEscolhida)
    {
        case 1:
            RegistrarProduto();
            break;
        case 2:
            RegistrarQuantidade();
            break;
        case 3:
            ExibirProduto();
            break;
        case 4:
            Console.WriteLine("Saindo do programa...");
            break;
        default:
            Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
            break;
    }
}

void RegistrarProduto()
{
   Console.Clear();
   ExibirTitulo("Registrar um produto");
   Console.WriteLine("Escreva o nome do produto que deseja registrar: ");
   string nomeDoProduto = Console.ReadLine()!;
   produto.Add(nomeDoProduto, 0);
   Console.WriteLine("O produto " + nomeDoProduto + " foi registrado com sucesso!");
   Thread.Sleep(5000);
   ExibirMenu();
}

void RegistrarQuantidade()
{
    Console.Clear();
    ExibirTitulo("Registrar a quantidade de um produto");
    Console.WriteLine("Escreva o nome do produto: ");
    string nomeDoProduto = Console.ReadLine()!;
    Console.WriteLine("Escreva a quantidade do produto: ");
    int quantidadeDoProduto = int.Parse(Console.ReadLine()!);
    produto[nomeDoProduto] = quantidadeDoProduto;
    Console.WriteLine($"A quantidade do produto {nomeDoProduto} foi registrada com sucesso!");
    Thread.Sleep(5000);
    ExibirMenu();

}

void ExibirProduto()
{
    Console.Clear();
    ExibirTitulo("Exibir estoque de um produto");
    Console.WriteLine("Digitr o nome do produto: ");
    string nomeDoProduto = Console.ReadLine()!;
    if (!produto.ContainsKey(nomeDoProduto))
    {
        Console.WriteLine("Este produto não foi registrado ainda! Por favor, registre o produto antes de exibir o estoque.");
        Console.WriteLine("Deseja registrar o produto agora? (S/N)");
        string resposta = Console.ReadLine()!;
        if (resposta == "S")
        {
            RegistrarProduto();
        }
        else if(resposta == "N") 
        {
            Console.Clear();
            ExibirMenu();
        }
        else
        {
            Console.WriteLine("Resposta inválida. Retornando ao menu principal...");
            Thread.Sleep(2000);
            ExibirMenu();
        }
    }
    Console.WriteLine($"O produto {nomeDoProduto} possui {produto[nomeDoProduto]} unidades em estoque");
    Thread.Sleep(5000);
    ExibirMenu();
}

void ExibirTitulo(string titulo)
{
    int quantidadeDeCaracteres = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeCaracteres, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

//EXERCICIO CALCULO DE MEDIA DE NOTAS DOS ALUNOS****************************************************************************************************************************************************************************

Dictionary<string, List<int>> alunoENotas = new Dictionary<string, List<int>> { { "Jerubalex", new List<int> { 10, 8, 8, 10, 7 } } };

Console.Write($"Média do {alunoENotas.Keys.First()}: ");
double media = CalculoDaMedia(alunoENotas);
Console.Write(media);
double CalculoDaMedia(Dictionary<string, List<int>> aluno)
{
    string nomeDoAluno = aluno.Keys.First();
    double mediaDb = 0;
    for(int i = 0; i < aluno[aluno.Keys.First()].Count; i++)
    {
        mediaDb = mediaDb + aluno[nomeDoAluno][i];
    }
    return mediaDb / aluno[aluno.Keys.First()].Count;
};

Console.Write("Informe a média final do aluno: ");
string notaMedia = Console.ReadLine()!; // O operador ! é utilizado para indicar que a variável não será nula, ou seja, o valor de notaMedia não será nulo.
int notaMediaInt = int.Parse(notaMedia);

if (notaMediaInt >= 5)
{
    Console.WriteLine("Nota suficiente para aprovação");
}
else
{
    Console.WriteLine("Nota insuficiente para aprovação");
}

//EXERCICIO LISTA DE LINGUAGENS DE PROGRAMAÇÃO****************************************************************************************************************************************************************************

List<string> linguagensDeProgramacao = new List<string> {"C#", "Java", "JavaScript"};
Console.WriteLine("Estou aprendendo a linguagem de programação: " + linguagensDeProgramacao[0]); // Acessando o primeiro elemento da lista, ou seja, a linguagem C#.

//EXERCICIO NUMERO SECRETO****************************************************************************************************************************************************************************

List<string> nomes = new List<string> { "Jorge", "Verônica", "Sergio", "Letícia", "Leonardo" };

Console.Write("Digite um número: ");
string numero = Console.ReadLine()!;
int numeroInt = int.Parse(numero);

if (numeroInt >= 0 && numeroInt < nomes.Count)
{
    Console.WriteLine($"Você escolheu o número {numeroInt}: " + nomes[numeroInt]);
} 
else
{
    Console.WriteLine("Número inválido. Por favor, escolha um número entre 0 e " + (nomes.Count - 1));
}

//EXERCICIO QUATRO OPERAÇÕES FUNDAMENTAIS****************************************************************************************************************************************************************************

Random rnd = new Random();
double a = Math.Round(rnd.NextDouble()*100,2);
double b = Math.Round(rnd.NextDouble()*100,2);

quatroOperacoes(a, b);

void quatroOperacoes(double a, double b)
{
    Console.WriteLine("******************************************");
    Console.WriteLine("As quatro operações fundamentais com a e b");
    Console.WriteLine("******************************************\n");
    Console.WriteLine($"a = {a}");
    Console.WriteLine($"b = {b}");
    Console.WriteLine($"Adição: {Math.Round(a + b, 2)}");
    Console.WriteLine($"Subtração: {Math.Round(a - b, 2)}");
    if(b == 0)
    {
        Console.WriteLine("Divisão: Não é possível dividir por zero!");
    }
    else
    {
        Console.WriteLine($"Divisão: {Math.Round(a / b, 2)}");
    }
    
    Console.WriteLine($"Multiplicação: {Math.Round(a * b, 2)}");

}

//EXERCICIO REGISTRO DE BANDAS FAVORITAS****************************************************************************************************************************************************************************

List<string> minhasBandas = new List<string>();

Cabecalho();

while(true)
{
    minhasBandas.Add(Console.ReadLine()!);

    Console.WriteLine("Banda registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    Cabecalho();

    if(Console.KeyAvailable)
    {
        var key = Console.ReadKey(true);

        if(key.Key == ConsoleKey.Q)
        {
            Console.WriteLine("Encerrando cadastro de bandas....");
            Thread.Sleep(2000);
            MostrarBandas();
            break;
        }
    }

}

void MostrarBandas()
{
    Console.Clear();
    Console.WriteLine("*********************");
    Console.WriteLine("Suas bandas favoritas");
    Console.WriteLine("*********************\n");

    foreach (var band in minhasBandas)
    {
        Console.WriteLine($"Banda {band}");
    }

    Thread.Sleep(5000);
}
        
void Cabecalho()
{
    Console.WriteLine("****************************");
    Console.WriteLine("Registro de bandas favoritas");
    Console.WriteLine("****************************\n");
    Console.Write("Digite o nome de uma banda para registro: ");
}

//EXERCICIO SOMA DOS ELEMENTOS DE UMA LISTA****************************************************************************************************************************************************************************

List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int soma = 0;

Cabecalho();

Console.Write("Lista: ");

for (int i = 0; i < numeros.Count; i++ )
{
    Console.Write($"{numeros[i]} ");
    soma = soma + numeros[i];
}

Console.WriteLine($"\nSoma dos elementos da lista: {soma}");
void Cabecalho()
{
    Console.WriteLine("***************************");
    Console.WriteLine("Soma dos elementos da lista");
    Console.WriteLine("***************************\n");
}


//EXERCICIO EXIBIÇÃO DE NÚMEROS PARES DE UMA LISTA****************************************************************************************************************************************************************************

List<int> numeros = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Console.WriteLine("Exibindo os números da lista:\n");

for (int i = 0; i < numeros.Count; i++)
{
    Console.Write($"{numeros[i]} ");  
    if(i == numeros.Count - 1)  
    {
        Console.WriteLine("\n");
    }
}

Console.WriteLine("Utilizando o for para exibir os números pares da lista:\n");
for (int i = 0; i < numeros.Count; i++)
{
    if (numeros[i]%2 == 0)
    {
        Console.WriteLine($"Número par: {numeros[i]}");
    }

    if(i == numeros.Count - 1)
    {
        Console.WriteLine("\n");
    }
}

Console.WriteLine("Utilizando o foreach para exibir os números pares da lista:\n");
foreach (var numero in numeros)
{
    if(numero%2 == 0)
    {
        Console.WriteLine($"Número par: {numero}");
    }
}

*/