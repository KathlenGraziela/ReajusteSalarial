double salario = 0.00;
double reajuste = 0.00;
double novoSalario = 0.00;
double percentual = 0.00;

Console.Write("Informe o valor do salario: ");
salario = Convert.ToDouble(Console.ReadLine());

if (salario < 0)
return;

else if (salario <= 400)
{
    percentual = 15.00 / 100.00;
    reajuste = salario * percentual;
    novoSalario = salario + reajuste;
}
else if (salario <= 800)
{
    percentual = 12.0 / 100.00;
    reajuste = salario * percentual;
    novoSalario = salario + reajuste;
}
else if (salario <= 1200)
{
    percentual = 10.0 / 100.00;
    reajuste = salario * percentual;
    novoSalario = salario + reajuste;
}
else if (salario <= 2000)
{
    percentual = 7.0 / 100.00;
    reajuste = salario * percentual;
    novoSalario = salario + reajuste;
}
else
{
    percentual = 4.0 / 100.00;
    reajuste = salario * percentual;
    novoSalario = salario + reajuste;
}

Console.WriteLine($"Novo salario: {novoSalario}");
Console.WriteLine($"Reajuste ganho: {reajuste}");
Console.WriteLine($"Em percentual: {percentual*100.00} %");

