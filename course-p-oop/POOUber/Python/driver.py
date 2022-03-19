from account import Account

class Driver(Account):
    type = str

    def __init__(self, name):
        super.__init__(name, type)
        self.type = type
