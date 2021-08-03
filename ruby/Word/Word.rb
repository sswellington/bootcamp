class Word

    def initialize()
    end


    def accentuations_count(phrase)
        accentuation = [' ', ',','.'] 
        count = 0 
        for i in (0..phrase.length)
            for j in accentuation do 
                if((phrase[i]) == j)
                    count += 1
                    break
                end
            end
        end 
        return count
    end 

    
    def vowels_count(phrase)
        vowels_more_y = [
							'A','E','I','O','U','Y', 
							'Ã','Ẽ','Ĩ','Õ', 
							'Á','Í','É','Ó','Ú',
							'À','È','Ì','Ò','Ù'
						] 
        phrase = phrase.upcase
        count = 0 
        for i in (0..phrase.length)
            for j in vowels_more_y do 
                if((phrase[i]) == j)
                    count += 1
                    break
                end
            end
        end 
        return count
    end 


    def consonants_count(phrase)
        return (phrase.length - self.vowels_count(phrase) - self.accentuations_count(phrase))
    end
end 
