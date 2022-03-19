package Java;

import java.util.ArrayList;
import java.util.Map;

public class UberVan extends Car{
    Map<String, Map<String,Integer>> typeCarAccepted;
    ArrayList<String> seatsMaterial;
    private Integer passenger;
  

    public UberVan(String license, Account driver) {
        super(license, driver);
    }
    
    @Override
    public void SetPassenger(Integer passenger){
        if (passenger == 6){
            this.passenger = passenger;
            System.out.println("6 pasajeros asignados");
        }
        else{
            System.out.println("Solo se aceptan 6 pasajeros.");
        }
    }
}
