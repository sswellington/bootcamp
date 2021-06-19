import random


""" 
    ler um valor e criar um programa que coloque o valor lido na primeira posição de um vetor N[10]. 
    Em cada posição subsequente, coloque o dobro do valor da posição anterior. 
    Por exemplo, se o valor lido for 1, os valores do vetor devem ser 1,2,4,8 e assim sucessivamente. Mostre o vetor em seguida.
"""


def double(value:int) -> list:
    l = []
    l.append(value)

    for i in range(10):
        print("N[%i] = %i" %(i, l[i]))
        l.append(l[i]*2)
    return(l)

    
if __name__ == '__main__':  
    double((random.randint(0,100)))
