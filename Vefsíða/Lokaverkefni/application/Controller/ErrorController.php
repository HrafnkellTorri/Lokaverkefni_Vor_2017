<?php

/* Erla Óskarsdóttir & Hrafnkell Þorri Þrastarson
   VEF2A3U Vorönn 2017 Lokaverkefni */

namespace Mini\Controller;

class ErrorController
{

    public function index()
    {
		//Echoað út views á viðeigandi staði
        require APP . 'view/_templates/header.php';
        require APP . 'view/Lokaverkefni/index.php';
        require APP . 'view/_templates/footer.php';
    }
}
