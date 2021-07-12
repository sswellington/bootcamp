def insert()
    i = 0
    max = 2
    receita = []
    while(i < max) do 
        puts("Informe uma receita")
        receita[i] = gets.chomp()
        i += 1
    end
    return receita
end


def str(lista) 
    for l in lista do
        puts("A Receita #{l} salva com sucesso")
    end 
end


def cookbook()
    puts("Bem-vindo ao Cookbook")
    str(insert())

cookbook()