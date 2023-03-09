<?php
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
</head>
<body>
    <header>
        <ul class="flex space-evenly">
            <li class="menu"><a href="index.php">Home</a></li>
            <li  class="menu"><a href="/profil">Page profil</a></li>
            <li  class="menu"><a href="/connexion">Connexion</a></li>
            <li class="imageMenu"><a href="/"><ion-icon size="large" name="home-outline"></ion-icon></a></li>
            <li class="imageMenu"><a href="/profil"><ion-icon size="large" name="person-outline"></ion-icon></a></li>
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
            <p><a href="https://www.christinesurges.be/" target="_blank" title="Aller à l'agence">Voir d'autres jeux</a></p>
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
