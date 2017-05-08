<?php

/* Erla Óskarsdóttir & Hrafnkell Þorri Þrastarson
   VEF2A3U Vorönn 2017 Lokaverkefni */

namespace Mini\Controller;

class HomeController
{
   
    public function index()
    {
		//Echoað út views á viðeigandi staði
        require APP . 'view/_templates/header.php';
        require APP . 'view/home/index.php';
        require APP . 'view/_templates/footer.php';
    }
    public function typing()
    {
		//Echoað út views á viðeigandi staði
        require APP . 'view/_templates/header.php';
        require APP . 'view/home/typing.php';
        require APP . 'view/_templates/footer.php';
    }
  


    public function stats()
    {
        //Echoað út views á viðeigandi staði
        require APP . 'view/_templates/header.php';
        require APP . 'view/home/stats.php';
        require APP . 'view/_templates/footer.php';
    }

   
    public function gallery()
    {
        //Echoað út views á viðeigandi staði
        require APP . 'view/_templates/header.php';
        require APP . 'view/home/gallery.php';
        require APP . 'view/_templates/footer.php';
    }
}
