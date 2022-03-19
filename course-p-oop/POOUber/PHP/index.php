<?php
    require_once("car.php");
    require_once("uberX.php");
    require_once("uberPool.php");
    require_once("account.php");
    require_once("uberVan.php");

    $uberX =  new UberX("CSD09", new Account("Alexis Lopez"), "Seat", "Ibiza", "dd");
    $uberX->printDataCar();
    // echo("\n");
    // $uberPool =  new UberX("CSD09", new Account("Alexis Lopez"), "Seat", "Ibiza");
    // $uberPool->printDataCar();
    // echo("\n");
    // $uberVan = new UberVan("CSD09", new Account("Alexis Lopez"), "Seat", "Ibiza");
    // $uberVan->setPassenger(6)

?>
