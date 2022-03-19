<?php

require_once('car.php');

class UberBlack extends Car{
    public $typeCarAccepted;
    public $seatsMaterial;

    public function _construct($license, $driver, $typeCarAccepted, $seatsMaterial)
    {
        parent::__construct($license, $driver);
        $this->seatsMaterial = $seatsMaterial;
        $this->seatsMaterial = $seatsMaterial;
    }
}

?>