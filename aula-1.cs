// 10 de outubro

//ing System.Runtime.CompilerServices;

//ring name;
//t idade;

//Console.WriteLine("Olá, seja bem-vindo!");
//Console.Write("Me diga seu nome: ");

//name = Console.ReadLine();

//Console.Write($"{name}, me fala sua idade: ");

//idade = Convert.ToInt32( Console.ReadLine());

//Console.WriteLine($"Certo, {name}, sua idade é {idade}");
//Console.WriteLine($"O dobro da sua idade é {idade * 2}");

//Console.ReadKey(); 


// atv 1
// . Faça um algoritmo que:
//a) Leia um número inteiro;
//b) Leia um segundo número inteiro;
//c) Efetue a adição dos dois valores;
//d) Apresente o valor calculado.

using System.Runtime.Serialization;

//int n1, n2;
//int soma;

//Console.WriteLine("Soma de números");
//Console.WriteLine("Digite um número: ");
//n1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Digite outro número: ");
//n2 = Convert.ToInt32(Console.ReadLine());

//soma = n1 + n2;

//Console.WriteLine($"A soma de N1 e N2 é {soma}");

// Faça um algoritmo que leia dois números nas variáveis NumA e NumB, nessa ordem, e imprima
//em ordem inversa, isto é, se os dados lidos forem 5 e 9, por exemplo, devem ser impressos na
//ordem 9 e 5

//int NumA, NumB;

//Console.WriteLine("Digite um número: ");
//NumA = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Digite o segundo número: ");
//NumB = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"O números digitados em ordem inversa são {NumB} e {NumA}");

//Faça um algoritmo que:
//a) Obtenha o valor para a variável HT (horas trabalhadas no mês);
//b) Obtenha o valor para a variável VH (valor hora trabalhada):
//c) Obtenha o valor para a variável PD (percentual de desconto);
//d) Calcule o salário bruto => SB = HT * VH;
//e) Calcule o total de desconto => TD = (PD/100)*SB;
//f) Calcule o salário líquido => SL = SB – TD;
//g) Apresente os valores de: Horas trabalhadas, Salário Bruto, Desconto, Salário Liquido

//Console.WriteLine("Calculadora de Horas");

//float HT, VH, PD;

//float SB, TD, SL;

//Console.WriteLine("Digite as horas trabalhadas: ");
//HT = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Digite o valor das horas trabalhadas: ");
//VH = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Digite o percentual de desconto: ");
//PD = Convert.ToInt32(Console.ReadLine());

//SB = HT * VH;

//TD = (PD / 100) * SB;

//SL = SB - TD;

//Console.WriteLine($"\n As horas trabalhadas são {HT}");
//Console.WriteLine($"\n O salário bruto é {SB}");
//Console.WriteLine($"\n O desconto é {TD}");
//Console.WriteLine($"\n O salário líquido é {SL}");


//. Faça um algoritmo que leia uma temperatura em graus Celsius e apresente-a convertida em graus
//Fahrenheit.A fórmula de conversão é: F = (9 * C + 160) / 5, na qual F é a temperatura em
//Fahrenheit e C é a temperatura em Celsius;

//int F, C;

//Console.WriteLine("Conversor de graus Celsius par Fahrenheit");
//Console.WriteLine("Digite uma temperatura em C: ");

//C = Convert.ToInt32(Console.ReadLine());

//F = (9 * C + 160) / 5;

//Console.WriteLine($"A temperatura convertida em Fahrenheit é {F}");


//Faça um algoritmo que calcule a quantidade de litros de combustível gasta em uma viagem,
//utilizando um automóvel que faz 12Km por litro. Para obter o cálculo, o usuário deve fornecer o
//tempo gasto na viagem e a velocidade média durante ela. Desta forma, será possível obter a
//distância percorrida com a fórmula DISTANCIA = TEMPO * VELOCIDADE. Tendo o valor da
//distância, basta calcular a quantidade de litros de combustível utilizada na viagem com a fórmula:
//LITROS_USADOS = DISTANCIA / 12.O programa deve apresentar os valores da velocidade
//média, tempo gasto na viagem, a distância percorrida e a quantidade de litros utilizada na viagem.

float t, vm, d, l;

Console.WriteLine("Calculadora de combustível");
Console.WriteLine("Digite o tempo gasto na viagem: ");

t = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("\n Digite a velocidade média: ");

vm = Convert.ToDecimal(Console.ReadLine());

d = t * vm;

l = d / vm;

Console.WriteLine($"O tempo gasto foi de {t}");
Console.WriteLine($"A velocidade média é de {vm}");








