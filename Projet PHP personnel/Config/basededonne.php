<?php
try {
    $strConnection = "mysql:host=10.10.51.252;dbname=nathan;port=3306";


    $pdo = new PDO ($strConnection,  "nathan", "root");
    
} catch (PDOException $e) {
    die("ERREUR ! : " .  $e -> getMessage());
}
?>
