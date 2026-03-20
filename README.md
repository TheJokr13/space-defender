![CI Status](https://github.com/TheJokr13/space-defender/actions/workflows/ci.yml/badge.svg)
 
## 📝 Présentation
Ce projet est une démonstration technique axée sur le **Développement Piloté par les Tests (TDD)** et la mise en place d'un pipeline **CI/CD** (Intégration et Déploiement Continus) pour un environnement C# / Unity. L'objectif est de garantir une logique métier 100% validée par des tests automatisés avant toute compilation.

## 🛠️ Architecture de la Logique Métier
Le projet implémente les briques fondamentales d'un système de jeu via trois classes isolées dans le namespace `SpaceDefender.Core` :

* **`Player.cs`** : Gère la santé (0-100), le système de vies, le score et l'état `IsAlive`.
* **`Enemy.cs`** : Gère les points de vie, la détection de mort et un système de récompense (`GetReward`) à usage unique (looting).
* **`ScoreCalculator.cs`** : Calcule les points totaux en fonction des éliminations et applique des multiplicateurs basés sur les séries de combos.

---

## 🧪 Méthodologie TDD & Plan de Tests
Le développement a suivi un cycle strict de validation. Les 13 tests unitaires couvrent des scénarios **Normaux**, de **Limite** et d'**Erreur**.

### État des Tests (Unity Test Runner)
Actuellement, **13 tests sur 13** sont validés avec succès :
* **PlayerTests** (7 tests) : Validation des dégâts, soins plafonnés et gestion des vies.
* **EnemyTests** (2 tests) : Validation de l'état de mort et du loot unique.
* **ScoreCalculatorTests** (4 tests) : Validation des multiplicateurs et de la réinitialisation du score.

---

## ⚙️ Pipeline CI/CD (GitHub Actions)
L'infrastructure automatise la validation du code à chaque modification via GitHub Actions :

1.  **Job `Build & Tests NUnit`** : Compile le code et exécute la suite de tests unitaires. Le pipeline bloque toute progression en cas d'échec (Passage au rouge).
2.  **Job `Build WebGL`** : Une fois les tests validés, une build WebGL est générée pour confirmer la compatibilité de compilation de la logique métier.

**Statistiques du Pipeline :**
* **Succès total** : ✅
* **Durée d'exécution** : ~56 minutes.
* **Artifacts** : 2 générés (Build + Logs).

---

## 📂 Structure du Projet
* `.github/workflows/ci.yml` : Configuration du pipeline automatisé.
* `Assets/Scripts/Core/` : Logique métier pure (C#).
* `Assets/Tests/` : Suite de tests unitaires NUnit.
