Console.WriteLine("Qual o valor do crédito?");
double valorCredito = double.Parse(Console.ReadLine());
Console.WriteLine("Qual a quantidade de parcelas desejadas?");
double QtdParcela = double.Parse(Console.ReadLine());
Console.WriteLine("Qual sua renda mensal?");
double renda = double.Parse(Console.ReadLine());

double prestacao = valorCredito/QtdParcela;

if(prestacao >= (renda*0.3)){
    Console.WriteLine("Seu crédito não foi autorizado");
}else{
    Console.WriteLine("Seu crédito foi aprovado");
}


