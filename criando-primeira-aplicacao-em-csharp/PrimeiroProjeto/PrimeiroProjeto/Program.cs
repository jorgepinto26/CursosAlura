// O C# é uma linguagem fortimente tipada, ou seja, preciso dizer o tipo da variável no momento de declarar

string mensagemDeBoasVindas = "Bem-vindos ao Screen Sound";
void ExibirMensagemDeBoasVindas() // o nome de funções se utiliza o padrão PascalCase, ou seja, cada palavra começa com letra maiúscula e não se utiliza underline.
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
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");//Não quebra a linha, ou seja, o cursor fica na mesma linha da mensagem.
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaInt = int.Parse(opcaoEscolhida); // Convertendo a string para inteiro
  
    switch (opcaoEscolhidaInt)
        {
            case 1:
                Console.WriteLine("Você escolheu a opção 1 - Registrar uma banda");
                break;
            case 2:
                Console.WriteLine("Você escolheu a opção 2 - Mostrar todas as bandas");
                break;
            case 3:
                Console.WriteLine("Você escolheu a opção 3 - Avaliar uma banda");
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

ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();

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

*/
