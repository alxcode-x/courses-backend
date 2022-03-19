from account import Account
from car import Car

if __name__ == "__main__":
    print("Hola Mundo")
    car = Car("123dqw", Account("Alexis Lopez"))
    
    print(vars(car))
    print(vars(car.driver))