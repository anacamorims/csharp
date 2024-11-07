using System;

//Exercício 1
Console.WriteLine("Digite um número: ");
int num = int.Parse(Console.ReadLine());

string evenOrOdd = "";

if(num % 2 == 0){
    evenOrOdd = "par";
}else{
    evenOrOdd = "ímpar";
}

string posOrNegOrZero = "";

if(num > 0){
    posOrNegOrZero = "positivo";
}else if(num < 0){
    posOrNegOrZero = "negativo";
}else{
    posOrNegOrZero = "zero";
}

Console.WriteLine($"O número {num} é {evenOrOdd} e {posOrNegOrZero}");



//Exercício 2
Console.WriteLine("Digite o preço do produto: ");
double priceProduct = double.Parse(Console.ReadLine());

if(priceProduct <= 50.00){
    Console.WriteLine("Classificação: Produto Barato");
}else if(priceProduct <= 150.00){
    Console.WriteLine("Classificação: Produto de preço moderado");
}else if(priceProduct <= 500.00){
    Console.WriteLine("Classificação:Produto Caro");
}else{
    Console.WriteLine("Classificação: Produto de Luxo");
}
