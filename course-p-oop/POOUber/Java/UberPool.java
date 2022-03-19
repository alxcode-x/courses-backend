package Java;

public class UberPool extends Car{
    String brand;
    String model;

    public UberPool(String license, Account driver, String brand, String model){
        super(license, driver); //super refer to objects in Car
        this.brand = brand; // this refer to loca objects
        this.model = model;
    }
}
