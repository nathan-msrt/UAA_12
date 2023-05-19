<!DOCTYPE html>
<html lang="fr">
    <head>
        <meta charset="UTF-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link rel="stylesheet" href="CSS/index.css">
        <link rel="stylesheet" href="CSS/animation.css">
        <title>Mon agence</title>
    </head>
    <header>
        <ul class="flex space-evenly">
            <li class="menu"><a href="index.php">Home</a></li>
            <li  class="menu"><a href="seconnecter.php">Se connecter</a></li>
            <li  class="menu"><a href="sinscrire.php">S'inscrire</a></li>
            <li  class="menu"><a href="profil.php">Page profil</a></li>
            <li class="imageMenu"><a href="index.php"><ion-icon size="large" name="home-outline"></ion-icon></a></li>
            <li class="imageMenu"><a href="seconnecter.php"><ion-icon size="large" name="bag-add-outline"></ion-icon></a></li>
            <li class="imageMenu"><a href="sinscrire.php"><ion-icon size="large" name="log-in-outline"></ion-icon></a></li>
            <li class="imageMenu"><a href="profil.php"><ion-icon size="large" name="person-outline"></ion-icon></a></li>
        </ul>
    </header>
    <body>
        <div class="formulaire">
            <form action="">
                <fieldset class="">
                    <legend>S'inscrire</legend>
                    <div>
                        <label for="nom"> Nom :</label>
                        <input type="text" name="nom" id="nom">
                    </div>
                    <div>
                        <label for="Prénom"> Prénom :</label>
                        <input type="text" name="Prénom" id="Prénom">
                    </div>
                    <div>
                        <label for="Email"> Email :</label>
                        <input type="text" name="Email" id="Email">
                    </div>
                    <div>
                        <label for="motdepasse">Mot de passe :</label>
                        <input type="text" name="motdepasse" id="motdepasse">
                    </div>
                    <div>
                        <input class="btn-page btn" type="submit" value="Connexion" name="bouton" id="bouton">
                    </div>
                </fieldset>
            </form>
        </div>
    </body>
    <footer>
        <div class="flex space-between align-item-center">
            <p><a href="https://www.christinesurges.be/" target="_blank" title="Aller à l'agence">Voir l'agence</a></p>
            <div>
                <img class="imageIcon" src="Images/icon1.jpg" alt="image twitter">
                <img class="imageIcon" src="Images/icon2.jpg" alt="image facebook">
                <img class="imageIcon" src="Images/icon3.jpg" alt="image google">
            </div>
        </div>
    </footer>
    <script type="module" src="https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.esm.js"></script>
    <script nomodule src="https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.js"></script>
</html>