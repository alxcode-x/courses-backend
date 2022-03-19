//Native JS
// UberPool.prototype = new Car(license, driver, brand, model)
// {
//     this.brand = brand;
//     this.model = model;
// }

//EcmaScript 6
class UberPool extends Car{
    constructor(license, driver, brand, model){
        super(license, driver);
        this.brand = brand;
        this.model = model;
    }
}