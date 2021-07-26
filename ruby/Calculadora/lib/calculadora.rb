def soma(primeiro_numero, segundo_numero)
    return primeiro_numero + segundo_numero
end

def subtracao(primeiro_numero, segundo_numero)
    return primeiro_numero - segundo_numero
end

def multiplicacao(primeiro_numero, segundo_numero)
    return primeiro_numero * segundo_numero
end

def divisao(primeiro_numero, segundo_numero)
    begin  # "try" block
        # https://stackoverflow.com/questions/18705373/ruby-equivalent-for-pythons-try
        return primeiro_numero / segundo_numero  
        raise('Opa! Zero como divisor')
    rescue 
        return('Opa! Zero como divisor')
    end 
end
