<?php

$uri = $_SERVER['REQUEST_URI'];

if($uri === '/index.php' || $uri === "/" ){
    require_once "Templates/Biens/voirTousLesBiens.php";
}else if ($uri === '/voirLeBien'){
    require_once "Templates/Biens/voirLeBien.php";
}