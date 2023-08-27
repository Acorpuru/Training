# Bank Account

## Objectif
- Modifier l'accessibilité des types ou méthodes
- Manipuler Struct ou Record
- Manipuler les Enum
- Manipuler les méthodes d'extensions
- Comprendre les usings

## Travail
- Créer un second projet pour contenir la logique et ne garder le second que pour son utilisation  

- Empêcher toute création de user autrement que par une méthode static qui embarque les contrôles 
    - Le date de naissance renseignée date d'il y a plus de 18 ans
    - Le nom renseigné n'est pas "Test"
- la classe UserHelper ne devrait plus être nécessaire

- Créer une structure Operation ayant comme propriété
    - "Operation" en enum
    - "Amount" en decimal
- Faites en sorte qu'elle ne soit accessible que dans son assembly

- Dans la classe BankAccount, utiliser le nouveau type Operation pour tout ce qui touche à la balance de cette dernière

- Dans la classe BankAccountHelper, rajouter des méthodes de débit et crédit comme si elles appartenaient à la classe BankAccount

- Les champs des différentes classes ne doivent pouvoir être modifiable que par elles seules

- Simuler un transfert d'argent entre 2 utilisateurs
- Afficher les résultats


## Fonctionnalités à connaîtres