// See https://aka.ms/new-console-template for more information
using System.Collections;

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

//&& => e 
//|| => ou
// ! => negação

if(true && false)
{
    Console.WriteLine("Verdadeiro");
}
else
{
    Console.WriteLine("Falso");
}

if ((7 > 5) && (10 > 5))
{
    Console.WriteLine("Verdadeiro");
}
else
{
    Console.WriteLine("Falso");
}

if ((7 > 5) && (1 > 5))
{
    Console.WriteLine("Verdadeiro");
}
else
{
    Console.WriteLine("Falso");
}

if((7 > 5) || (1 > 5))
{
    Console.WriteLine("Verdadeiro");
}
else
{
    Console.WriteLine("Falso");
}

if (!(1 > 5) && (7 > 5))
{
    Console.WriteLine("Verdadeiro");
}
else
{
    Console.WriteLine("Falso");
}

if ((1 > 5) && !(7 > 5))
{
    Console.WriteLine("Verdadeiro");
}
else
{
    Console.WriteLine("Falso");
}

if ((1 > 5) || (7 > 5))
{
    Console.WriteLine("Verdadeiro");
}
else
{
    Console.WriteLine("Falso");
}

bool resultado = (1 > 5) ? true : false;

Console.WriteLine(resultado);

string resultado1 = (1 > 5) ? "verdadeiro" : "falso";

Console.WriteLine(resultado1);

void EstadoBrasileiro()
{
    Console.WriteLine("Sergipe");
}

EstadoBrasileiro();

string retornaEstado()
{
    string retorno = "Rio de Janeiro";
    return retorno;
}

var estado = retornaEstado();
Console.WriteLine(estado);

int somaDoisNumeros(int num1, int num2)
{
    int resultado = num1 + num2;
    return resultado;
}

int resultado2 = somaDoisNumeros(10, 20);

Console.WriteLine(resultado2);
 */

var arrayList = new ArrayList();

arrayList.Add("Willian"); //0
arrayList.Add(10); //1
arrayList.Add(true); //2

Console.WriteLine(arrayList[0]);

//arrayList.RemoveAt(1);

Console.WriteLine(arrayList[1]);

foreach (var item in arrayList)
{
    Console.WriteLine(item);
}

var arrayString = new string[5];

arrayString[0] = "Teste";
arrayString[1] = "Teste1";
arrayString[2] = "Teste2";
arrayString[3] = "Teste3";
arrayString[4] = "Teste4";

foreach (var item in arrayString)
{
    Console.WriteLine(item);
}

var arrayInt = new int[4] {1,2,3,4 };

foreach (var item in arrayInt)
{
    Console.WriteLine(item);
}

var listaGenercia = new List<string>();
var listaGenerciaInteiro = new List<int>();

listaGenercia.Add("Teste");
listaGenerciaInteiro.Add(15);

foreach (var item in listaGenercia)
{
    Console.WriteLine(item);
}

var dicionario = new Dictionary<int, string>();
var dicionario1 = new Dictionary<string, string>();

dicionario.Add(987, "Teste 987");
dicionario1.Add("986", "Teste 98");

var valor = dicionario[987];
var valor1 = dicionario1["986"];

Console.WriteLine(valor);
Console.WriteLine(valor1);

valor1 = dicionario1["986"] = "Palavra";

Console.WriteLine(valor1);

foreach (var item in dicionario)
{
    Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
}

var objQueue = new Queue<string>();

objQueue.Enqueue("Empilhamento1");
objQueue.Enqueue("Empilhamento2");
objQueue.Enqueue("Empilhamento3");

var primeira = objQueue.Peek();
var segunda = objQueue.Peek();

Console.WriteLine(primeira);
Console.WriteLine(segunda);

primeira = objQueue.Dequeue();
Console.WriteLine(primeira);
segunda = objQueue.Dequeue();
Console.WriteLine(segunda);

Console.WriteLine("-----------------------------------------------");

var terceira = objQueue.Peek();
Console.WriteLine(terceira);
Console.WriteLine("----- FOREACH --------");
foreach (var item in objQueue)
{
    Console.WriteLine(item);
}

var estado = new Stack<string>();

estado.Push("Amazona");
estado.Push("Parana");
estado.Push("Mato Grosso");

foreach (var item in estado)
{
    Console.WriteLine(item);
}

var capturarDados = estado.Pop();
var capturarDados2 = estado.Pop();
Console.WriteLine(capturarDados);
Console.WriteLine(capturarDados2);


/*
foreach (var item in estado)
{
    Console.WriteLine(item);
}
*/

/*
  
  1 - conta corrnte
  2 - conta poupança
  3 - conta universitaria
   - DEsse codigo não existensole.WriteLine

*/

/*

var contaCorrente = 0;

if(contaCorrente == 1)
{
    Console.WriteLine("conta corrnte");
}
else if(contaCorrente == 2)
{
    Console.WriteLine("conta poupança");
}
else if(contaCorrente == 3)
{
    Console.WriteLine("conta universitaria");
}
else
{
    Console.WriteLine("Esse codigo não existe");
}


if (contaCorrente == 1)
    Console.WriteLine("conta corrente");
else if (contaCorrente == 2)
    Console.WriteLine("conta poupança");
else if (contaCorrente == 3)
    Console.WriteLine("conta universitaria");
else
    Console.WriteLine("Esse codigo não existe");
*/

var contaCorrente = 0;

switch (contaCorrente) { 
     case 1:
        Console.WriteLine("conta corrente");
        break;
     case 2:
        Console.WriteLine("conta poupança");
        break;
     case 3:
        Console.WriteLine("conta universitaria");
        break;
    default:
        Console.WriteLine("Valor invalido");
        break;
}

Console.WriteLine("Crescente");

for(int i = 0; i <= 10; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("Decrescente");

for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}

var estados = new List<string>();
estados.Add("São Paulo");
estados.Add("Rio de Janeiro");
estados.Add("Minas gerais");
estados.Add("Parana");
Console.WriteLine("Lista");
Console.WriteLine(estados.Count);

for (int i = 0; i < estados.Count; i++)
{
    var est = estados[i];
    Console.WriteLine(est);
}

foreach(var item in estados)
{
    Console.WriteLine(item);
}

string teste = "Willian";
foreach (var item in teste)
{
    Console.WriteLine(item);
}

string teste1 = "Willian";
foreach (var item in teste1)
{
    Console.WriteLine(item);
    break;
}

Console.WriteLine("Valor da lista cerscente de 1 a 10");

int contador = 0;
while (contador < 10)
{
    Console.WriteLine(contador);
    contador++;
}

Console.WriteLine("do while");

var contador1 = 0;

do
{
    Console.WriteLine("DoWhile: " + contador1);
    contador1++;
} while (contador1 < 10);

Console.WriteLine("do while");

var contador2 = 50;

do
{
    Console.WriteLine("DoWhile: " + contador2);
    contador2++;
} while (contador2 < 10);

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Entendendo o Continue");
    Console.WriteLine(i);
    if (i == 3)
    {
        Console.WriteLine("Dentro do IF Continue");
        continue;

    }

    if (i == 3)
    {
        Console.WriteLine("Dentro do IF Break");
        break;

    }
}

/*
 
 -- Porlimorfismo
 -- Herança
 -- Abstração
 -- Encapsulamento
 
  Vantagens da OO:

  Reutilização de Código: Classes e objetos podem ser reutilizados em diferentes partes do programa ou em projetos futuros, economizando tempo e esforço.

  Encapsulamento: A OO permite ocultar os detalhes internos de uma classe, expondo apenas o que é necessário para o uso externo. Isso ajuda a proteger os dados e a reduzir a complexidade do código.

    Polimorfismo: A OO permite que objetos de diferentes classes sejam tratados de maneira uniforme, desde que compartilhem uma interface comum. Isso facilita a extensão e a manutenção do código.
 
 */

