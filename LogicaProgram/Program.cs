// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string cidade = "São Paulo";

Console.WriteLine(cidade);
//Essa idade principal
int idade = 20;

/*
 * Console.WriteLine(idade);
   long idadeLong = 30;
   Console.WriteLine(idadeLong);
   double temperatura = 5.60;
   Console.WriteLine(temperatura); 
 */
Console.WriteLine(idade);
long idadeLong = 30;
Console.WriteLine(idadeLong);
double temperatura = 5.60;
Console.WriteLine(temperatura);
float temperaturaFloat = 35.15f;
Console.WriteLine(temperaturaFloat);
decimal temperaturaDecimal = 35.15m;
Console.WriteLine(temperaturaDecimal);
char letra = 'p';
Console.WriteLine(letra);

var letraComVar = "teste";
Console.WriteLine(letraComVar);

const string URL_SISTEMA = "http://teste.com";

Console.WriteLine(URL_SISTEMA);

//Console.WriteLine("------------------------------------------------------");

//int valor1 = 5;
//int valor2 = 10;
//double valor3 = 5.5;

//int resultado = valor1 + valor2 + Convert.ToInt32(valor3);
//Console.WriteLine(resultado);

//int multiplicacao = (valor1 * valor2) - 90;
//Console.WriteLine(multiplicacao);

//int subtracao = valor1 + valor2 + Convert.ToInt32(valor3);
//Console.WriteLine(subtracao);

//int divisao = valor2/valor1;
//Console.WriteLine(divisao);

/*
 *  ==
 *  >= 
 *  <=
 *  !=
 *  <
 *  >
 */

bool igual = 50 == 50;
bool maiorIgual = 80 >= 50;
bool menorIgual = 50 <= 50;
bool maior = 50 > 50;
bool menor = 50 < 52;
bool diferente = 10 != 50;

if (maiorIgual)
{
    Console.WriteLine(maiorIgual);
}
else
{
    Console.WriteLine(maiorIgual);
}

if (menorIgual)
{
    Console.WriteLine(menorIgual);
}
else
{
    Console.WriteLine(menorIgual);
}

if (maior)
{
    Console.WriteLine(maior);
}
else
{
    Console.WriteLine(maior);
}