"""
    Leia quatro números (N1, N2, N3, N4), cada um deles com uma casa decimal, correspondente às quatro notas de um aluno. 
    Calcule a média com pesos 2, 3, 4 e 1, respectivamente, para cada uma destas notas e mostre esta média acompanhada pela mensagem "Media: ". 
    Se esta média for maior ou igual a 7.0, imprima a mensagem "Aluno aprovado.". 
    Se a média calculada for inferior a 5.0, imprima a mensagem "Aluno reprovado.". 
    Se a média calculada for um valor entre 5.0 e 6.9, inclusive estas, o programa deve imprimir a mensagem "Aluno em exame.".

    No caso do aluno estar em exame, leia um valor correspondente à nota do exame obtida pelo aluno. 
    Imprima então a mensagem "Nota do exame: " acompanhada pela nota digitada. 
    Recalcule a média (some a pontuação do exame com a média anteriormente calculada e divida por 2) e 
    imprima a mensagem "Aluno aprovado." (caso a média final seja 5.0 ou mais ) ou 
    "Aluno reprovado.", (caso a média tenha ficado 4.9 ou menos). 
    Para estes dois casos (aprovado ou reprovado após ter pego exame) apresente na última linha uma mensagem "Media final: " seguido da média final para esse aluno.
    
    Entrada
        A entrada contém quatro números de ponto flutuante correspendentes as notas dos alunos.
    
    Saída
        Todas as respostas devem ser apresentadas com uma casa decimal. 
        As mensagens devem ser impressas conforme a descrição do problema. 
        Não esqueça de imprimir o enter após o final de cada linha, 
        caso contrário obterá "Presentation Error".    
"""


def insert_manual():
    grade = []
    grade.append(float(input()))
    grade.append(float(input()))
    grade.append(float(input()))
    grade.append(float(input()))
    return grade


def mean(value:float) -> float:
    sum = 0
    for i in value:
        sum += i
    return (sum/len(value))


def weighted_average(value, weight) -> float:             
    sum = 0
    for i in range(len(value)):
        sum += value[i] * (weight[i])  
    return sum


def recovery(grade, message): 
    if(grade > 5.9):
        message += ('Aluno aprovado.\nMedia final: %.1f' %grade) 
        return message
    else:
        message += ('Aluno reprovado.\nMedia final: %.1f' %grade)
        return message


def status(mean:float) -> str:
    if (mean >= 7):
        return('Aluno aprovado.')
    elif(mean < 5):
        return('Aluno reprovado.')
    else: 
        message = ('Aluno em exame.\n')  
        recovery_note = float(input())
        # recovery_note = 6.4
        message += ('Nota do exame: ' + str(recovery_note) + '\n')
        recovery_note = (recovery_note + mean) / 2    
        return recovery(recovery_note, message)


def test_init():
    assert 5 == 5    


def test_avg():
    assert 4.975 == mean([0.0, 9.9, 10.0, .0]) 
    assert 5.375 == mean([2.0, 4.0, 7.5, 8.0])
    assert 5.375 == mean([2.0, 6.5, 4.0, 9.0])
    assert 7.625 == mean([9.0, 4.0, 8.5, 9.0])


def test_weighted_average():
    weight = [.2, .3, .4, .1] 
        
    assert 4.8500000000000005 == weighted_average([2.0, 6.5, 4.0, 9.0], weight)
    assert 5.3999999999999995 == weighted_average([2.0, 4.0, 7.5, 8.0], weight)
    assert 6.9700000000000010 == weighted_average([0.0, 9.9, 10,  0.0], weight)
    assert 7.2000000000000000 == weighted_average([1.0, 10,  10,  0.0], weight)
    assert 7.3000000000000010 == weighted_average([9.0, 4.0, 8.5, 9.0], weight)
    assert 10.000000000000000 == weighted_average([10, 10, 10, 10,], weight)


if __name__ == '__main__':
    weight = [.2, .3, .4, .1]
    
    grade = [2, 4, 7.5, 8]
    avg = weighted_average(grade, weight)
    print('Media: %.1f' %avg)
    print(status(avg)+'\n')
    
    grade = [2.0, 6.5, 4.0, 9.0]
    avg = weighted_average(grade, weight)
    print('Media: %.1f' %avg)
    print(status(avg)+'\n')
    
    grade = [9.0, 4.0, 8.5, 9.0]
    avg = weighted_average(grade, weight)
    print('Media: %.1f' %avg)
    print(status(avg)+'\n')
    
