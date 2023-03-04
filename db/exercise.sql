-- MariaDB dump 10.19  Distrib 10.9.4-MariaDB, for Linux (x86_64)
--
-- Host: localhost    Database: exercises
-- ------------------------------------------------------
-- Server version	10.9.4-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `Ocenki`
--

DROP TABLE IF EXISTS `Ocenki`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Ocenki` (
  `Nomer_klas` varchar(10) NOT NULL,
  `Kod_predmet` varchar(5) NOT NULL,
  `Kod_prep` varchar(5) NOT NULL,
  `Ocenka` double DEFAULT 2 CHECK (`Ocenka` >= 2.0 and `Ocenka` <= 6.0),
  KEY `Nomer_klas` (`Nomer_klas`),
  KEY `Kod_predmet` (`Kod_predmet`),
  KEY `Kod_prep` (`Kod_prep`),
  CONSTRAINT `Ocenki_ibfk_1` FOREIGN KEY (`Nomer_klas`) REFERENCES `Uchenici` (`Nomer_klas`),
  CONSTRAINT `Ocenki_ibfk_2` FOREIGN KEY (`Kod_predmet`) REFERENCES `Uchebni_predmeti` (`Kod_predmet`),
  CONSTRAINT `Ocenki_ibfk_3` FOREIGN KEY (`Kod_prep`) REFERENCES `Prepodavateli` (`Kod_prep`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Ocenki`
--

DROP TABLE `Ocenki`;

CREATE TABLE `Ocenki` (
  `Nomer_klas` varchar(10) NOT NULL,
  `Kod_predmet` varchar(5) NOT NULL,
  `Kod_prep` varchar(5) NOT NULL,
  `Ocenka` double DEFAULT 2 CHECK (`Ocenka` >= 2.0 and `Ocenka` <= 6.0),
  KEY `Nomer_klas` (`Nomer_klas`),
  KEY `Kod_predmet` (`Kod_predmet`),
  KEY `Kod_prep` (`Kod_prep`),
  CONSTRAINT `Ocenki_ibfk_1` FOREIGN KEY (`Nomer_klas`) REFERENCES `Uchenici` (`Nomer_klas`) on delete cascade ,
  CONSTRAINT `Ocenki_ibfk_2` FOREIGN KEY (`Kod_predmet`) REFERENCES `Uchebni_predmeti` (`Kod_predmet`) on delete cascade,
  CONSTRAINT `Ocenki_ibfk_3` FOREIGN KEY (`Kod_prep`) REFERENCES `Prepodavateli` (`Kod_prep`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

LOCK TABLES `Ocenki` WRITE;
/*!40000 ALTER TABLE `Ocenki` DISABLE KEYS */;
INSERT INTO `Ocenki` VALUES
('12A1','00001','00001',5.8),
('12A1','00002','00003',6),
('12A13','00003','00004',2.6),
('12A24','00005','00005',5.99),
('12A26','00001','00002',3.49),
('12A5','00004','00004',4.67),
('12A8','00001','00001',6),
('12A9','00003','00004',4.8),
('12B14','00001','00003',3.75);
/*!40000 ALTER TABLE `Ocenki` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Prepodavateli`
--

DROP TABLE IF EXISTS `Prepodavateli`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Prepodavateli` (
  `Kod_prep` varchar(5) NOT NULL,
  `Prep_Name` varchar(25) DEFAULT NULL,
  `Prep_Fam` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`Kod_prep`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Prepodavateli`
--

LOCK TABLES `Prepodavateli` WRITE;
/*!40000 ALTER TABLE `Prepodavateli` DISABLE KEYS */;
INSERT INTO `Prepodavateli` VALUES
('00001','Miroslava','Kostadinova'),
('00002','Cvetelina','Cvetanova'),
('00003','Encho','Vasilev'),
('00004','Daniela','Yordanova'),
('00005','Susan','Feimova');
/*!40000 ALTER TABLE `Prepodavateli` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Uchebni_predmeti`
--

DROP TABLE IF EXISTS `Uchebni_predmeti`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Uchebni_predmeti` (
  `Kod_predmet` varchar(5) NOT NULL,
  `Name_predmet` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`Kod_predmet`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Uchebni_predmeti`
--

LOCK TABLES `Uchebni_predmeti` WRITE;
/*!40000 ALTER TABLE `Uchebni_predmeti` DISABLE KEYS */;
INSERT INTO `Uchebni_predmeti` VALUES
('00001','Matematika'),
('00002','Computer Science'),
('00003','PE'),
('00004','Physics'),
('00005','Literature');
/*!40000 ALTER TABLE `Uchebni_predmeti` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Uchenici`
--

DROP TABLE IF EXISTS `Uchenici`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Uchenici` (
  `Nomer_klas` varchar(10) NOT NULL,
  `Name` varchar(25) DEFAULT NULL,
  `Fam` varchar(25) DEFAULT NULL,
  `R_date` date DEFAULT NULL,
  `Mestorojdenie` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`Nomer_klas`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Uchenici`
--

LOCK TABLES `Uchenici` WRITE;
/*!40000 ALTER TABLE `Uchenici` DISABLE KEYS */;
INSERT INTO `Uchenici` VALUES
('12A1','Alex','Miteva','2004-02-24','Ruse'),
('12A13','Konstantin','Georgiev','2004-02-21','Ruse'),
('12A2','Aleksander','Bratoev','2004-04-18','Ruse'),
('12A24','Teodor','Kovachev','2004-08-06','Ruse'),
('12A26','Toma','Apostolov','2004-10-16','Ruse'),
('12A5','Gergana','Stoycheva','2004-07-02','Ruse'),
('12A8','Chachi','Wang','2004-01-26','Ruse'),
('12A9','Evgeni','Kandru','2004-01-06','Ruse'),
('12B14','Martin','Georgiev','2004-07-15','Ruse'),
('8A1','Angel','Ivanov','2008-04-12','Ruse');
/*!40000 ALTER TABLE `Uchenici` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-11-25 13:36:50
