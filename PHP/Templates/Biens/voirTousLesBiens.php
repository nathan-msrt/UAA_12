<?php

    #die(phpinfo());

    require_once "Config/basededonne.php";

    $sth = $pdo->prepare("select * from utilisateur");

    $sth->execute();

    /* Récupération de toutes les lignes d'un jeu de résultats */ 
    print("Récupération de toutes les lignes d'un jeu de résultats :\n"); 
    $result = $sth->fetchAll(PDO::FETCH_OBJ); 
    print_r($result);
?>


<!DOCTYPE html>
<html lang="fr">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="CSS/index.css">
    <link rel="stylesheet" href="CSS/animation.css">
    <title>TerraGame</title>
</head>
<body>
    
</body>
</html>