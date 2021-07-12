require_relative 'Account'


class Checking < Account
    def initialize(number, title, balance)
        super(number, title, balance)
        @limit = balance * 0.15
    end
end
