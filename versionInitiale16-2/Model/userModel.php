<?php
function CreateUser($pdo)
{
    try {
        if (isset ($_POST["btnEnvoi"])) {
            $query = "insert into utilisateurs(nomUser, prenomUser, loginUser, emailUser,  passWordUser, role) values ( :nomUser, :prenomUser, :loginUser, :emailUser, :passWordUser, :role)";
            $ajouteUser = $pdo->prepare($query);
            $ajouteUser->execute([
                'nomUser'=> $_POST ['txtNom'],
                'prenomUser'=>$_POST ['txtPrenom'],
                'loginUser'=>$_POST ['txtLogin'],
                'passWordUser'=>$_POST ['txtMp'],
                'emailUser'=>$_POST ['txtEmail'],
                'role'=> 'user'
            ]);
        }
    } catch (PDOException $e) {
        die($e -> getMessage());
    }
}
try {
    $query = "SELECT * FROM biens";
    $ajoute = $pdo->prepare($query);
    $ajoute->execute();
    $biens = $ajoute->fetchAll();
} catch (PDOException $e) {
    $message = $e->getMessage();
    die($message);
}
echo '<pre>' , var_dump($biens) , '</pre>';