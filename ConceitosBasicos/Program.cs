
using System.ComponentModel.Design;

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

decimal salario;
Console.Write("Informe Seu Salario: ");
salario = Convert.ToDecimal(Console.ReadLine());
if (salario <= Convert.ToDecimal(2428.80))
{
    Console.WriteLine("seu desconto e de 0%");
}
else if (salario <= Convert.ToDecimal(2826.65))
{
    Console.WriteLine("seu desconto e de 7,5%");
}
else if (salario <= Convert.ToDecimal(3751.05))
{
    Console.WriteLine("seu desconto e de 15%");
}
else if (salario <= Convert.ToDecimal(4664.68))
{
    Console.WriteLine("seu desconto e de 22.5%");
}
else 
{
    Console.WriteLine("seu desconto e de 27.5%");
}