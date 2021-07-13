array = ['a', 'B', 'b', 'b', 'C', 'c', 'd', 'E', 'e', 'f', 'F', 'g']
contador = 0

for letter in array do
    contador = contador + 1 if letter == letter.upcase 
end

puts contador