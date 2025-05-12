double valoremprestimo, rendamensal, valorparcela = 0, limiteparcela;
int quantidadeparcelas;

Console.WriteLine("Bem vindo(a) a área de empréstimos!");

Console.Write("Digite o valor do empréstimo desejado (R$): ");
while(!double.TryParse(Console.ReadLine(), out valoremprestimo) || valoremprestimo <= 0)
{
    Console.Write("Valor Inválido, digite novamente: ");
}

Console.Write("Digite a quantidade de parcelas desejadas: ");
while(!int.TryParse(Console.ReadLine(), out quantidadeparcelas) || quantidadeparcelas <= 0)
{
    Console.Write("Quantidade de parcelas inválida. Digite uma quantidade maior que 0: ");
}

Console.Write("Digite sua renda mensal (R$) ");
while(!double.TryParse(Console.ReadLine(), out rendamensal) || rendamensal <= 0)
{
    Console.Write("Valor inválido, digite novamente: ");
}

valorparcela = valoremprestimo / quantidadeparcelas;
limiteparcela = rendamensal * 0.3;

Console.WriteLine($"Valor do empréstimo solicitado: {valoremprestimo:C2}");
Console.WriteLine($"Valor das parcelas: {valorparcela:C2}");

if(limiteparcela > valorparcela)
{
    Console.WriteLine("Seu empréstimo foi aprovado com sucesso!");
}

else
{
    Console.WriteLine("Empréstimo negado, o valor da parcela é maior que 30% da sua renda mensal.");
}