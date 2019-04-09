# Alimentation-Eleve


Interface de création des identifiants des élèves du site Rallye lecture à partir d'un fichier CSV.

Le projet est divisé en 3 grandes parties :

Lecture des informations d'un fichier csv.

Ecriture d'un fichier csv avec les informations de connection de chaques élèves.

Alimentation d'une base de données.

Les outils mis en oeuvre :

Visual Studio C#

Windows Form

Git


Tout d'abord nous avons créée la base de données pour accueillir et traiter ces informations :


Base de donnée Aauth :


Le logiciel se présente ainsi : L'enseignant s'identifie au logiciel.


Après s'être identifié, il a accès au logiciel

Il peut choisir un ou plusieurs fichiers CSV où se trouve le nom de famille et le prénom des élèves.


Une fois le fichier sélectionné, l'enseignant va définir la classe, le niveau, et si le mot de passe doit être généré aléatoirement ou pas.
