dd = gets.strip.to_i

yyyy = dd / 365
dd %= 365

mm = dd / 30
dd %= 30

puts "#{yyyy} ano(s)"
puts "#{mm} mes(es)"
puts "#{dd} dia(s)"