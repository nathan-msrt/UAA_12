<!DOCTYPE html>
<html lang="fr">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>massart_nathan_examen</title>
    <link href="index.css" rel="stylesheet">
</head>
<body>
    <?php 
        function diviseurs($nb,$diviseurs){
            $i = 1;
            $diviseurs = "";
            while ($i <= $nb) {
                if ($nb % $i = 0) {
                    $diviseurs = $diviseurs + $i + "";
                }
            }
            $i = $i +1;
            return $diviseurs;
        }
        function triangle($C1, $C2, $C3, $message){
            if (($C1>=$C2) && ($C1 >= $C3)) {
                $pg =$C1;
                $Cote2 =$C2;
                $Cote3 =$C3;
            }elseif (($C2 >=$C1)&& ($C2 >= $C3)) {
                $pg =$C2;
                $Cote2 =$C1;
                $Cote3 =$C3;
            }else {
                $pg =$C3;
                $Cote2 =$C1;
                $Cote3 =$C2;
            }
            if ($pg<$Cote2 + $Cote3) {
                if (($pg^2 == $Cote2^2 + $Cote3^2)){
                    if ($Cote2 = $Cote3) {
                        $message = "Triangle rectangle isocèle";
                    }else {
                        $message ="Triangle rectangle";
                    }
                }else {
                    $message ="Le triangle n'est pas rectangle";
                }
            }else {
                $message ="Ces dimensions ne peuvent être celles d'un triangle";
            }
            return $message;
        }
    ?>
    <div >
        <ul class="partieduhaut">
            <li> <a href="index.php">Home</a></li>
            <li> <a href="fonction.php">Fonction</a></li>
            <li> <a href="contact.php">Contact</a></li>
        </ul>
    </div>
    <div class="partiecentrale">
      <div>
        <div>
            <h1>Affichage avec des fonctions PHP</h1>
        </div>
        <div>
            <div>
                <h2>Trouver les diviseurs d'un nombre</h2>
                <p> Le nombre <?= $nb ?> a <?= $diviseurs ?> comme diviseurs</p>
            </div>
            <div>
                <h2>Est-ce un triangle rectangle et lequel</h2>
                <p> <?= $message ?> </p>
            </div>
        </div>
      </div>
      <div>
        <h1>Affichage sans fonctions PHP</h1>
      </div>
    </div>
    <div class="partiedubas">
        <div>
            <p> Examen 2022-2023
            UAA12: Création d'un site web dynamique</p>
        </div>
        <div>
            <p>5TI</p>
        </div>
    </div>
</body>