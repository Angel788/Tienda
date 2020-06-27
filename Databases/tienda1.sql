-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: localhost    Database: tienda
-- ------------------------------------------------------
-- Server version	8.0.19

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `almacen`
--

DROP TABLE IF EXISTS `almacen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `almacen` (
  `Cod_Almacen` int NOT NULL,
  `Nom_Almacen` varchar(40) NOT NULL,
  `Email` varchar(40) NOT NULL,
  `Telefono` varchar(10) NOT NULL,
  `Ubicacion` varchar(130) NOT NULL,
  PRIMARY KEY (`Cod_Almacen`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `almacen`
--

LOCK TABLES `almacen` WRITE;
/*!40000 ALTER TABLE `almacen` DISABLE KEYS */;
INSERT INTO `almacen` VALUES (1,'Los Sntos','santos@gmail.com','54345678','Baja California Sur, La Paz, Abarrotes Le├│n , calle La cornia mz 456 lt45'),(2,'Custom','almacen_custom@gmial.com','56789012','Quer├®taro, El Marqu├®s, Familia B├írcenas , calle sonor mz34 lt 56'),(3,'Dc','susalmaenrt@cont45.com','56789012','Hidalgo, Calnali, Cruz Verde (Tempalahuaco) , calle rotonda mz 348'),(4,'DcManuel','DcManuel@funetes.com','56789012','Hidalgo, Calnali, Cruz Verde (Tempalahuaco) , calle rotonda mz 348');
/*!40000 ALTER TABLE `almacen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `almacen_stock`
--

DROP TABLE IF EXISTS `almacen_stock`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `almacen_stock` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Cod_Producto` int NOT NULL,
  `Cod_Almacen` int NOT NULL,
  `Stock_PROD` int NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `CodProducto2_FK` (`Cod_Producto`),
  KEY `CodAlmacen2_FK` (`Cod_Almacen`),
  CONSTRAINT `CodAlmacen2_FK` FOREIGN KEY (`Cod_Almacen`) REFERENCES `almacen` (`Cod_Almacen`),
  CONSTRAINT `CodProducto2_FK` FOREIGN KEY (`Cod_Producto`) REFERENCES `producto` (`Cod_Producto`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `almacen_stock`
--

LOCK TABLES `almacen_stock` WRITE;
/*!40000 ALTER TABLE `almacen_stock` DISABLE KEYS */;
INSERT INTO `almacen_stock` VALUES (2,5,1,20),(3,3,2,56),(4,6,3,90),(5,589,4,12),(6,34,1,10),(7,34,4,10);
/*!40000 ALTER TABLE `almacen_stock` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `almacenrelacion`
--

DROP TABLE IF EXISTS `almacenrelacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `almacenrelacion` (
  `ID_ALMRE` int NOT NULL AUTO_INCREMENT,
  `Cod_Producto` int NOT NULL,
  `Cod_Almacen` int NOT NULL,
  `Cod_Tienda` int NOT NULL,
  `Cod_Provedor` int NOT NULL,
  PRIMARY KEY (`ID_ALMRE`),
  KEY `CodProducto1_FK` (`Cod_Producto`),
  KEY `CodAlmacen1_FK` (`Cod_Almacen`),
  KEY `CodTienda1_FK` (`Cod_Tienda`),
  KEY `CodProvedor1_FK` (`Cod_Provedor`),
  CONSTRAINT `CodAlmacen1_FK` FOREIGN KEY (`Cod_Almacen`) REFERENCES `almacen` (`Cod_Almacen`),
  CONSTRAINT `CodProducto1_FK` FOREIGN KEY (`Cod_Producto`) REFERENCES `producto` (`Cod_Producto`),
  CONSTRAINT `CodProvedor1_FK` FOREIGN KEY (`Cod_Provedor`) REFERENCES `provedor` (`Cod_Provedor`),
  CONSTRAINT `CodTienda1_FK` FOREIGN KEY (`Cod_Tienda`) REFERENCES `tienda` (`Cod_tienda`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `almacenrelacion`
--

LOCK TABLES `almacenrelacion` WRITE;
/*!40000 ALTER TABLE `almacenrelacion` DISABLE KEYS */;
INSERT INTO `almacenrelacion` VALUES (3,5,1,5,33),(4,3,2,1,1),(5,6,3,4,33),(6,589,4,2,56);
/*!40000 ALTER TABLE `almacenrelacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `carrito`
--

DROP TABLE IF EXISTS `carrito`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `carrito` (
  `Num_Venta` int NOT NULL,
  PRIMARY KEY (`Num_Venta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `carrito`
--

LOCK TABLES `carrito` WRITE;
/*!40000 ALTER TABLE `carrito` DISABLE KEYS */;
INSERT INTO `carrito` VALUES (1),(2),(3),(4);
/*!40000 ALTER TABLE `carrito` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `carrito_relacion`
--

DROP TABLE IF EXISTS `carrito_relacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `carrito_relacion` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Num_Venta` int NOT NULL,
  `ID_catalogo` int NOT NULL,
  `Cod_Cliente` int NOT NULL,
  `Cod_Producto` int NOT NULL,
  `Num_Envio` int DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `CodProd_fk` (`Cod_Producto`),
  KEY `NumVenta_fk` (`Num_Venta`),
  KEY `Producto01_fk` (`Cod_Cliente`),
  KEY `Num_Envio1_fk` (`Num_Envio`),
  KEY `CatalogoID_FK` (`ID_catalogo`),
  CONSTRAINT `CatalogoID_FK` FOREIGN KEY (`ID_catalogo`) REFERENCES `catalogo` (`ID`) ON DELETE CASCADE,
  CONSTRAINT `CodProd_fk` FOREIGN KEY (`Cod_Producto`) REFERENCES `producto` (`Cod_Producto`) ON DELETE CASCADE,
  CONSTRAINT `Num_Envio1_fk` FOREIGN KEY (`Num_Envio`) REFERENCES `envio` (`Num_Envio`) ON DELETE CASCADE,
  CONSTRAINT `NumVenta_fk` FOREIGN KEY (`Num_Venta`) REFERENCES `carrito` (`Num_Venta`) ON DELETE CASCADE,
  CONSTRAINT `Producto01_fk` FOREIGN KEY (`Cod_Cliente`) REFERENCES `cliente` (`Cod_Cliente`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `carrito_relacion`
--

LOCK TABLES `carrito_relacion` WRITE;
/*!40000 ALTER TABLE `carrito_relacion` DISABLE KEYS */;
INSERT INTO `carrito_relacion` VALUES (4,1,1,8,589,12),(5,2,8,2,456,1),(7,4,7,3,34,3),(8,3,6,1,34,12);
/*!40000 ALTER TABLE `carrito_relacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `catalogo`
--

DROP TABLE IF EXISTS `catalogo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `catalogo` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Cod_Producto` int NOT NULL,
  `Talla` float(6,1) DEFAULT NULL,
  `Color` varchar(15) NOT NULL,
  `Material` varchar(40) NOT NULL,
  `CATEGORIA` varchar(30) DEFAULT NULL,
  `Precio` float(6,2) DEFAULT NULL,
  `Imagen` longblob,
  PRIMARY KEY (`ID`),
  KEY `Producto_fk` (`Cod_Producto`),
  CONSTRAINT `Producto_fk` FOREIGN KEY (`Cod_Producto`) REFERENCES `producto` (`Cod_Producto`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `catalogo`
--

LOCK TABLES `catalogo` WRITE;
/*!40000 ALTER TABLE `catalogo` DISABLE KEYS */;
INSERT INTO `catalogo` VALUES (1,589,27.0,'red','tela','deportivo',1500.00,_binary 'System.Byte[]'),(3,895,27.0,'red','plastico','deportivo',1500.00,_binary 'System.Byte[]'),(4,456,27.0,'red','tela','casual',7.00,_binary 'System.Byte[]'),(5,458,27.0,'red','tela','casual',7.00,_binary 'System.Byte[]'),(6,3,2.0,'23','23','23',24.00,_binary 'System.Byte[]'),(7,34,27.0,'red','plastico','deportivo',1300.59,_binary 'System.Byte[]'),(8,456,26.0,'red','tela','casual',900.56,_binary 'System.Byte[]');
/*!40000 ALTER TABLE `catalogo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cliente` (
  `Cod_Cliente` int NOT NULL,
  `NOMBRE` varchar(40) NOT NULL,
  `APELLIDO` varchar(120) NOT NULL,
  `Email` varchar(40) NOT NULL,
  `Telefono` varchar(10) NOT NULL,
  `Direccion` varchar(120) NOT NULL,
  PRIMARY KEY (`Cod_Cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (1,'Francisco','Hernandez','herdadez@gmail.com','54345678','Campeche, Calkin├¡, Basurero Municipal , mz 243 lt 45'),(2,'Raul','Lopez','raul-lopez23@gmail.com','55467890','Coahuila de Zaragoza, Candela, Benjam├¡n Orteg├│n , calle obregon'),(3,'Angel','Garcia Martinez','elverso90@gmail.com','34560912','M├®xico, Cuautitl├ín Izcalli, Ejido de Guadalupe , calle honor mz34'),(8,'Francisco','Garcia','garci@frank.com','58943456','Colima, Colima, lomas, mz45');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `envio`
--

DROP TABLE IF EXISTS `envio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `envio` (
  `Num_Envio` int NOT NULL,
  `Direccion_Envio` varchar(250) DEFAULT NULL,
  `costo` float(9,3) NOT NULL,
  PRIMARY KEY (`Num_Envio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `envio`
--

LOCK TABLES `envio` WRITE;
/*!40000 ALTER TABLE `envio` DISABLE KEYS */;
INSERT INTO `envio` VALUES (1,'Chihuahua, Camargo, Ailesuca , calle sonora mz 456',234.000),(2,'Jalisco, Guadalajara, Guadalajara , calle redonda mz34 lt589',100.000),(3,'Baja California Sur, La Paz, Aerococina , calle delvalle ',500.000),(12,'Distrito Federal, Iztapalapa, Iztapalapa , mee3',120.000);
/*!40000 ALTER TABLE `envio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `envio_usuario`
--

DROP TABLE IF EXISTS `envio_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `envio_usuario` (
  `ID_OPERACION` int NOT NULL AUTO_INCREMENT,
  `Cod_Cliente` int NOT NULL,
  `Num_Envio` int NOT NULL,
  PRIMARY KEY (`ID_OPERACION`),
  KEY `ENVIO_fk` (`Num_Envio`),
  KEY `Cliente_fk` (`Cod_Cliente`),
  CONSTRAINT `Cliente_fk` FOREIGN KEY (`Cod_Cliente`) REFERENCES `cliente` (`Cod_Cliente`),
  CONSTRAINT `ENVIO_fk` FOREIGN KEY (`Num_Envio`) REFERENCES `envio` (`Num_Envio`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `envio_usuario`
--

LOCK TABLES `envio_usuario` WRITE;
/*!40000 ALTER TABLE `envio_usuario` DISABLE KEYS */;
INSERT INTO `envio_usuario` VALUES (4,1,12),(5,2,1),(6,8,2),(7,3,3);
/*!40000 ALTER TABLE `envio_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto`
--

DROP TABLE IF EXISTS `producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `producto` (
  `Cod_Producto` int NOT NULL,
  `Nom_Modelo` varchar(40) NOT NULL,
  `Num_Serie` varchar(30) DEFAULT NULL,
  `Marcha` varchar(40) DEFAULT NULL,
  PRIMARY KEY (`Cod_Producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto`
--

LOCK TABLES `producto` WRITE;
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
INSERT INTO `producto` VALUES (1,'Adidas Cloudfoam Pure Running','','Adidas'),(3,'Adidas Cloudfoam Advantage','3','Adidas'),(5,'NIKE EPIC REACT FLYKNIT 2','467','NIKE EPIC REACT FLYKNIT 2'),(6,'Adidas Cloudfoam Advantage','','Adidas'),(34,'Adidas Cloudfoam Advantage','NoSerie','Adidas'),(45,'NIKE PEGASUS 35 TURBO','4546','NIKE PEGASUS 35 TURBO'),(54,'PUMA RS-X TROPHY','','PUMA'),(89,'CONVERSE ALL STAR OX BLANCAS','NoSerie','467'),(243,'VANS ULTRARANGE MESH','e232r','VANS'),(245,'VANS CLASSIC SLIP-ON','343','VANS'),(355,'VANS ULTRARANGE MESH','244','VANS'),(456,'VANS ULTRARANGE MESH','8876','VANS'),(458,'CONVERSE ALL STAR OX BLANCAS','','Converse'),(544,'NIKE PEGASUS 35','4546','NIKE PEGASUS 35'),(553,'VANS ULTRARANGE MESH','5gh5','VANS'),(588,'Selecione el modelo','NoSerie','Converse'),(589,'NIKE PEGASUS 35','ewr4t43','NIKE'),(895,'PUMA BMW MOTORSPORT ROMA','976','PUMA'),(2432,'CONVERSE ALL STAR OX BLANCAS','2e3','Converse'),(3589,'VANS ULTRARANGE MESH','244','VANS'),(6776,'CONVERSE ALL STAR OX BLANCAS','67','Converse');
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productos`
--

DROP TABLE IF EXISTS `productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productos` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(180) DEFAULT NULL,
  `Costo` float(5,3) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productos`
--

LOCK TABLES `productos` WRITE;
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `provedor`
--

DROP TABLE IF EXISTS `provedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `provedor` (
  `Cod_Provedor` int NOT NULL,
  `Nom_Provedor` varchar(180) NOT NULL,
  `Instagram` varchar(30) DEFAULT NULL,
  `Facebook` varchar(30) DEFAULT NULL,
  `email` varchar(40) NOT NULL,
  `Telefono` varchar(10) NOT NULL,
  PRIMARY KEY (`Cod_Provedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `provedor`
--

LOCK TABLES `provedor` WRITE;
/*!40000 ALTER TABLE `provedor` DISABLE KEYS */;
INSERT INTO `provedor` VALUES (1,'Juan Juaga Juegos','@DJuan','@DJuan','contacto_DJuan@gmail.com','43567890'),(33,'6','7','7','7','7'),(56,'6','5','6','6','6'),(58,'Roberto','','','roberto90@gmail.com','456789'),(789,'7','88','8','8','8');
/*!40000 ALTER TABLE `provedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `provedor_marcas`
--

DROP TABLE IF EXISTS `provedor_marcas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `provedor_marcas` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Marcas_Maneja` varchar(40) NOT NULL,
  `MODELOS` varchar(50) NOT NULL,
  `Cod_Provedor` int NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `CodProvedor_FK` (`Cod_Provedor`),
  CONSTRAINT `CodProvedor_FK` FOREIGN KEY (`Cod_Provedor`) REFERENCES `provedor` (`Cod_Provedor`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `provedor_marcas`
--

LOCK TABLES `provedor_marcas` WRITE;
/*!40000 ALTER TABLE `provedor_marcas` DISABLE KEYS */;
INSERT INTO `provedor_marcas` VALUES (2,'PUMA','PUMA BMW MOTORSPORT ROMA',33),(3,'Converse','CONVERSE ALL STAR OX BLANCAS',58),(7,'Adidas','Adidas Cloudfoam Pure Running',1),(8,'Adidas','Adidas Cloudfoam Advantage',56),(9,'Adidas','Adidas Swift Run',789),(10,'Converse','CONVERSE ALL STAR OX BLANCAS',1),(11,'Reebok','REEBOK FLEXAGON',58),(12,'Reebok','REEBOK ASTRORIDE TRAIL 2.0',58),(13,'Reebok','REEBOK NPC II SYNC',58);
/*!40000 ALTER TABLE `provedor_marcas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rastreo`
--

DROP TABLE IF EXISTS `rastreo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rastreo` (
  `NUM_RASTRO` int NOT NULL,
  `Num_Envio` int NOT NULL,
  `FECHA_SAL` timestamp NOT NULL,
  `FECHA_LLEGADA` timestamp NOT NULL,
  PRIMARY KEY (`NUM_RASTRO`),
  KEY `NUMENVIO_fk` (`Num_Envio`),
  CONSTRAINT `NUMENVIO_fk` FOREIGN KEY (`Num_Envio`) REFERENCES `envio` (`Num_Envio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rastreo`
--

LOCK TABLES `rastreo` WRITE;
/*!40000 ALTER TABLE `rastreo` DISABLE KEYS */;
INSERT INTO `rastreo` VALUES (1,1,'2020-11-20 16:00:00','2020-11-21 17:00:00'),(2,12,'2020-10-21 15:00:00','2020-10-21 17:00:00'),(3,2,'2020-07-19 15:00:00','2020-07-22 01:00:00'),(4,3,'2020-10-15 13:10:00','2020-10-31 05:00:00');
/*!40000 ALTER TABLE `rastreo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tienda`
--

DROP TABLE IF EXISTS `tienda`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tienda` (
  `Cod_tienda` int NOT NULL,
  `Nom_Tienda` varchar(40) NOT NULL,
  `Direccion_Tienda` varchar(130) NOT NULL,
  PRIMARY KEY (`Cod_tienda`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tienda`
--

LOCK TABLES `tienda` WRITE;
/*!40000 ALTER TABLE `tienda` DISABLE KEYS */;
INSERT INTO `tienda` VALUES (1,'Jorobado','Mexico, Tlanepantla, Kiev Calle rara mz 46 lt78'),(2,'Jorobado','Cuernavaca, Los arrolos , calle guszman mz 45'),(3,'Jorobado','Mexico,Cuatitlan, Morelos, calle pazcual mz346 lt24'),(4,'Picaso','Mexico, Tlanepantla, Kiev Calle rara mz 46 lt79'),(5,'5','5');
/*!40000 ALTER TABLE `tienda` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tienda_contacto`
--

DROP TABLE IF EXISTS `tienda_contacto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tienda_contacto` (
  `Cod_tienda` int NOT NULL,
  `Instagram` varchar(30) DEFAULT NULL,
  `Facebook` varchar(30) DEFAULT NULL,
  `email` varchar(40) NOT NULL,
  `Telefono` varchar(10) NOT NULL,
  KEY `CodTienda_FK` (`Cod_tienda`),
  CONSTRAINT `CodTienda_FK` FOREIGN KEY (`Cod_tienda`) REFERENCES `tienda` (`Cod_tienda`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tienda_contacto`
--

LOCK TABLES `tienda_contacto` WRITE;
/*!40000 ALTER TABLE `tienda_contacto` DISABLE KEYS */;
INSERT INTO `tienda_contacto` VALUES (5,'5','5','5','5'),(1,'@Jorobado','','contacto@Jorobado.com','46789012'),(2,'@Jorobado','','comontacto@Jorobado.com','56890345'),(3,'@Jorobado','','comontacto@Jorobado.com','56890345'),(1,'@Jorobado','','contacto@Jorobado.com','46789012'),(4,'@Jorobado','','contacto@Picaso.com','46789067');
/*!40000 ALTER TABLE `tienda_contacto` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-06-25 19:09:10
