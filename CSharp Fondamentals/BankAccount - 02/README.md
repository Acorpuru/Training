# Bank Account

## Objectif
- Créer des expressions booléennes
- Utiliser des variables locales
- Utiliser l'inférence de type
- Utiliser des instruments de sélections

## Travail
- Créer une classe statique utilitaire pour "User"
- Rajouter une méthode qui prend un nom et une date de naissance en paramètre et crée un user seulement si 
    - Le date de naissance renseignée date d'il y a plus de 18 ans
    - Le nom renseigné n'est pas "Test"
- Afficher un message d'erreur et ne pas créer le user si une des conditions n'est pas remplie

- Dans la classe BankAccount remplacer les méthodes permettants de modifier la balance par une méthode unique ayant comme paramètres
 - "opération" en string pouvant être "-" ou "+" (Rajouter un message d'erreur si le symbole n'est pas - ou +)
 - "amount" en decimal 
- Rajouter une méthode permettant de transférer de l'argent d'un compte bancaire à un autre seulement si la balance ne devient pas négative ou que le montant transféré n'est pas inférieur à 0

- Si jamais l'utilisateur n'a pas pu être créé le process ne doit pas continuer
- Simuler un transfert d'argent entre 2 utilisateurs
- Afficher les résultats

## Fonctionnalités à connaîtres
DateTime.Now.AddYears()// Pour ajouter ou soustraire des années à la date en cours
new Random().Next() //Pour générer un int aléatoirement
"\n" //Permet de sauter une ligne dans un texte