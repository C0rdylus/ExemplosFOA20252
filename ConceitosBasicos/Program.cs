
using ConceitosBasicos.uteis;
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

//altere o programa para que solicite ao usuario informar
//o seu salario e ao final informe o desconto de irpf de acordo
//com o salario informado. ultilize a tabela oficial de descontos de irpf do brasil.


try
{
    decimal salario;
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
}
catch(FormatException)
{
    Console.WriteLine("digite apenas valores numericos");
}
catch(Exception e)
{
    Console.WriteLine("ocorreu um erro entre em contato com o suporte");
    Console.WriteLine(e.ToString());
}
*/

somaDoisNumeros somaDoisNumeros = new somaDoisNumeros();
int result;
result = somaDoisNumeros.somar(20, 22);

double milimetros = MetrosMilimetros.Converter(1.8);
Console.WriteLine(milimetros);
