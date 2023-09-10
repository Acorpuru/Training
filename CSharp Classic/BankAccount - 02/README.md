# Bank Account


## Context
J'aimerais rajouter la possibilité de faire des opérations avec uen devise spécifique (Dollar, Euro, .. etc), néanmoins nous ne pouvons faire des opérations que sur des comptes bancaires possédant la même devise

## Objectif
- Utiliser l'immutabilité
- Manipuler les surcharges d'opérateur
- Manipuler les exceptions
- Découvrir la sérialisation Json

## Travail
- Rajouter un nouveau type Money qui remplacera le type décimal Balance du compte bancaire
    - Permettre d'additionner ou de soustraire des types Money
    - Gérer les différents cas d'erreurs
- Afficher le contenu sérializé d'un compte bancaire

- Simuler la création d'au moins un compte bancaire et faites des débits / crédits sur ce dernier
- Afficher les résultats

## Fonctionnalités à connaîtres