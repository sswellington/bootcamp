require_relative 'Checking'


def test_checking()
    result = true
    balance = 49
    c = Checking.new(05, "Wellington", balance)

    if !(Account.new(03, "Silva", balance).limit == 0.0)
        result = false 
    end

    if !(c.limit == (balance * 0.15))
        result = false 
    end

    if !(c.balance == 49)
        result = false
    end 
    
    if !(c.receive_cash(1) == 50)
        result = false
    end 

    c.cash_withdrawal(10)
    if !(c.balance == 40)
        result = false
    end 
    
    return result
end


puts(test_checking())
