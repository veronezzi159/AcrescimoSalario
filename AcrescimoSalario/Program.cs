decimal salario, acrescimo, desejado;
do
{
    Console.WriteLine("Digite o valor de seu salario");
    salario = decimal.Parse(Console.ReadLine());
    Console.WriteLine("Digite o salário desejado");
    desejado = decimal.Parse(Console.ReadLine());
    if (desejado <= 0 || salario <= 0 )
    {
        Console.WriteLine("Acrescimo ou salário zerados ou negatios, insira valores valídos");
    }
} while (salario <= 0 || desejado <= 0);

acrescimo = (desejado - salario) * 100/ salario;

Console.WriteLine($"Para atingir o salário de {desejado}, você terá que obter um acréscimo de: {acrescimo}%");
