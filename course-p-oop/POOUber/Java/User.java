package Java;

public class User extends Account{    
    String type;

    public User(String name, String type) {
        super(name);
        this.type = type;
    }
}
  