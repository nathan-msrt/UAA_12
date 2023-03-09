<?php
require_once "Model/userModel.php";

$uri = $_SERVER['REQUEST_URI'];

if($uri === '/connexion'){
    require_once "Templates/Users/connexion.php";
}else if ($uri === '/inscription'){
    var_dump($_POST);
    if (isset($_POST["btnEnvoi"])){
        CreateUser($pdo);
        header('location/connexion');
    }
    require_once "Templates/Users/inscriptionOrEditProfil.php";
}else if ($uri === '/profil'){
    require_once "Templates/Users/profil.php";
}
