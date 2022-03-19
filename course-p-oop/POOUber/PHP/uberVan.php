<?php

require_once('car.php');

class UberVan extends Car{
    public $typeCarAccepted;
    public $seatsMaterial;

    public function _construct($license, $driver, $typeCarAccepted, $seatsMaterial)
    {
        parent::__construct($license, $driver);
        $this->seatsMaterial = $seatsMaterial;
        $this->seatsMaterial = $seatsMaterial;
    }

    public function setPassenger($passenger){
        if ($passenger == 6){
            $this->passenger = $passenger;
            echo "6 pasajeros asignados.";
        }
        else{
            echo "Debes ingresar 6 pasajeros.";
        }
    }
}

?>