// Screen Sound

//C# Linguagem fortemente Tipada

//Criando uma var do tipo string (Todas as var devem sempre serem criadas em camelCase)
string mensagemBoasVindas = "Boas Vindas ao Freeify";

//Criando Funções (Devem sempre serem criadas em PascalCase)
//Quando não se tem retorno é void
void ExibirMensagemBoasVindas()
{
    // O @ serve para mostrar como string deve ficar literal no código é o "Verbatim Literal"
    Console.WriteLine(@"
███████╗██████╗░███████╗███████╗██╗███████╗██╗░░░██╗
██╔════╝██╔══██╗██╔════╝██╔════╝██║██╔════╝╚██╗░██╔╝
█████╗░░██████╔╝█████╗░░█████╗░░██║█████╗░░░╚████╔╝░
██╔══╝░░██╔══██╗██╔══╝░░██╔══╝░░██║██╔══╝░░░░╚██╔╝░░
██║░░░░░██║░░██║███████╗███████╗██║██║░░░░░░░░██║░░░
╚═╝░░░░░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝╚═╝░░░░░░░░╚═╝░░░");
    Console.WriteLine(mensagemBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\n[1] - Registrar uma banda");
    Console.WriteLine("[2] - Mostrar todas as bandas");
    Console.WriteLine("[3] - Avaliar uma banda");
    Console.WriteLine("[4] - Exibir a média de uma banda");
    Console.WriteLine("[5] - Sair");

    //Diferança do WriteLine para o Write é que o Write pula linha ja só o Write não
    Console.Write("\nDigite a sua opção escolhida:\n==> ");

    // O ReadLine pega a resposta do user | O "!" Serve para evitar que receba um valor null
    //Recebendo
    string opcaoEscolhida = Console.ReadLine()!;

    //Criando uma var do tipo inteiro
    //O Parse que o int tem, tenta transformar uma string em int
    int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);

    /* Estrutura básica de IF/ELSE
    if (opcaoEscolhidaNum == 1)
    {
        Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
    }else if (opcaoEscolhidaNum == 2)
    {
        Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
    }
    */

    //Usando um switch case no lugar do if/else
    switch (opcaoEscolhidaNum)
    {
        case 1: Console.WriteLine("Você digitou a opção " + opcaoEscolhida); 
            break;
        case 2: Console.WriteLine("Você digitou a opção " + opcaoEscolhida); 
            break;
        case 3: Console.WriteLine("Você digitou a opção " + opcaoEscolhida); 
            break;
        case 4: Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
            break;
        case 5: Console.WriteLine("Bye bye Rukia-chan ;)"); 
            break;

        // O default é a opção padrão caso nenhuma das opção anteriores não forem escolhidas
        default: Console.WriteLine("Opção Inválida");
            break;
    }
}

ExibirMensagemBoasVindas();
ExibirOpcoesDoMenu();