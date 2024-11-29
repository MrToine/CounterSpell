# Counter Spell

**Counter Spell** est un jeu de duel de magie en vue à la troisième personne.

## Gameplay

Deux joueurs s'affrontent en duel et disposent de plusieurs capacités pour remporter la victoire :

- **Sorts simples**  
- **Sorts avancés**  
- **Esquives**  
- **Parades**  
- **Contresorts**  

## Mécaniques principales

- **Style graphique** :  
  Le jeu adopte un design stylisé, situé entre la bande dessinée et un style semi-réaliste, avec une touche cartoon.

- **Système de sorts** :  
  Les sorts utilisent une mécanique basée sur des symboles.

- **Gestion de l'endurance** :  
  - Les esquives et parades consomment de l'endurance.  
  - L'endurance est limitée et se régénère lentement au cours du combat.  

- **Contresorts** :  
  - Une parade effectuée au bon moment devient un contresort.  
  - Le contresort renvoie une partie des dégâts à l'adversaire.  
  - Consommation d’endurance du contresort : **0**.  

## Mecanique de Gameplay
Le jeu tourne principalement autour de sa mécanique de création de sorts Chaque sorts sera composé de 4 runes :
- Une rune élémentaire qui determineras les effets du sorts.
- Une rune de forme qui determinera le type du sort
- Deux runes de puissance qui determine la vitesse de lancement et la puissance du sort

Pour le moments certaines combinaison ne sont pas faisable ou urgentes. Je surligne en vert celle que l'on fait. je me pencherais sur les autres plus tards
Nou ne faisons pour le moment que des sorts composé de 4 runes

Il sera aussi possible de créer des sorts "rapides" qui seront composé de deux runes. Une élémentaire et une de formes.
Ces sorts seront faibles et n'auront pas d'incantation, ils serviront principalement a géner

### Runes
Les runes sont les composant d’un sortilège.
Lors de la création vous devez choisir le type de magie, selon le type plusieurs catégorie de
symbole seront disponible.
Par exemple, la magie élémentaire. Elle permet de convoquer les éléments naturels pour
frapper l'ennemi ou invoquer les éléments sous plusieurs formes afin de vous soutenir.
catégorie de rune : élément, forme, puissance

#### Runes élémentaires
<table border="1" style="border-collapse: collapse; text-align: left;">
    <thead>
        <tr>
            <th>Nom de la Rune</th>
            <th>Effet</th>
            <th>Impact Visuel</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>Feu</td>
            <td>Inflige des dégâts de brûlure continues.</td>
            <td>Particules rouge-orange intenses, flammes volumétriques et ondulantes.</td>
        </tr>
        <tr>
            <td>Eau</td>
            <td>Inonde une zone ou apaise (effet de soin possible).</td>
            <td>Particules bleues translucides et fluides, effet de vagues.</td>
        </tr>
        <tr>
            <td>Terre</td>
            <td>Renforce la défense et stabilise les attaques.</td>
            <td>Texture terreuse, particules marron-vert avec fragments de pierre.</td>
        </tr>
        <tr>
            <td>Vent</td>
            <td>Repousse les ennemis et accélère le lanceur.</td>
            <td>Traînées blanches vives et légères, effets de tourbillons rapides.</td>
        </tr>
        <tr>
            <td>Lumière</td>
            <td>Inflige des dégâts sacrés ou soigne les alliés.</td>
            <td>Particules dorées, éclats lumineux, halo clair et étincelant.</td>
        </tr>
        <tr>
            <td>Ténèbres</td>
            <td>Draine la vie de l'ennemi, avec des effets d'ombre.</td>
            <td>Aura violette-noire, fumée sombre avec des volutes mouvants.</td>
        </tr>
        <tr>
            <td>Électricité</td>
            <td>Inflige des dégâts en chaîne et étourdit.</td>
            <td>Éclairs jaune vif, éclats, particules agitées et bondissantes.</td>
        </tr>
        <tr>
            <td>Végétation</td>
            <td>Invoque des lianes ou soigne les alliés.</td>
            <td>Particules vertes, effets de croissance, feuilles et vignes apparaissant.</td>
        </tr>
        <tr>
            <td>Glace</td>
            <td>Inflige des dégâts de froid et ralentit les ennemis.</td>
            <td>Particules glacées bleues, reflets translucides, cristaux de givre.</td>
        </tr>
        <tr>
            <td>Métal</td>
            <td>Augmente la défense et les effets d'attaque physique.</td>
            <td>Texture métallique argentée, éclats de lumière rigides et éclats métalliques.</td>
        </tr>
        <tr>
            <td>Nécromancie</td>
            <td>Draine l'énergie de l'ennemi pour régénérer le lanceur.</td>
            <td>Aura sombre verte, craches et ombres entourant le lanceur.</td>
        </tr>
        <tr>
            <td>Acide</td>
            <td>Corrode et réduit l'armure ennemie.</td>
            <td>Gouttes vert-jaune visqueuses, nuage acide flottant et fumée toxique.</td>
        </tr>
        <tr>
            <td>Tempête</td>
            <td>Crée une tempête de vent et d'éclairs.</td>
            <td>Nuages tourbillonnants gris, éclairs intermittents et vents violents.</td>
        </tr>
    </tbody>
</table>

#### Runes de forme
<table border="1" style="border-collapse: collapse; text-align: left;">
    <thead>
        <tr>
            <th>Nom de la Rune</th>
            <th>Effet</th>
            <th>Impact Visuel</th>
        </tr>
    </thead>
    <tbody>
        <tr">
            <td>Feu</td>
            <td>Inflige des dégâts de brûlure continues.</td>
            <td>Particules rouge-orange intenses, flammes volumétriques et ondulantes.</td>
        </tr>
        <tr">
            <td>Eau</td>
            <td>Inonde une zone ou apaise (effet de soin possible).</td>
            <td>Particules bleues translucides et fluides, effet de vagues.</td>
        </tr>
        <tr">
            <td>Terre</td>
            <td>Renforce la défense et stabilise les attaques.</td>
            <td>Texture terreuse, particules marron-vert avec fragments de pierre.</td>
        </tr>
        <tr">
            <td>Vent</td>
            <td>Repousse les ennemis et accélère le lanceur.</td>
            <td>Traînées blanches vives et légères, effets de tourbillons rapides.</td>
        </tr>
        <tr>
            <td>Lumière</td>
            <td>Inflige des dégâts sacrés ou soigne les alliés.</td>
            <td>Particules dorées, éclats lumineux, halo clair et étincelant.</td>
        </tr>
        <tr>
            <td>Ténèbres</td>
            <td>Draine la vie de l'ennemi, avec des effets d'ombre.</td>
            <td>Aura violette-noire, fumée sombre avec des volutes mouvants.</td>
        </tr>
        <tr>
            <td>Électricité</td>
            <td>Inflige des dégâts en chaîne et étourdit.</td>
            <td>Éclairs jaune vif, éclats, particules agitées et bondissantes.</td>
        </tr>
        <tr>
            <td>Végétation</td>
            <td>Invoque des lianes ou soigne les alliés.</td>
            <td>Particules vertes, effets de croissance, feuilles et vignes apparaissant.</td>
        </tr>
        <tr>
            <td>Glace</td>
            <td>Inflige des dégâts de froid et ralentit les ennemis.</td>
            <td>Particules glacées bleues, reflets translucides, cristaux de givre.</td>
        </tr>
        <tr>
            <td>Métal</td>
            <td>Augmente la défense et les effets d'attaque physique.</td>
            <td>Texture métallique argentée, éclats de lumière rigides et éclats métalliques.</td>
        </tr>
        <tr>
            <td>Nécromancie</td>
            <td>Draine l'énergie de l'ennemi pour régénérer le lanceur.</td>
            <td>Aura sombre verte, craches et ombres entourant le lanceur.</td>
        </tr>
        <tr>
            <td>Acide</td>
            <td>Corrode et réduit l'armure ennemie.</td>
            <td>Gouttes vert-jaune visqueuses, nuage acide flottant et fumée toxique.</td>
        </tr>
        <tr>
            <td>Tempête</td>
            <td>Crée une tempête de vent et d'éclairs.</td>
            <td>Nuages tourbillonnants gris, éclairs intermittents et vents violents.</td>
        </tr>
    </tbody>
</table>


# Sort simple
Les sorts simples sont des sorts préparés en amont composés de seulement 3 symboles.

# Symboles élémentaires
<table border="1">
    <thead>
        <tr>
            <th>Effets Additionnels</th>
            <th>Élément</th>
            <th>Forme</th>
            <th>Résultat</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>Explosion</td>
            <td></td>
            <td>Sphérique</td>
            <td>Lance une sphère d'*** qui explose et fait des dégâts sur une petite zone</td>
        </tr>
        <tr>
            <td>Explosion</td>
            <td></td>
            <td>Lance</td>
            <td>Lance une lance d'*** très rapide et droite qui explose sur une petite zone</td>
        </tr>
        <tr>
            <td>Explosion</td>
            <td></td>
            <td>Animal</td>
            <td>Invoque un élémentaire d'*** qui fonce droit sur l'ennemi pour lui infliger des dégâts</td>
        </tr>
        <tr>
            <td>Explosion</td>
            <td></td>
            <td>Pluie</td>
            <td>Invoque de la *** au-dessus de l'ennemi, chaque goutte provoque des dégâts légers de zone</td>
        </tr>
        <tr>
            <td>Explosion</td>
            <td></td>
            <td>Mur</td>
            <td>Crée un mur d'*** qui émet des ondes élémentaires (repoussant l'ennemi)</td>
        </tr>
        <tr>
            <td>Explosion</td>
            <td></td>
            <td>Vague</td>
            <td>Envoie une vague d'*** sur l'ennemi</td>
        </tr>
        <tr>
            <td>Explosion</td>
            <td></td>
            <td>Rafale</td>
            <td>Émet une onde de *** droit devant, repoussant l'ennemi</td>
        </tr>
        <tr>
            <td>Explosion</td>
            <td></td>
            <td>Aucun</td>
            <td>Crée une explosion de *** autour de vous</td>
        </tr>
        <tr>
            <td>Tempête</td>
            <td></td>
            <td>Sphérique</td>
            <td></td>
        </tr>
        <tr>
            <td>Tempête</td>
            <td></td>
            <td>Lance</td>
            <td></td>
        </tr>
        <tr>
            <td>Tempête</td>
            <td></td>
            <td>Animal</td>
            <td></td>
        </tr>
        <tr>
            <td>Tempête</td>
            <td></td>
            <td>Pluie</td>
            <td></td>
        </tr>
        <tr>
            <td>Tempête</td>
            <td></td>
            <td>Mur</td>
            <td></td>
        </tr>
        <tr>
            <td>Tempête</td>
            <td></td>
            <td>Vague</td>
            <td></td>
        </tr>
        <tr>
            <td>Tempête</td>
            <td></td>
            <td>Rafale</td>
            <td></td>
        </tr>
        <tr>
            <td>Tempête</td>
            <td></td>
            <td>Aucun</td>
            <td></td>
        </tr>
        <tr>
            <td>Nova</td>
            <td></td>
            <td>Sphérique</td>
            <td></td>
        </tr>
        <tr>
            <td>Nova</td>
            <td></td>
            <td>Lance</td>
            <td></td>
        </tr>
        <tr>
            <td>Nova</td>
            <td></td>
            <td>Animal</td>
            <td></td>
        </tr>
        <tr>
            <td>Nova</td>
            <td></td>
            <td>Pluie</td>
            <td></td>
        </tr>
        <tr>
            <td>Nova</td>
            <td></td>
            <td>Mur</td>
            <td></td>
        </tr>
        <tr>
            <td>Nova</td>
            <td></td>
            <td>Vague</td>
            <td></td>
        </tr>
        <tr>
            <td>Nova</td>
            <td></td>
            <td>Rafale</td>
            <td></td>
        </tr>
        <tr>
            <td>Nova</td>
            <td></td>
            <td>Aucun</td>
            <td></td>
        </tr>
        <tr>
            <td>Altération</td>
            <td></td>
            <td>Sphérique</td>
            <td></td>
        </tr>
        <tr>
            <td>Altération</td>
            <td></td>
            <td>Lance</td>
            <td></td>
        </tr>
        <tr>
            <td>Altération</td>
            <td></td>
            <td>Animal</td>
            <td></td>
        </tr>
        <tr>
            <td>Altération</td>
            <td></td>
            <td>Pluie</td>
            <td></td>
        </tr>
        <tr>
            <td>Altération</td>
            <td></td>
            <td>Mur</td>
            <td></td>
        </tr>
        <tr>
            <td>Altération</td>
            <td></td>
            <td>Vague</td>
            <td></td>
        </tr>
        <tr>
            <td>Altération</td>
            <td></td>
            <td>Rafale</td>
            <td></td>
        </tr>
        <tr>
            <td>Altération</td>
            <td></td>
            <td>Aucun</td>
            <td></td>
        </tr>
        <tr>
            <td>Aucun</td>
            <td></td>
            <td>Sphérique</td>
            <td></td>
        </tr>
        <tr>
            <td>Aucun</td>
            <td></td>
            <td>Lance</td>
            <td></td>
        </tr>
    </tbody>
</table>
