int z = 0;
do
{
    Console.WriteLine("1- Somar");
    Console.WriteLine("2- Subtrair");
    Console.WriteLine("3- Multplicar");
    Console.WriteLine("4- Dividir");
    Console.WriteLine("5- Porcentagem");
    Console.Write("Escolha uma opção:");
    z = int.Parse(Console.ReadLine());
    Console.Clear();
} while (z>5 || z<1);

Console.Write("Digite um Numero:");
int x = int.Parse(Console.ReadLine());
Console.Write("Digite o segundo numero:");
int y = int.Parse(Console.ReadLine());


while (true)
{

    if (z == 1)
    {
        Console.Clear();
        Console.WriteLine("Resultado é: {0}", x + y);

    }
    if (z == 2)
    {
        Console.Clear();
        Console.WriteLine("Resultado é: {0}", x - y);

    }
    if (z == 3)
    {
        Console.Clear();
        Console.WriteLine("Resultado é: {0}", x * y);

    }
    if (z == 4)
    {
        if (y != 0)
        {
            Console.Clear();
            Console.WriteLine("Resultado é: {0}", x / y);
        }
        else
        {
            Console.WriteLine("Não divide por '0'");
        }

    }
    if (z == 5)
    {
        if (x != 0) 
        { 
            Console.Clear();
        Console.WriteLine("Resultado é: {0}", (100 * y) / x);
    }
    else
    {
        Console.WriteLine("não divide por '0'");
    }
    }
   
        Console.Write("digite 'sair' para sair da calculadora ");
    string entrada = Console.ReadLine();
    if (entrada.ToLower() == "sair")
    {
        Console.WriteLine("Encerrando...");
        break;
    }
   
    

}
