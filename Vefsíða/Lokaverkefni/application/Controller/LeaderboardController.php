<?php

/* Erla Óskarsdóttir & Hrafnkell Þorri Þrastarson
   VEF2A3U Vorönn 2017 Lokaverkefni */

namespace Mini\Controller;

use Mini\Model\Scores;

class LeaderboardController
{

    public function index()
    {
        $User = new Scores();
        $Users = $User->getAllUsersSpacebar(); //Náð í gögn úr Leiknum spacebar
        
        $Type = new Scores();
        $Types = $Type->getAllUsersTyping(); //Náð í gögn úr Leiknum village
        
        $Village = new Scores();
        $Villagers = $Village->getAllUsersVillage(); //Náð í gögn úr Leiknum village
        
        

        //Echoað út views á viðeigandi staði

        require APP . 'view/_templates/header.php'; 

        require APP . 'view/leaderboard/index.php';

        require APP . 'view/_templates/footer.php';
    }
}
