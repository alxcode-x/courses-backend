class Account:
    id = int
    name = str
    document = str
    email = str
    password = str

    def __init__(self, name):
        self.name = name