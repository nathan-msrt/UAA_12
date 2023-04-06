-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: localhost    Database: nathan
-- ------------------------------------------------------
-- Server version	8.0.27

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `jeux`
--

DROP TABLE IF EXISTS `jeux`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `jeux` (
  `jeuxId` int NOT NULL AUTO_INCREMENT,
  `jeuxNom` varchar(255) NOT NULL,
  `jeuxPrix` int NOT NULL,
  `utilisateurId` int NOT NULL,
  PRIMARY KEY (`jeuxId`),
  KEY `utilisateurId` (`utilisateurId`),
  CONSTRAINT `jeux_ibfk_1` FOREIGN KEY (`utilisateurId`) REFERENCES `utilisateur` (`utilisateurId`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jeux`
--

LOCK TABLES `jeux` WRITE;
/*!40000 ALTER TABLE `jeux` DISABLE KEYS */;
INSERT INTO `jeux` VALUES (1,'Fortnite',1,1),(2,'Minecraft',1,2),(3,'Apex Legends',1,3),(4,'League Of Legends',1,4),(5,'PUBG',1,5),(6,'Blacks Ops II',1,1),(7,'Valorant',1,2),(8,'Overwatch',1,3),(9,'Grand Theft Auto',1,4),(10,'Warzone',1,5);
/*!40000 ALTER TABLE `jeux` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `magasin`
--

DROP TABLE IF EXISTS `magasin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `magasin` (
  `magasinId` int NOT NULL AUTO_INCREMENT,
  `magasinNom` varchar(255) NOT NULL,
  `magasinLocalite` varchar(255) NOT NULL,
  PRIMARY KEY (`magasinId`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `magasin`
--

LOCK TABLES `magasin` WRITE;
/*!40000 ALTER TABLE `magasin` DISABLE KEYS */;
INSERT INTO `magasin` VALUES (1,'Smartoys','Namur'),(2,'Stargames','Namur'),(3,'Super Gaby Games','Namur'),(4,'Cinephil Store','Namur'),(5,'Dreamland','Namur'),(6,'Video Game Center','Charleroi'),(7,'GameCash','Charleroi'),(8,'Fnac','Charleroi'),(9,'Ludotrotter','Charleroi'),(10,'Full option','Charleroi'),(11,'Smartoys','Liege'),(12,'Player','Liege'),(13,'Player Regence','Liege'),(14,'Wild Bishop','Liege'),(15,'Fnac','Liege'),(16,'Fnac','Bruxelles'),(17,'Super Gaby Games','Bruxelles'),(18,'Smartoys Bourse','Bruxelles'),(19,'Smartoys City 2','Bruxelles'),(20,'Warhammer','Bruxelles');
/*!40000 ALTER TABLE `magasin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `magasin_jeux`
--

DROP TABLE IF EXISTS `magasin_jeux`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `magasin_jeux` (
  `magasinJeuxId` int NOT NULL AUTO_INCREMENT,
  `magasinId` int NOT NULL,
  `jeuxId` int NOT NULL,
  PRIMARY KEY (`magasinJeuxId`),
  KEY `magasinId` (`magasinId`),
  KEY `jeuxId` (`jeuxId`),
  CONSTRAINT `magasin_jeux_ibfk_1` FOREIGN KEY (`magasinId`) REFERENCES `magasin` (`magasinId`),
  CONSTRAINT `magasin_jeux_ibfk_2` FOREIGN KEY (`jeuxId`) REFERENCES `jeux` (`jeuxId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `magasin_jeux`
--

LOCK TABLES `magasin_jeux` WRITE;
/*!40000 ALTER TABLE `magasin_jeux` DISABLE KEYS */;
/*!40000 ALTER TABLE `magasin_jeux` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `theme`
--

DROP TABLE IF EXISTS `theme`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `theme` (
  `themeID` int NOT NULL AUTO_INCREMENT,
  `themeNom` varchar(255) NOT NULL,
  PRIMARY KEY (`themeID`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `theme`
--

LOCK TABLES `theme` WRITE;
/*!40000 ALTER TABLE `theme` DISABLE KEYS */;
INSERT INTO `theme` VALUES (16,'1ere personne'),(17,'3eme personne'),(18,'Monde-Ouvert'),(19,'Aventure'),(20,'Battle Royale');
/*!40000 ALTER TABLE `theme` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `theme_jeux`
--

DROP TABLE IF EXISTS `theme_jeux`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `theme_jeux` (
  `themeJeuxId` int NOT NULL AUTO_INCREMENT,
  `themeId` int NOT NULL,
  `jeuxId` int NOT NULL,
  PRIMARY KEY (`themeJeuxId`),
  KEY `themeId` (`themeId`),
  KEY `jeuxId` (`jeuxId`),
  CONSTRAINT `theme_jeux_ibfk_1` FOREIGN KEY (`themeId`) REFERENCES `theme` (`themeID`),
  CONSTRAINT `theme_jeux_ibfk_2` FOREIGN KEY (`jeuxId`) REFERENCES `jeux` (`jeuxId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `theme_jeux`
--

LOCK TABLES `theme_jeux` WRITE;
/*!40000 ALTER TABLE `theme_jeux` DISABLE KEYS */;
/*!40000 ALTER TABLE `theme_jeux` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `utilisateur`
--

DROP TABLE IF EXISTS `utilisateur`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `utilisateur` (
  `utilisateurId` int NOT NULL AUTO_INCREMENT,
  `utilisateurNom` varchar(100) DEFAULT NULL,
  `utilisateurPrenom` varchar(100) DEFAULT NULL,
  `utilisateurPseudo` varchar(255) DEFAULT NULL,
  `utilisateurEmail` varchar(255) DEFAULT NULL,
  `utilisateurMotDePasse` varchar(255) DEFAULT NULL,
  `utilisateurRole` varchar(255) DEFAULT NULL,
  `utilisateurLocalite` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`utilisateurId`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `utilisateur`
--

LOCK TABLES `utilisateur` WRITE;
/*!40000 ALTER TABLE `utilisateur` DISABLE KEYS */;
INSERT INTO `utilisateur` VALUES (1,'Rébecca','Armand','REBARM','rebecca.armand@gmail.com','REBARM111',NULL,'Namur'),(2,'Aimée','Hebert','AIMHEB','aimee.hebert@gmail.com','AIMHEB111',NULL,'Bruxelles'),(3,'Marielle','Ribeiro','MARRIB','marielle.ribeiro@gmail.com','MARRIB111',NULL,'Charleroi'),(4,'Hilaire','Savary','HILSAV','hilaire.savary@gmail.com','HILSAV111',NULL,'Liege'),(5,'Eva','Paelinck','Ma femme','eva.paelinck@gmail.com','EVAPAE111',NULL,'Namur');
/*!40000 ALTER TABLE `utilisateur` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `utilisateur_jeux`
--

DROP TABLE IF EXISTS `utilisateur_jeux`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `utilisateur_jeux` (
  `utilisateurJeuxId` int NOT NULL AUTO_INCREMENT,
  `utilisateurId` int NOT NULL,
  `jeuxId` int NOT NULL,
  PRIMARY KEY (`utilisateurJeuxId`),
  KEY `utilisateurId` (`utilisateurId`),
  KEY `jeuxId` (`jeuxId`),
  CONSTRAINT `utilisateur_jeux_ibfk_1` FOREIGN KEY (`utilisateurId`) REFERENCES `utilisateur` (`utilisateurId`),
  CONSTRAINT `utilisateur_jeux_ibfk_2` FOREIGN KEY (`jeuxId`) REFERENCES `jeux` (`jeuxId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `utilisateur_jeux`
--

LOCK TABLES `utilisateur_jeux` WRITE;
/*!40000 ALTER TABLE `utilisateur_jeux` DISABLE KEYS */;
/*!40000 ALTER TABLE `utilisateur_jeux` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-04-06 14:10:13
