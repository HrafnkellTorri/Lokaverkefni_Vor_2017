
<!-- Erla Óskarsdóttir & Hrafnkell Þorri Þrastarson
   VEF2A3U Vorönn 2017 Lokaverkefni -->


<div class="main">
<div class="intainer">
    <hr>
    <h1>SpaceBar Highscores</h1>
    <hr>
        <table>
            
            <thead style="background-color: red; font-weight: bold;">
            <tr>
                <td>Rank</td>
                <td>Username</td>
                <td>Nationality</td>
                <td>Highscore</td>
            </tr>
            </thead>
            <?php $counter = 0; ?>
            <?php foreach ($Users as $user) { ?>
            <?php $counter++; ?>
            <tr>
                <td><?php  echo $counter;  ?></td>
                <td><?php if (isset($user->username)) echo htmlspecialchars($user->username, ENT_QUOTES, 'UTF-8'); ?></td>
                <td><?php if (isset($user->country)) echo htmlspecialchars($user->country, ENT_QUOTES, 'UTF-8'); ?></td>
                <td><?php if (isset($user->score)) echo htmlspecialchars($user->score, ENT_QUOTES, 'UTF-8'); ?></td>
                <?php } ?> 
                </tr>
                </table>
             <br><h3> Number of Users that have played Spacebar: <?php echo $counter; ?></h3>
                <hr>
                <h1>Village Highscores</h1>
                <hr>
                <table>
                <thead style="background-color: red; font-weight: bold;">
                <tr>
                <td>Rank</td>
                <td>Username</td>
                <td>Nationality</td>
                <td>Highscore</td>
                </tr>
                </thead>

                <?php $counter = 0; ?>
                <?php foreach ($Villagers as $village) { ?>
                <?php $counter++; ?>
                <tr>
                <td><?php  echo $counter;  ?></td>
                <td><?php if (isset($village->username)) echo htmlspecialchars($village->username, ENT_QUOTES, 'UTF-8'); ?></td>
                <td><?php if (isset($village->country)) echo htmlspecialchars($village->country, ENT_QUOTES, 'UTF-8'); ?></td>
                <td><?php if (isset($village->score)) echo htmlspecialchars($village->score, ENT_QUOTES, 'UTF-8'); ?></td>
                <?php } ?> 
                </tr>
                </table>
               <br> <h3>Number of Users that have played Village: <?php echo $counter; ?></h3>

                <table>
                <hr>
        <h1>Typing game Highscores</h1>
                <hr>
                <thead style="background-color: red; font-weight: bold;">
                <tr>
                    <br>
                <td>Rank</td>
                <td>Username</td>
                <td>Nationality</td>
                <td>Highscore</td>
                    
            </tr>
            </thead>
                <?php $counter = 0; ?>
                <?php foreach ($Types as $type) { ?>
            <?php $counter++; ?>
            <tr>
                <td><?php  echo $counter;  ?></td>
                <td><?php if (isset($type->username)) echo htmlspecialchars($type->username, ENT_QUOTES, 'UTF-8'); ?></td>
                <td><?php if (isset($type->country)) echo htmlspecialchars($type->country, ENT_QUOTES, 'UTF-8'); ?></td>
                <td><?php if (isset($type->score)) echo htmlspecialchars($type->score, ENT_QUOTES, 'UTF-8'); ?></td>
                <?php } ?> 
                 </table>
                    <br><h3>Number of Users that have played Village: <?php echo $counter; ?></h3>
        <br>
