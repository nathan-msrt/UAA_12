<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Massart Nathan</title>
</head>
<body>
    <?php echo "Hello World!" ?>
    <h1>EXERCICE 1</h1>
    <?php
        for ($i = 1; $i <= 10; $i++) {
            echo "<p> le nombre vaut ". $i ."</p>";
        }
     ?>
     <h1>EXERCICE 2</h1>
    <?php
        for ($i = 1; $i <= 10; $i++) {
            if ($i != 3){
                echo "<p> le nombre vaut ". $i ."</p>";
            }
            
        }
    ?>
    <h1>EXERCICE 3</h1>
    <?php
        for ($i = 1; $i <= 10; $i++) {
            if ($i < 4 || $i > 7){
                echo "<p> le nombre vaut ". $i ."</p>";
            }
            
        }
    ?>
    <h1>EXERCICE 4</h1>
    <?php
        $n=-5;
        echo "<p> La valeur absolue de ". $n ."</p>";
        
    ?>
    

           
</body>
</html>