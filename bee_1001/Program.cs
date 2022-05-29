using Bee_1001.Exceptions;

void Apresentacao()
{
    Console.Clear();
    Console.WriteLine("Bem-vindo a calculadora");
    Thread.Sleep(2000);
}

void Opcoes()
{
    Console.Clear();
    Console.WriteLine("Escolha a opção: ");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Sair");
    Console.WriteLine("3 - Menu");

    Console.Write("Opção: ");
    int opcao;
    bool result = int.TryParse(Console.ReadLine(), out opcao);

    if (result == false)
        Opcoes();

    switch (opcao)
    {
        case 1:
            Soma();
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("Encerrado ...");
            Thread.Sleep(2000);
            Console.Clear();
            break;
        case 3:
            Opcoes();
            break;
        default:
            throw new OpcaoErradaException("Valor inválido");
    }
}

void Soma()
{
    Console.Clear();
    Console.WriteLine("Operação de soma:");
    try
    {
        Console.Write("N1: ");
        double n1 = double.Parse(Console.ReadLine());
        Console.Write("N2: ");
        double n2 = double.Parse(Console.ReadLine());

        double soma = n1 + n2;

        Console.WriteLine($"Resultado => {n1} + {n2} => {soma}");

        Console.ReadKey();
        Opcoes();
    }
    catch (OpcaoErradaException ex)
    {
        Console.WriteLine(ex.Message);        
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Houve um erro => {ex.Message}");        
    }
}


Apresentacao();
Opcoes();
