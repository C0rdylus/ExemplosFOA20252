
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

decimal salario;
float salAumento;
double metros;
int Opt, N1,N2;
try
{
    do
    {
        Console.WriteLine("o que voce quer fazer agora?");
        Console.WriteLine("0 - sair");
        Console.WriteLine("1 - somar dois numeros");
        Console.WriteLine("2 - converter metros para milimetros");
        Console.WriteLine("3 - calcular aumento de salario");
        Opt = int.Parse(Console.ReadLine());
        while (Opt > 3)
        {
            Console.Write("valor invalido, tente novamente: ");
            Opt = int.Parse(Console.ReadLine());
        }
        switch (Opt)
        {
            case 0:
                break;
            case 1:
                Console.WriteLine("voce escolheu somar dois sumenros");
                Console.Write("digite o primeiro valor");
                N2 = int.Parse(Console.ReadLine());
                Console.Write("digite o segundo valor");
                N1 = int.Parse(Console.ReadLine());
                somaDoisNumeros somaDoisNumeros = new somaDoisNumeros();
                int result;
                result = somaDoisNumeros.somar(N1, N2);
                Console.WriteLine(result);
                break;
            case 2:
                Console.WriteLine("voce escolheu converter metros para milimetros");
                Console.Write("quantos metros voce quer converter?");
                metros = double.Parse(Console.ReadLine());
                double milimetros = MetrosMilimetros.Converter(metros);
                Console.WriteLine(milimetros);
                break;
            case 3:
                Console.WriteLine("voce escolheu calcular o aumento de salario");
                Console.Write("Informe Seu Salario: ");
                salario = decimal.Parse(Console.ReadLine());
                Console.Write("Informe Seu aumento em percentual: ");
                salAumento = float.Parse(Console.ReadLine());
                decimal aumento = calcularAumento.Aumento(salario, salAumento);
                Console.WriteLine($"voce recebeu um aumento de {salAumento}% ou seja {aumento:c2} o que fez seu salario ir de {salario:c2} para {aumento + salario:c2}");
                break;
        }
    } while (Opt != 0);
    Console.WriteLine("ate mais tarde");
}
catch (FormatException)
{
    Console.WriteLine("digite apenas valores numericos");
}
catch (Exception e)
{
    Console.WriteLine("ocorreu um erro entre em contato com o suporte");
    Console.WriteLine(e.ToString());
}