<?php
session_start();
    require_once "Config/databaseConnexion.php";
?>
<!DOCTYPE html>
<html lang="fr">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="CSS/index.css">
    <link rel="stylesheet" href="CSS/animation.css">
    <link rel="stylesheet" href="CSS/flex.css">
    <link rel="stylesheet" href="CSS/form.css">
    <title>Game Center</title>
    <link rel="shortcut icon" type="Images/png" href="Images/GC.png"/>
</head>
<body>
            
    <header>
        <ul class="">
            <div class = "flex space-around">
                <li class="menu"><a href="/">Home</a></li>
                <li  class="menu"><a href="profil">Page profil</a></li>
                <li  class="menu"><?php if(isset($_SESSION['user'])) : ?>
                            <a href ="deconnexion">Déconnexion</a>
                    <?php else : ?>
                            <a href="connexion">Connexion</a>
                            <?php endif ?></li> 
            </div>
        </ul>
    </header>
    <main>
        
        <?php
        require_once "Controller/biensController.php";
        require_once "Controller/usersController.php";
        ?>
    </main>
    <footer>
        <div class="flex space-between align-item-center">
        <p id="lienAgence"><a href="https://www.jeuxvideo.com/meilleurs/moment/" target="_blank" title="Aller à l'agence">Les jeux du moment</a></p>
            <div>
                <img class="imageIcon" src="Images/icon1.jpg" alt="image twitter">
                <img class="imageIcon" src="Images/icon2.jpg" alt="image facebook">
                <img class="imageIcon" src="Images/icon3.jpg" alt="image google">
            </div>
        </div>
    </footer>
    <script type="module" src="https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.esm.js"></script>
    <script nomodule src="https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.js"></script>
</body>
</html>
