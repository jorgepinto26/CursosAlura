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
                Console.WriteLine("Você escolheu a opção 4 - Exibir a média de uma banda");
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

/*
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



List<string> linguagensDeProgramacao = new List<string> {"C#", "Java", "JavaScript"};
Console.WriteLine("Estou aprendendo a linguagem de programação: " + linguagensDeProgramacao[0]); // Acessando o primeiro elemento da lista, ou seja, a linguagem C#.


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