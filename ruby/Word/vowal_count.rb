VOWAL = ['A','E','I','O','U']
phrase = 'etesta' 
phrase = phrase.upcase
count = 0 

for i in (0..phrase.length)
    for j in VOWAL do 
        if((phrase[i]) == j)
            count += 1
            break
        end
    end
end 

puts(count)