class Client

    # method getter and setter
    attr_accessor :name
    
    # method getter
    attr_reader :id


    def initialize(id, name)
        @id = id
        @name = name
    end
end 
