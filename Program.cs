int numero;

Console.Write("Digite um número: ");
numero = int.Parse(Console.ReadLine()!);

if(numero %2 == 0)
{
    Console.WriteLine($"{numero} é par");
}

else
{
    Console.WriteLine($"{numero} é impar");
}
