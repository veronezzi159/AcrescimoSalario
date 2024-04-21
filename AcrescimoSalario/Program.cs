decimal salario, acrescimo, resultado;
do
{
    Console.WriteLine("Digite o valor de seu salario");
    salario = decimal.Parse(Console.ReadLine());
    Console.WriteLine("Digite o acrscimo que deseja(sem o %)");
    acrescimo = decimal.Parse(Console.ReadLine());
    if (acrescimo <= 0 || salario <= 0 )
    {
        Console.WriteLine("Acrescimo ou salário zerados ou negatios, insira valores valídos");
    }
} while (salario <= 0 || acrescimo <= 0);

resultado = salario + (salario * (acrescimo / 100));

Console.WriteLine($"Seu salário com o valor acrescido irá totalizar R${resultado}");
