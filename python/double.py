#!/usr/bin/env python
""" 
    ler um valor e criar um programa que coloque o valor lido na primeira posição de um vetor N[10]. 
    Em cada posição subsequente, coloque o dobro do valor da posição anterior. 
    Por exemplo, se o valor lido for 1, os valores do vetor devem ser 1,2,4,8 e assim sucessivamente. Mostre o vetor em seguida.
"""

import random


def double(value:int) -> list:
    my_list = []
    my_list.append(value)

    for i in range(11):
        my_list.append(my_list[i]*2)
    return(my_list)

    
if __name__ == '__main__':  
    # double((random.randint(0,100)))
    my_list = double(int(input()))

    for i in range(11):
        print("N["+str(i)+"] = "+str(my_list[i]))
        