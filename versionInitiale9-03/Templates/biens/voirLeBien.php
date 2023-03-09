<h1>Voir le bien</h1>
<div class="flex space-around wrap">
    <div class="blocGauche center">
        <h2>Image du bien</h2>
        <img id="imageBien" src="Images/immeuble.jpg" alt="image d'un immeuble" />
    </div>
    <div class="center">
        <h2>Informations</h2>
        <h3>Immeuble de fortune</h3>
        <p><span>300m²</span> - <span>Bruxelles</span></p>
        <p>Nombre de chambres : 3</p>
        <h3>310000€</h3>
        <p>M'envoyer un <a href="mailto:pierre.giraud@edhec.com">email</a></p>
    </div>
</div>
<div class="flex space-around wrap">
    <div class="blocGauche center">
        <h2>Description</h2>
        <p class="justify">
            Lorem ipsum, dolor sit amet consectetur adipisicing elit. 
            Repudiandae voluptate recusandae alias, accusamus eligendi officia nesciunt omnis suscipit 
            optio pariatur fugiat illum sunt commodi voluptatibus aliquam culpa laborum illo repellat 
            at adipisci consequatur laudantium maiores voluptates non! Quasi sapiente quidem quisquam veniam mollitia, 
            perspiciatis et blanditiis maxime, magnam minima repudiandae assumenda asperiores placeat nostrum reiciendis 
            voluptatem ipsum harum? Recusandae sed repellat impedit aliquid placeat architecto quibusdam suscipit. 
            Nobis id ducimus, accusantium voluptates, ad exercitationem perferendis tempora tenetur sapiente laudantium 
            voluptas. 
        </p>
    </div>
    <div class="center">
        <h2>Données</h2>
        <table>
            <thead>
                <tr>
                    <th>Informations</th>
                    <th>Données</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>Nombre de chambres</td>
                    <td>3</td>
                </tr>
                <tr>
                    <td>Nombre de salles de bain</td>
                    <td>1</td>
                </tr>
                <tr>
                    <td rowspan="4">Options</td>
                </tr>
                <tr>
                    <td>Ascenseur</td>
                </tr>
                <tr>
                    <td>chauffage à gaz</td>
                </tr>
                <tr>
                    <td>balcon</td>
                </tr>
                <tr>
                    <td>Cave</td>
                    <td>OUI (mais partagé)</td>
                </tr>
                <tr>
                    <td>PEB</td>
                    <td>B</td>
                </tr>
            </tbody>
        </table>
    </div>
</div>
<div class="flex space-around wrap">
    <div class="center">
        <h2>Visite de l'intérieur</h2>
        <iframe src="https://www.youtube.com/embed/6jX-0hIQxhY" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
    </div>
    <div class="center">
        <h2>Emplacement</h2>
        <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d80598.59947276005!2d4.3754171!3d50.855123999999996!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x47c3a4ed73c76867%3A0xc18b3a66787302a7!2sBruxelles!5e0!3m2!1sfr!2sbe!4v1654706988975!5m2!1sfr!2sbe" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>
    </div>
</div>
<div class="center form">
    <h2>Contacter la personne</h2>
    <div class="form-group">
        <input type="email">
        <div class="flex justify-content-center align-item-center">
            <button id="btn-send" class="btn btn-send">Envoyer</button>
            <img id="imageLettre" src="Images/lettre.png" alt="Image d'une lettre">
        </div>
    </div>
</div>