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
    <?php for ($i = 1; $i <= 10; $i++) : ?>
        <p> le nombre vaut <?=  $i ?> </p>
    <?php endfor ?>
     
    <h1>EXERCICE 2</h1>
    <?php for ($i = 1; $i <= 10; $i++) : ?>
        <?php if ($i != 3) : ?>
             <p> le nombre vaut <?= $i ?> </p>
        <?php endif ?>
    <?php endfor ?>
    
    <h1>EXERCICE 3</h1>
    <?php for ($i = 1; $i <= 10; $i++) :?> 
        <?php if ($i < 4 || $i > 7) : ?>
            <p> le nombre vaut <?= $i ?> </p>
        <?php endif ?>
    <?php endfor ?>      
   
    <h1>EXERCICE 4</h1>
    <?php
        $nbr1 = -5;
        $nbr2 = 10;   
    ?>
    <p> La valeur absolue de <?= $nbr1 ?> vaut <?= abs($nbr1) ?> </p>
    <p> La valeur absolue de <?= $nbr2 ?> vaut <?= abs($nbr2) ?> </p>

           
</body>
</html>