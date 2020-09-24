CREATE DATABASE  IF NOT EXISTS `estaciona`;
USE `estaciona`;

DROP TABLE IF EXISTS `tabelapreco`;
CREATE TABLE `tabelapreco` (
  `id` int NOT NULL AUTO_INCREMENT,
  `vigenciaInicial` date DEFAULT NULL,
  `vigenciaFinal` date DEFAULT NULL,
  `valorHoraInicial` decimal(5,2) DEFAULT NULL,
  `valorHoraAdicional` decimal(5,2) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

DROP TABLE IF EXISTS `estacionamento`;
CREATE TABLE `estacionamento` (
  `id` int NOT NULL AUTO_INCREMENT,
  `entrada` datetime DEFAULT NULL,
  `saida` datetime DEFAULT NULL,
  `placa` varchar(10) CHARACTER SET latin1 COLLATE latin1_general_ci DEFAULT NULL,
  `valorTotal` decimal(5,2) DEFAULT NULL,
  `idPreco` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `precoId_idx` (`idPreco`),
  CONSTRAINT `precoId` FOREIGN KEY (`idPreco`) REFERENCES `tabelapreco` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;


