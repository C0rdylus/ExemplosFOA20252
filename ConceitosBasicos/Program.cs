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

using System.ComponentModel.Design;

decimal salario;
Console.Write("Informe Seu Salario: ");
salario = Convert.ToDecimal(Console.ReadLine());
if (salario < Convert.ToDecimal(2259.20)) ;
{
    
}