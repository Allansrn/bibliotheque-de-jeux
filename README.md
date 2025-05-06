# 📚 Application WinForms - Bibliothèque de Jeux de Société

Cette application **WinForms en C#** permet de gérer une bibliothèque de jeux de société connectée à une base de données **MySQL** (gérée via **phpMyAdmin**). Elle propose deux interfaces : une pour les utilisateurs et une pour les administrateurs.

---

## 🧩 Fonctionnalités principales

### 🎮 Jeux de société
Chaque jeu contient les informations suivantes :
- **Nom**
- **Description**
- **Nombre de joueurs**
- **Nombre de cartes**
- **Type de jeu**
- **Éditeur**

---

## 🧑‍💻 Interface Administrateur

Accessible uniquement aux administrateurs. Elle permet :
- ➕ **Ajouter** un jeu
- ✏️ **Modifier** un jeu
- ❌ **Supprimer** un jeu
- 🔍 **Rechercher** un jeu par mots-clés
- 🔃 **Trier** les jeux par :
  - ID
  - Nom
  - Nombre de joueurs
  - Nombre de cartes
  - Éditeur

---

## 👤 Interface Utilisateur

Accessible à tous les utilisateurs. Elle permet :
- 🔍 **Rechercher** un jeu
- 🔃 **Trier** les jeux par les mêmes critères que l’admin

---

## 🛠️ Technologies utilisées

- 💻 **C#** avec **Windows Forms**
- 🗃️ **MySQL** via **phpMyAdmin**
- 🔌 Connexion via **MySQL.Data**
- 🎨 Interface graphique construite avec WinForms Designer

---

## ⚙️ Configuration requise

- Windows 10 ou supérieur
- Visual Studio (2022 recommandé)
- Serveur MySQL (WAMP, XAMPP ou autre)
- Bibliothèque `MySql.Data` installée via NuGet

---

## 🚀 Lancer l'application

1. Clone le dépôt :
   ```bash
   git clone https://github.com/ton-pseudo/nom-du-depot.git
