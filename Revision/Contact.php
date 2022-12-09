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
        <form action="">
            <fieldset class="cadre">
                <legend>Formulaire de contact</legend>
                <div>
                    <label for="nom"> Nom </label>
                    <input type="text" name="nom" id="nom">
                </div>
                <div>
                    <label for="Prénom"> Prénom </label>
                    <input type="text" name="Prénom" id="Prénom">
                </div>
                <div>
                    <label for="Email"> Email </label>
                    <input type="text" name="Email" id="Email">
                </div>
                <div>
                    <label for=" Numéro de téléphone"> Numéro de téléphone</label>
                    <input type="text" name=" Numéro de téléphone" id=" Numéro de téléphone">
                </div>
                <div>
                    <label for="message">Votre message</label>
                    <textarea id="message" name="message" id="message"></textarea>
                </div>
                <div class ="bouton">
                    <input type="submit" value="Soumettre">
                </div>
            </fieldset>
            
        </form>
    </div>
</body>
</html>