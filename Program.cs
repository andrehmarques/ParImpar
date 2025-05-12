int numero;

Console.Write("Digite um número para saber se ele é Par ou Impar: ");

while(!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
{
    Console.WriteLine("O número deve ser maior que 0, por favor digite outro número: ");
}

if(numero %2 == 0)
{
    Console.WriteLine($"{numero} é um número par");
}

else
{
    Console.WriteLine($"{numero} é um número impar");
}
