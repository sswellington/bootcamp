require_relative 'Client'


class Account

    # method getter and setter
    attr_accessor :balance, :limit
    
    # method getter
    attr_reader :number, :title

    # method setter
    # attr_writer :balance
 

    def initialize(number, title, balance)
        @balance = balance
        @limit = 0.0
        @number = number
        @title = title
    end


    def cash_withdrawal(value)
        if check_limit(value)
            self.balance -= value
            return true
        else 
            puts("Error: limit reached")
            return false
        end
    end


    def check_limit(value)
        return self.limit <= (self.balance - value)
    end
        

    def receive_cash(value)
        self.balance += value
    end


    def send_cash(value, recipient)
        if cash_withdrawal(value)
            recipient.receive_cash(value)
        end
    end 
end
