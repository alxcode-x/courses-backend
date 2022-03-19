from account import Account

class User(Account):
    type = str

    def __init__(self, name):
        super.__init__(name, type)
        self.type = type
