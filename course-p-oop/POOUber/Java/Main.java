package Java;

public class Main{
 
    public static void main(String[] args) {
        //System.out.println("Hola Mundo");

        // Car car = new Car("1234", new Account("Alexis Lopez"));
        // Car car2 = new Car("das12", new Account("Francisco Avila"));

        // // car.license = "1234";
        // // car.driver = "Alexis Lopez";

        // // car2.license = "12dq";
        // // car2.driver = "Francisco Avila";

        // car.PrintDataCar();
        // car2.PrintDataCar();
        // car.SetPassenger(4);

        UberVan van = new UberVan("xxx", new Account("Alexis Lopez"));

        van.SetPassenger(6);

    }
}