using System;

//Exercício 1
Console.Write("Digite sua idade: ");

int age = int.Parse(Console.ReadLine());

if (age < 18){
    Console.WriteLine("Você é menor de idade");
}else if (age >= 60) {
    Console.WriteLine("Você é idoso(a)");
}else{
    Console.WriteLine("Você é maior de idade");
}



//Exercício 2
Console.WriteLine("Digite a temperatura: ");

double temp = double.Parse(Console.ReadLine());

if(temp < 15){
    Console.WriteLine("Está frio!");
}else if(temp >= 15 && temp <= 30){
    Console.WriteLine("Está agradável!");
}else{
    Console.WriteLine("Está quente!");
}



//Exercício 3
Console.WriteLine("Digite um número: ");
int num1;
num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite outro número: ");
int num2;
num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite um terceiro número: ");
int num3;
num3 = int.Parse(Console.ReadLine());

if(num1 > num2 && num1 > num3){
    Console.WriteLine("O maior número é: " + num1);
}else if(num2 > num1 && num2 > num3){
    Console.WriteLine("O maior número é: " + num2);
}else{
    Console.WriteLine("O maior número é: " + num3);
}



//Exercício 4
Console.WriteLine("Digite o nome do produto: ");
string nameProduct = Console.ReadLine();

Console.WriteLine("Digite o preço do produto: ");
double priceProduct = double.Parse(Console.ReadLine());

Console.WriteLine("Escolha a forma de pagamento: ");
Console.WriteLine("1 - À vista com 10% de desconto");
Console.WriteLine("2 - Parcelado em 2x sem juros");
Console.WriteLine("Digite a opção 1 ou 2:");

int optionPayment = int.Parse(Console.ReadLine());

double finalPrice;

if(optionPayment == 1){
    finalPrice = priceProduct * 0.9;
    Console.WriteLine("O preço à vista do produto é: " + finalPrice);
}else if(optionPayment == 2){
    finalPrice = priceProduct;
    double plot = finalPrice/2;
    Console.WriteLine("O preço parcelado do produto é: " + plot);
}else{
    Console.WriteLine("Opção inválida!");
}


//Exercício 5
Console.WriteLine("Digite um número: ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite outro número: ");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("Escolha a operação");
Console.WriteLine("1 - Adição");
Console.WriteLine("2 - Subtração");
Console.WriteLine("3 - Multiplicação");
Console.WriteLine("4 - Divisão");
Console.WriteLine("Digite a opção 1, 2, 3 ou 4:");

int option = int.Parse(Console.ReadLine());

double result;

switch (option)
{
    case 1:
        result = number1 + number2;
        Console.WriteLine($"Resultado da soma é: {result}");
        break;
    case 2:
        result = number1 - number2;
        Console.WriteLine($"Resultado da subtração é: {result}");
        break;
    case 3:
        result = number1 * number2;
        Console.WriteLine($"Resultado da multiplicação é: {result}");
        break;
    case 4:
        if (number2 != 0)
        {
            result = (double)number1 / number2;
            Console.WriteLine($"Resultado da divisão é: {result}");
        }
        else
        {
            Console.WriteLine("Divisão por zero não é válida");
        }
        break;
    default:
        Console.WriteLine("Operação inválida, escolha uma opção entre 1 e 4.");
        break;
}