//Desafio Cap 1
string curso = "C#: Criando sua primeira aplicação";
string nome = "Erick";
string sobrenome = "Alves";

Console.WriteLine("Estudando: " + curso + "\nAluno: " + nome + "\nSobrenome: " + sobrenome + "\nCom os intrutores Daniel Portugal e Gui Lima");
Console.WriteLine("***********************************************");


//Praticando Cap 2
Console.WriteLine("Qual é o seu nome?");
string nome2 = Console.ReadLine()!;
Console.WriteLine("Olá, " + nome2 + "!");

// Ambos os métodos de baixo são outras maneiras de escrever uma string com algum valor dentro de si 
Console.WriteLine($"Olá, {nome2}!");
Console.WriteLine("Olá, {0}!", nome2);

//Desafio Cap 2
Console.WriteLine("Digite qualquer número");
string notaString = Console.ReadLine()!;
int notaMedia = int.Parse(notaString);

if  (notaMedia >= 5)
{
    Console.WriteLine("Nota suficiente para aprovação");
}
else
{
    Console.WriteLine("A nota foi insuficiente para a aprovação");
}

List<string> linguagens = new List<string>() {"C#","Java","JavaScript"};

Console.WriteLine($"Linguagem: {linguagens[0]}");

Console.WriteLine("Digite a posição desejada entre 1 e 3");
string posicao = Console.ReadLine()!;
int posicaoInt = int.Parse(posicao);

if (posicaoInt > 3 || posicaoInt < 1)
{
    Console.WriteLine("Posição invalida");
}
else
{
    int index = posicaoInt - 1;
    Console.WriteLine($"A linguagem escolhida foi: {linguagens[posicaoInt - 1]}");
}
