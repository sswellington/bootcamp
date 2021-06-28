import java.io.IOException;
import java.util.Scanner;

public class Minor {
	public static void main(String[] args) throws IOException {
		Scanner reader = new Scanner(System.in);

		int N = reader.nextInt();
		int[] X = new int[N];
		int minor = 0, position = 0;

		for (int i = 0; i < N; i++) {
			X[i] = reader.nextInt();

			if (i == 0) {
				minor = X[i];
				position = i;
			} else if (X[i] < minor) {
				minor = X[i];
				position = i;
			}
		}

		reader = null;
		System.gc();
		
		System.out.println("Menor valor: " + minor);
		System.out.println("Posicao: " + position);
	}
}

/*
 * Desafio
 * 
 * Desenvolva um código que leia um valor E. Este E será o tamanho de um vetor
 * X[E]. A seguir, leia cada um dos valores de X, encontre o menor elemento
 * deste vetor e a sua posição dentro do vetor, mostrando esta informação.
 * 
 * Entrada
 * 
 * A primeira linha de entrada contem um único inteiro E (1 < E < 1000),
 * indicando o número de elementos que deverão ser lidos em seguida para o vetor
 * X[E] de inteiros. A segunda linha contém cada um dos E valores, separados por
 * um espaço.
 * 
 * Saída A primeira linha apresenta a mensagem “Menor valor:” seguida de um
 * espaço e do menor valor lido na entrada.
 * 
 * A segunda linha apresenta a mensagem “Posicao:” seguido de um espaço e da
 * posição do vetor na qual se encontra o menor valor lido, lembrando que o
 * vetor inicia na posição zero.
 * 
 * Exemplo de Entrada	Exemplo de Saída
 * 10
 * 1 2 3 4 -5 6 7 8 9 10
 * Menor valor: -5
 * Posicao: 4
 */
