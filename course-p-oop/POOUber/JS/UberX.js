//Native JS
// function UberX(license, driver, brand, model){
//     Car.call(this, license, driver)
//     this.brand = brand;
//     this.model = model;
// }

//EcmaScript 6
class UberX extends Car{
    constructor(license, driver, brand, model){
        super(license, driver);
        this.brand = brand;
        this.model = model;
    }
}