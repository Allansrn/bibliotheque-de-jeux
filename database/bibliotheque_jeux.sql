-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : lun. 17 mars 2025 à 20:35
-- Version du serveur : 8.3.0
-- Version de PHP : 8.3.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `bibliotheque_jeux`
--

-- --------------------------------------------------------

--
-- Structure de la table `jeux_de_societe`
--

DROP TABLE IF EXISTS `jeux_de_societe`;
CREATE TABLE IF NOT EXISTS `jeux_de_societe` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(255) NOT NULL,
  `description` text NOT NULL,
  `nombre_joueurs` varchar(50) NOT NULL,
  `nombre_cartes` int DEFAULT NULL,
  `type` varchar(255) DEFAULT NULL,
  `editeur` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=38 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `jeux_de_societe`
--

INSERT INTO `jeux_de_societe` (`id`, `nom`, `description`, `nombre_joueurs`, `nombre_cartes`, `type`, `editeur`) VALUES
(1, 'Monopoly', 'Jeu de gestion et d’achat de propriétés.', '2 à 6', 28, 'Stratégie/économie', 'Hasbro'),
(2, 'Uno', 'Jeu de cartes où il faut se débarrasser de ses cartes en respectant les couleurs et les chiffres.', '2 à 10', 108, 'Cartes/familial', 'Mattel'),
(3, 'Risk', 'Conquête stratégique du monde.', '2 à 6', 56, 'Stratégie/conquête', 'Hasbro'),
(4, 'Scrabble', 'Jeu de lettres pour former des mots et marquer des points.', '2 à 4', NULL, 'Mots/réflexion', 'Mattel'),
(5, 'Catan', 'Colonisation avec gestion de ressources.', '3 à 4', NULL, 'Gestion/stratégie', 'Kosmos'),
(6, 'Carcassonne', 'Placement de tuiles pour créer des villes, routes et champs.', '2 à 5', NULL, 'Placement stratégique', 'Z-Man Games'),
(7, 'Dixit', 'Jeu de devinettes à partir d’illustrations poétiques.', '3 à 6', 84, 'Cartes/créativité', 'Libellud'),
(8, '7 Wonders', 'Développement d’une civilisation antique.', '2 à 7', 150, 'Stratégie', 'Repos Production'),
(9, 'Time’s Up', 'Jeu de devinettes et d’association de mots.', '4 à 12', 220, 'Ambiance/familial', 'Asmodee'),
(10, 'Cluedo', 'Enquête pour résoudre un meurtre.', '2 à 6', 21, 'Enquête/déduction', 'Hasbro'),
(11, 'Ticket to Ride', 'Construire des itinéraires ferroviaires à travers des cartes du monde.', '2 à 5', 110, 'Stratégie/placement', 'Days of Wonder'),
(12, 'Munchkin', 'Jeu de cartes humoristique sur des donjons.', '3 à 6', 168, 'Cartes/humour', 'Steve Jackson Games'),
(13, 'Pandemic', 'Jeu coopératif de lutte contre des épidémies mondiales.', '2 à 4', 59, 'Coopération/stratégie', 'Z-Man Games'),
(14, 'Azul', 'Placement stratégique de mosaïques.', '2 à 4', NULL, 'Stratégie/abstrait', 'Next Move Games'),
(15, 'Jungle Speed', 'Jeu de rapidité avec un totem au centre.', '2 à 10', 80, 'Rapidité/ambiance', 'Zygomatic'),
(16, 'Splendor', 'Jeu de gestion de ressources et de développement.', '2 à 4', 90, 'Stratégie', 'Space Cowboys'),
(17, 'Les Aventuriers du Rail', 'Jeu stratégique avec des trajets ferroviaires.', '2 à 5', 110, 'Stratégie', 'Days of Wonder'),
(18, 'Perudo', 'Jeu de dés basé sur le bluff et la stratégie.', '2 à 6', NULL, 'Bluff/dés', 'Asmodee'),
(19, 'Trivial Pursuit', 'Quiz avec des questions de culture générale.', '2+', NULL, 'Culture générale', 'Hasbro'),
(20, 'Les Loups-Garous de Thiercelieux', 'Jeu de rôle avec déduction et bluff.', '8 à 18', 24, 'Rôle/bluff', 'Lui-Même'),
(21, 'Blanc-Manger Coco', 'Jeu humoristique de création de phrases absurdes.', '3 à 12', 600, 'Cartes/humour', 'Hiboutatillus'),
(22, 'Codenames', 'Jeu d’association d’idées avec des mots.', '2 à 8', 200, 'Coopération/stratégie', 'Iello'),
(23, 'King of Tokyo', 'Batailles de monstres géants pour conquérir Tokyo.', '2 à 6', NULL, 'Stratégie/dés', 'Iello'),
(24, 'Zombicide', 'Jeu coopératif où il faut survivre à une invasion de zombies.', '1 à 6', 125, 'Coopération', 'Cool Mini or Not'),
(25, 'Terraforming Mars', 'Jeu stratégique de colonisation de Mars.', '1 à 5', 208, 'Stratégie/science', 'FryxGames'),
(26, 'Ghost Stories', 'Jeu coopératif pour protéger un village contre des fantômes.', '1 à 4', NULL, 'Coopération/stratégie', 'Repos Production'),
(27, 'Small World', 'Jeu de conquête dans un monde fantastique.', '2 à 5', NULL, 'Stratégie', 'Days of Wonder'),
(28, 'Hive', 'Jeu stratégique d’insectes sans plateau.', '2', NULL, 'Abstrait/stratégie', 'Gen42 Games'),
(29, 'The Mind', 'Jeu coopératif basé sur la synchronisation mentale entre joueurs.', '2 à 4', 120, 'Cartes/coopération', 'NSV'),
(30, 'Aventuriers de l\'Espace', 'Version spatiale des Aventuriers du Rail.', '2 à 4', 140, 'Stratégie/placement', 'Days of Wonder');

-- --------------------------------------------------------

--
-- Structure de la table `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL,
  `role` enum('user','admin') DEFAULT 'user',
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  UNIQUE KEY `username` (`username`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `users`
--

INSERT INTO `users` (`id`, `username`, `password`, `role`, `created_at`) VALUES
(1, 'admin', '$2y$10$ReBSV.IYZji7rqRJevUuuOLVvbGmBLvc192MlcD/D4BikyyBfX9pS', 'admin', '2025-02-04 14:44:10'),
(2, 'user', '$2y$10$ReBSV.IYZji7rqRJevUuuOLVvbGmBLvc192MlcD/D4BikyyBfX9pS', 'user', '2025-02-06 19:41:33');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
