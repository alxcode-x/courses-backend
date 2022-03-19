package Java;

class Car{
    private Integer id;
    private String license;
    private Account driver;
    private Integer passenger;

    public Car(String license, Account driver){
        this.license = license;
        this.driver = driver;
    }

    public void  PrintDataCar(){
        System.out.println("License: "+license+"   Driver: "+driver.name);
    }

    public Integer GetPassenger(){
        return passenger;
    }

    public void SetPassenger(Integer passenger){
        if (passenger == 4){
            this.passenger =passenger;
        }
        else{
            System.out.println("Solo se aceptan 4 pasajeros.");
        }
    }

    public Integer GetId() {
        return id;
    }

    public void SetId(Integer id) {
        this.id = id;
    }

    public String GetLicense() {
        return license;
    }

    public void SetLicense(String license) {
        this.license = license;
    }

    public Account GetDriver() {
        return driver;
    }

    public void SetDriver(Account driver) {
        this.driver = driver;
    }

    
}