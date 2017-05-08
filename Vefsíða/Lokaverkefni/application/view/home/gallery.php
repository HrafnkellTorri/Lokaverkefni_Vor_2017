<div class="container">
    <h1>Gallery</h2>

    <!DOCTYPE html>
    <html>
    <head>
        <title>Gallery</title>
    <body>
    <?php 
        include "dbcon.php";
        include "query.php";

        foreach ($myndir as $entry) {
            echo '<hr><b>'.$entry[0].'</b><br><img src="'.$entry[1].'".jpg width=500px"><br>'; 
        }
    ?>

    </body>
    </html>
</div>