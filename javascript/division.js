let limit = parseInt(gets());

for (let i = 0; i < limit; i++) {
    let line = gets().split(" ");
    let X = parseInt(line[0]);
    let Y = parseInt(line[1]);

    if (Y == 0) {
        console.log("divisao impossivel");
    } else {
        let divisao = parseFloat(X / Y).toFixed(1); //complete com o sinal da operação faltante entre x e y
        console.log(divisao);
    }
}

/*
    Você terá o desafio de escrever um algoritmo que leia 2 números e 
    imprima o resultado da divisão do primeiro pelo segundo. 
    Caso não for possível, mostre a mensagem “divisao impossivel” para os valores em questão.

    ---

    Entrada
        A entrada contém um número inteiro N. 
        Este N será a quantidade de pares de valores inteiros 
        (X e Y) que serão lidos em seguida.

    Saída
        Para cada caso mostre o resultado da divisão com um dígito após o ponto decimal, 
        ou “divisao impossivel” caso não seja possível efetuar o cálculo.

    ---

    Exemplo de Entrada
        3
        3 -2
        -8 0
        0 8

    Exemplo de Saída
        -1.5
        divisao impossivel
        0.0
*/