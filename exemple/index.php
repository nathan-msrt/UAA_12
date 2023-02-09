
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
<body>
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
    <main>
        <h1>Liste des biens</h1>
        <p id="lienAgence"><a href="https://www.christinesurges.be/" target="_blank" title="Aller à l'agence">Voir l'agence</a></p>
        <div class="flex wrap space-around">
            <div class="border card">
                <h2 class="center">Villa St Maurice</h2>
                <div>
                    <div class="flex blocImageBien"><img src="https://www.mosal.be/medias/org-500/shared/immobilier--7-.jpg-5cde7ada6932c.jpg" alt="image lorem picsum" /></div>
                    <div class="center">
                        <p><span>250m²</span> - <span>Gembloux</span></p>
                        <h3>250000€</h3>
                        <a href="voirLeBien.html" class="btn btn-page">Voir le bien</a>
                    </div>
                </div>
            </div>
            <div class="border card">
                <h2 class="center">Villa bella</h2>
                <div>
                    <div class="flex blocImageBien"><img src="https://st3.idealista.it/cms/archivie/styles/idcms_social_tablet/public/2019-09/media/image/dl_a01054196.jpg" alt="image lorem picsum" /></div>
                    <div class="center">
                        <p><span>300m²</span> - <span>Bruxelles</span></p>
                        <h3>310000€</h3>
                        <a href="voirLeBien.html" class="btn btn-page">Voir le bien</a>
                    </div>
                </div>
            </div>
            <div class="border card">
                <h2 class="center">Immeuble de fortune</h2>
                <div>
                    <div class="flex blocImageBien"><img src="https://web.static-rmg.be/if/c_crop,w_1000,h_666,x_0,y_0,g_center/c_fit,w_620,h_412/9b8b71585ef78d48c964356b2b72b562.jpg" alt="image lorem picsum" /></div>
                    <div class="center">
                        <p><span>150m²</span> - <span>Charleroi</span></p>
                        <h3>250000€</h3>
                        <a href="voirLeBien.html" class="btn btn-page">Voir le bien</a>
                    </div>
                </div>
            </div>
            <div class="border card">
                <h2 class="center">Cabane en bois</h2>
                <div>
                    <div class="flex blocImageBien"><img src="https://static.wixstatic.com/media/9eff6a_20c7ede9369f42edb16828190737f0ad~mv2.jpg/v1/crop/x_688,y_0,w_3724,h_3401/fill/w_380,h_347,al_c,q_80,usm_0.66_1.00_0.01,enc_auto/DJI_0870_1_2_3_4%202.jpg" alt="image lorem picsum" /></div>
                    <div class="center">
                        <p><span>150m²</span> - <span>Ardenne</span></p>
                        <h3>156000€</h3>
                        <a href="voirLeBien.html" class="btn btn-page">Voir le bien</a>
                    </div>
                </div>
            </div>
        </div>
    </main>
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
</body>
</html>
