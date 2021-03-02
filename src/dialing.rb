ddd = gets.strip.to_i

case ddd
    when 61 then puts "Brasilia"
    when 71 then puts "Salvador"
    when 11 then puts "Sao Paulo"
    when 21 then puts "Rio de Janeiro"
    when 32 then puts "Juiz de Fora"
    when 19 then puts "Campinas"
    when 27 then puts "Vitoria"
    when 31 then puts "Belo Horizonte"
    else puts "DDD nao cadastrado"
end


/*
    # Códigos DDD Brasil dos estados

    Leia um número inteiro que representa um código de DDD para discagem interurbana. 
    Em seguida, informe à qual cidade o DDD pertence, 
    considerando a tabela da Lista completa com todos os DDDs de todas as cidades do Brasil:


    | Estado              | Capital        | DDD |
    |---------------------|----------------|-----|
    | Acre                | Rio Branco     | 68  |
    | Alagoas             | Maceió         | 82  |
    | Amapá               | Macapá         | 96  |
    | Amazonas            | Manaus         | 92  |
    | Bahia               | Salvador       | 71  |
    | Ceará               | Fortaleza      | 88  |
    | Distrito Federal    | Brasília       | 61  |
    | Espírito Santo      | Vitória        | 27  |
    | Goiás               | Goiânia        | 62  |
    | Maranhão            | São Luís       | 98  |
    | Mato Grosso         | Cuiabá         | 65  |
    | Mato Grosso do Sul  | Campo Grande   | 84  |
    | Minas Gerais        | Belo Horizonte | 31  |
    | Paraná              | Curitiba       | 41  |
    | Paraíba             | João Pessoa    | 83  |
    | Pará                | Belém          | 91  |
    | Pernambuco          | Recife         | 81  |
    | Piauí               | Teresina       | 86  |
    | Rio de Janeiro      | Rio de Janeiro | 21  |
    | Rio Grande do Norte | Natal          | 84  |
    | Rio Grande do Sul   | Porto Alegre   | 51  |
    | Rondonia            | Porto Velho    | 69  |
    | Roraima             | Boa Vista      | 95  |
    | Santa Catarina      | Florianópolis  | 48  |
    | Sergipe             | Aracaju        | 79  |
    | São Paulo           | São Paulo      | 11  |
    | Tocantins           | Palmas         | 63  |
    
    
    Se a entrada for qualquer outro DDD que não esteja presente na tabela acima, o programa deverá informar:
    DDD nao cadastrado
    
    ---
    
    Entrada
    A entrada consiste de um único valor inteiro.
    
    Saída
    Imprima o nome da cidade correspondente ao DDD existente na entrada. Imprima DDD nao cadastrado caso não existir DDD correspondente ao número digitado.
    
    ---
    
    Exemplo de Entrada	Exemplo de Saída
    11
    
    Sao Paulo
*/