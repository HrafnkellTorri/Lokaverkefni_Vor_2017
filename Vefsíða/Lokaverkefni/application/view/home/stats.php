<div class="container">
    <h1>Information</h2>

    <?php
		$url ="info.json";
		$json = file_get_contents($url,".:/application/view/home");
		$row = json_decode($json,true);
	?>

	<!DOCTYPE html>
    <html>
    <head>
        <title>Games</title>
    <body>

   	<?php
        foreach ($row as $key => $value)
        {
            echo  "<h3>" . $key . "</h3>" .  $value .  "<br><br>";
        }
    ?>

    </body>
    </html>
</div>
