/*
    Desafio

    Dado um número inteiro ( n ) , retorne a diferença entre o produto de seus dígitos e a soma de seus dígitos.
    Entrada

    A entrada consiste em um número inteiro ( n );
    Saída

    A saída consiste na multiplicação do produto dos dígitos ( n ), a soma de seus dígitos e a diferenção entre o produto e a soma, como no exemplo a baixo: 

    Exemplo 1
    Entrada     Saída
    234     15

    Explicação: 

    Produto de dígitos = 2 * 3 * 4 = 24

    Soma dos dígitos = 2 + 3 + 4 = 9

    Resultado = 24 - 9 = 15

    Exemplo 2:
    Entrada     Saída
    4421    21

    Explicação: 

    Produto de dígitos = 4 * 4 * 2 * 1 = 32

    Soma dos dígitos = 4 + 4 + 2 + 1 = 11

    Resultado = 32 - 11 = 21

    Restrições:

        1 <= n <= 10^5
*/

string? input = Console.ReadLine();

int produto = 1;
int soma = 0;

if (input != null)
    foreach (var item in input)
    {
        int numero = int.Parse(item.ToString());

        produto *= numero;
        soma += numero;
    }

Console.WriteLine(produto - soma);