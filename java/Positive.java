import java.io.IOException;
import java.util.Scanner;


public class Positive {
    public static void main(String[] args) throws IOException {
        Scanner leitor = new Scanner(System.in);       
        int i = 0;
        int cont = 0;
        while (i <  6) {
        	double x = leitor.nextDouble();
        	if (x > 0.0) {
        		cont++;
        	}
        	i++;
        }
        System.out.println(cont + " valores positivos");
    }
}

/*
    Crie um programa que leia 6 valores. Você poderá receber valores negativos e/ou positivos como entrada, devendo desconsiderar os valores nulos. Em seguida, apresente a quantidade de valores positivos digitados.

    Entrada
        Você receberá seis valores, negativos e/ou positivos.

    Saída
        Exiba uma mensagem dizendo quantos valores positivos foram lidos assim como é exibido abaixo no exemplo de saída. Não esqueça da mensagem "valores positivos" ao final.
*/