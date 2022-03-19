package Java;

public class UberX  extends Car{
    String brand;
    String model;

    public UberX(String license, Account driver, String brand, String model){
        super(license, driver); //super refer to objects in Car
        this.brand = brand; // this refer to loca objects
        this.model = model;
    }

    
}

