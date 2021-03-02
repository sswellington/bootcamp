import java.util.Scanner;

public class Odd {
    public static void main(String[] args) {
        Scanner reader = new Scanner(System.in);
        int num = reader.nextInt();
        reader = null;
        System.gc();

        for (int i = 1; i <= num; i = i + 1) {
            if ((i % 2) != 0) {
                System.out.println(i);
            }
        }
    }
}

/*
 * Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1
 * até X, um valor por linha, inclusive o X, se for o caso.
 * 
 * Entrada 
 * 
 * O arquivo de entrada contém 1 valor inteiro qualquer.
 * 
 * Saída 
 * 
 * Imprima todos os valores ímpares de 1 até X, 
 * inclusive X, se for o caso.
 * 
 * Exemplo de Entrada: 8 
 * 
 * Exemplo de Saída: 1 3 5 7
 * 
 */
