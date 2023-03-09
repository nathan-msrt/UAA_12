<?php
function CreateUser($pdo)
{
    try {
        if (isset ($_POST["btnEnvoi"])) {
            $query = "insert into utilisateur (utilisateurNom, utilisateurPrenom, utilisateurPseudo, utilisateurEmail,  utilisateurMotDePasse, utilisateurRole) values ( :utilisateurNom, :utilisateurPrenom, :utilisateurPseudo, :utilisateurEmail, :utilisateurMotDePasse, :utilisateurRole)";
            $ajouteUser = $pdo->prepare($query);
            $ajouteUser->execute([
                'utilisateurNom'=> $_POST ['nom'],
                'utilisateurPrenom'=>$_POST ['prenom'],
                'utilisateurPseudo'=>$_POST ['pseudo'],
                'utilisateurMotDePasse'=>$_POST ['mot_de_passe'],
                'utilisateurEmail'=>$_POST ['email'],
                'utilisateurRole'=> 'user'
            ]);
        }
    } catch (PDOException $e) {
        die($e -> getMessage());
    }
}
/*try {
    $query = "SELECT * FROM biens";
    $ajoute = $pdo->prepare($query);
    $ajoute->execute();
    $biens = $ajoute->fetchAll();
} catch (PDOException $e) {
    $message = $e->getMessage();
    die($message);
}
echo '<pre>' , var_dump($biens) , '</pre>';*/