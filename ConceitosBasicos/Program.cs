
using System.ComponentModel.Design;
/*
byte idade;
string nome;
Console.Write("digite seu nome: ");
nome = Console.ReadLine();
Console.Write("digite sua idade: ");
idade = Convert.ToByte(Console.ReadLine());
Console.WriteLine("Olá " + nome + ". a idade informada foi {0}" ,  idade);
idade *= 2;
Console.WriteLine($"a nova idade é {idade++}");
Console.WriteLine($"a nova idade é {++idade}");
*/
//altere o programa para que solicite ao usuario informar
//o seu salario e ao final informe o desconto de irpf de acordo
//com o salario informado. ultilize a tabela oficial de descontos de irpf do brasil.

decimal salario;
Console.Write("Informe Seu Salario: ");
salario = Convert.ToDecimal(Console.ReadLine());
if (salario <= Convert.ToDecimal(2428.80))
{
    Console.WriteLine("0%");
}
else if (salario <= Convert.ToDecimal(2826.65))
{
    Console.WriteLine("7,5%");
}
else if (salario <= Convert.ToDecimal(3751.05))
{
    Console.WriteLine("15%");
}
else if (salario <= Convert.ToDecimal(4664.68))
{
    Console.WriteLine("22.5%");
}
else 
{
    Console.WriteLine("27.5%");
}


decimal irpf;
Console.Write("Informe Seu Salario: ");
salario = decimal.Parse(Console.ReadLine());
if (salario <= 2428.80m)
    irpf = 0;
else if (salario <= 2826.65m)
    irpf = salario * 7.5m - 182.16m;
else if (salario <= 3751.05m)
    irpf = salario * 15m - 394.16m;
else if (salario <= 4664.68m)
    irpf = salario * 22.5m - 675.49m;
else
    irpf = salario * 27.5m - 908.73m;

Console.WriteLine($"para o salario de {salario:C2} o irpf a ser pago é {irpf:C2}");