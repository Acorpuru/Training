# Bank Account


## Context
J'ai actuellement une fonction simple pour rajouter de l'argent dans une banque.
J'aimerais pouvoir rajouter des comportements à mon service sans impacter le fonctionnement normal.

## Objectif
- Manipuler le design pattern decorator

## Travail
- Faire en sorte de pouvoir rajouter 3 comportements distincts à celui de base
	- Voler 1% de l'argent à verser quand le montant à créditer est supérieur que 1000€
	- Rajouter 50€ sur l'argent à verser quand le crédit est inférieur à 100€
	- Effectuer un débit plutôt qu'un crédit quand l'argent à créditer est supérieur à 2000€