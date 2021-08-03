class StringUtils

    def wavefy(phrase)
      for i in (0..phrase.length)
          if (i % 2) == 0  
              l = phrase[i]
              puts(l.upcase)
          else
              puts(phrase[i])
              # phrase[i] = letter.downcase 
          end
      end
      return phrase
    end
  end
  
  
  a = StringUtils.new()
  puts(a.wavefy('test'))
  