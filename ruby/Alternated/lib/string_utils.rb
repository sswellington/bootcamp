class StringUtils

	def wavefy(phrase)
		down = phrase.downcase
		phrase = phrase.upcase
		result = ''
		for i in (0..phrase.length)
			if (i % 2) == 0  
				result += String(down[i])
			else
				result += String(phrase[i])
			end
		end
		return result
  	end
end
