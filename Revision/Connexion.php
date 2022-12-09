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
    <div>
        <fieldset class="">
            <legend>Formulaire de connexion</legend>
            <div>
                <label for="nom"> Nom</label>
                <input type="text" name="nom" id="nom">
            </div>
            <div>
                <label for="Prénom"> Prénom</label>
                <input type="text" name="Prénom" id="Prénom">
            </div>
            <div>
                <label for="Email"> Email </label>
                <input type="text" name="Email" id="Email">
            </div>
            <div>
                <label for="Mot de passe">Mot de passe </label>
                <input type="text" name="Mot de passe" id="Mot de passe">
            </div>
            <div class="bouton">
                <input type="submit" value="Connexion">
            </div>
        </fieldset> 
    </div>
</body>
</html>