int numeroSorteado = GerarNumeroAleatorio();

Console.WriteLine("Bem-vindo ao jogo do número secreto!");
Console.Write("\nTente adivinhar o número entre 1 e 100: ");

int chuteInt = DigiteUmNumero();

VerificarChute(chuteInt, numeroSorteado);


int GerarNumeroAleatorio()
{
    Random numeroAleatorio = new Random();
    int numero = numeroAleatorio.Next(1, 101); // Gera um número aleatório entre 1 e 100
    return numero;
}
void VerificarChute(int chuteInt, int numeroSorteado)
{
    do
    {
        if (chuteInt < 1 || chuteInt > 100)
        {
            Console.WriteLine("Número inválido, digite um número entre 1 e 100.");
            TenteNovamente();
        }
        else
        {
            if (chuteInt < numeroSorteado)
            {
                Console.WriteLine("O número secreto é maior");
                TenteNovamente();
            }
            else
            {
                Console.WriteLine("O número secreto é menor");
                TenteNovamente();
            }
        }
       chuteInt = DigiteUmNumero();
    } while (chuteInt != numeroSorteado);

    Console.WriteLine("Parabéns! Você acertou o número secreto!");
}

int DigiteUmNumero()
{
    string chute = Console.ReadLine()!;
    chuteInt = int.Parse(chute);
    return chuteInt;
}

void TenteNovamente()
{
    Console.Write("Tente novamente: ");
}