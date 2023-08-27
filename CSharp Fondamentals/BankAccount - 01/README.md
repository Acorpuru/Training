# Bank Account

## Objectif
- Créer Classes, propriétés et méthodes
- Création d'un constructeur
- Création d'une instance
- Modification de l'objet
- Créer attribut et méthode statique

## Travail
- Créer une classe "User" ayant comme champs
    - "Id" en int
    - "Name" en string
    - "BirthDate en Datetime
- Rajouter un constructeur avec l'initialisation de ces valeurs
- Rajouter une méthode permettant d'écrire dans la console les détails du User


- Créer une classe "BankAccount" ayant comme champs
    - "Id" en int
    - "Number" en string
    - "Balance en decimal
    - "User" en User
- Rajouter un constructeur avec l'initialisation de ces valeurs
    - Number devra avoir "Id-" en prefix 
    - Exemple pour "546987" et  l'Id 1 : 1-546987
- Rajouter une méthode permettant d'écrire dans la console les détails du BankAccount ainsi que le nom de son possesseur
- Rajouter une méthode permettrant d'incrémenter le champ balance
- Rajouter une méthode permettrant de décrémenter le champ balance

- Créer une classe statique utilitaire pour "BankAccount" ayant comme propriété
    - creationAccountNumber en int
- Rajouter une méthode qui prend un User en paramètre et crée un account avec
    - Une balance à 0
    - Un number qui correspond à la date du jour
    - Un Id correspondant à l'id de l'utilisateur
    - creationAccountNumber qui se voit incrémenter de 1
- Rajouter une méthode qui affiche le nombre de compte bancaire créé

- Simuler la création d'un ou plusieurs utilisateurs, de son compte bancaire et faites des débits / crédits sur ce(s) dernier(s)
- Afficher les résultats

## Fonctionnalités à connaîtres
Console.WriteLine("Methode") // Affiche "Methode" dans la console
DateTime.Now.ToShortDateString() // Avoir la date du jour 