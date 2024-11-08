declarando variáveis
int number;

entrada de dados
Console.WriteLine("Informe o número do dia da semana: ");
number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 1: Console.WriteLine("O dia é domigo");
        break;
    case 2: Console.WriteLine("O dia é segunda-feira");
        break;
    case 3: Console.WriteLine("O dia é terça-feira");
       break;
    case 4: Console.WriteLine("O dia é quarta-feira");
       break;
    case 5: Console.WriteLine("O dia é quinta-feira");
       break;
    case 6: Console.WriteLine("O dia é sexta-feira");
       break;
    case 7: Console.WriteLine("O dia é sábado");
       break;
    default: Console.WriteLine("Número inválido");
       break;
}
Console.ReadKey();










ctrl + k + c -> comenta linhas


declarando variáveis
char letter;

entrada de dados
Console.WriteLine("Informe a letra desejada: ");
letter = Convert.ToChar(Console.ReadLine());

processamento

switch (letter)
{
   case 'a':
   case 'A':
   case 'e':
   case 'E':
   case 'i':
   case 'I':
   case 'o':
   case 'O':
   case 'u':
   case 'U':
       Console.WriteLine($"A letra {letter} é uma vogal");
       break;
   default:
       Console.WriteLine($"A letra {letter} é uma consoante");
       break;
}










string code;

Console.WriteLine("Informe o código a ser consultado: ");
code = Console.ReadLine();

switch (code)
{
    case "001":
        Console.WriteLine("Prego... R$0,10");
        Console.WriteLine("Informe a quantidade desejada: ");
        int quant = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"O valor total é R${quant * 0.10}");
        break;
    case "002":
        Console.WriteLine("Parafuso... R$0,15");
        Console.WriteLine("Informe a quantidade desejada: ");
        quant = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"O valor total é R${quant * 0.15}");
        break;
    case "003":
        Console.WriteLine("Porca... R$0,05");
        Console.WriteLine("Informe a quantidade desejada: ");
        quant = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"O valor total é R${quant * 0.05}");
        break;
    case "004":
        Console.WriteLine("Martelo... R$40,00");
        Console.WriteLine("Informe a quantidade desejada: ");
        quant = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"O valor total é R${quant * 40.00}");
        break;
    case "005":
        Console.WriteLine("Tomada... R$3,00");
        Console.WriteLine("Informe a quantidade desejada: ");
        quant = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"O valor total é R${quant * 3.00}");
        break;
    default:
        Console.WriteLine("Código inválido");
        Console.WriteLine("Tente novamente");
        break;
}



