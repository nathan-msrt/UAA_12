<!DOCTYPE html>
<html lang="fr">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Nathan Massart REVISION</title>
    <link rel="stylesheet" href="index.css" type="text/css">
</head>
<body>
    <div class="menu">
        <ul class="flexcontainer justify-content">
            <li><a href="Connexion.php">Connexion</a></li>
            <li><a href="index.php">Accueil</a></li>
            <li><a href="Contact.php">Contact </a></li>
        </ul>
    </div>
    <?php

    
        function pgcd($nbr1, $nbr2){
            $reste = $nbr2;
            while ($reste != 0) {
                $reste = $nbr1 % $nbr2; 
                $nbr1 = $nbr2;
                $nbr2 = $reste;
            }
            return $nbr1;
        }
    function functionspeciale($nombreDepart, $nombreElementsSouhaite){
        $suite = "" . $nombreDepart. " ";
        for ($i= 1 ; $i  < $nombreElementsSouhaite; $i++) {
            if (($nombreDepart < 5) && ($nombreDepart % 3!= 0)) {
                $nombreDepart = $nombreDepart *5;
            }elseif (($nombreDepart > 5) && ($nombreDepart < 10)) {
                $nombreDepart = $nombreDepart / 6;
            }else {
                $nombreDepart = $nombreDepart * $nombreDepart;
            }
           $suite = $suite . $nombreDepart . " ";
            }
           return $suite; 
           
        }

        $nbr1 = 21;
        $nbr2 = 15;
        $phrase = "Bonjour a tous pour ces revisions";

    ?>
    <div class="partiecentrale">
        <h1>Animalerie Tom&Co</h1>
        <h3>Je veux des belles fonctions php (séparer analyse et affichage dans votre fichier)</h3>
        <p> Voici une suite bien spéciale <?=  functionspeciale(5, 6) ?> </p>
        <p> Le PGCD entre <?= $nbr1 ?> et <?= $nbr2?> vaut <?= pgcd($nbr1,$nbr2) ?> </p>
        <h3>Montrer moi comment afficher proprement du code</h3>

        <p>Dans la variable Stableau, voici les nompres pairs</p>
    
        <p>Dans la variable Sphrase "Bonjour à tous pour ces révisions", la dernière lettre de chaque mot est</p>
            
    
    </div>
</body>
</html>