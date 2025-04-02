//Criando um jogo que o usuário tem que adivinhar um número entre 1-100

//USando o random para pegar um número aleatorio.
Random random = new Random();

int numeroAleatorio = random.Next(1,101); //Pega um número entre esses 2 mas inclui o 1 e tira o 101

Console.WriteLine(numeroAleatorio);

Console.WriteLine("Um número entre 1 e 100 foi sorteado");
//Criando um loop com (do while) para o user tentar até acertar
do
{
    Console.Write("Qual você acha que foi número sorteado?\n==>");
    string tentativa = Console.ReadLine()!;
    int chuteNum = int.Parse(tentativa);

    if (chuteNum == numeroAleatorio)
    {
        Console.WriteLine("Parabéns você ta livre agora, TATAKAE");
        break;
    }
    else if (chuteNum > numeroAleatorio)
    {
        Console.WriteLine("O número sortido é menor");
    }
    else
    {
        Console.WriteLine("O número sortido é maior");
    }
} while (true);

