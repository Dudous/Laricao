-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Tempo de geração: 04-Dez-2023 às 21:43
-- Versão do servidor: 8.0.31
-- versão do PHP: 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `laricao`
--
CREATE DATABASE IF NOT EXISTS `laricao` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci;
USE `laricao`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `amburge`
--

DROP TABLE IF EXISTS `amburge`;
CREATE TABLE IF NOT EXISTS `amburge` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `preco` decimal(7,2) NOT NULL,
  `foto` varchar(100) NOT NULL DEFAULT 'E:\\Laricão Pizzaria\\src/default.png',
  `categoria` int NOT NULL,
  `status` tinyint NOT NULL,
  PRIMARY KEY (`id`),
  KEY `status` (`status`),
  KEY `categoria` (`categoria`)
) ENGINE=MyISAM AUTO_INCREMENT=40 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `amburge`
--

INSERT INTO `amburge` (`id`, `nome`, `preco`, `foto`, `categoria`, `status`) VALUES
(2, 'Americano', '40.00', 'E:\\Laricao\\img\\americano.jpg', 1, 2),
(3, 'Cheese Bacon', '42.00', 'E:\\laricao\\img\\Cheese bacon.jpg', 1, 1),
(6, 'Classico', '39.00', 'E:\\laricao\\img\\classic.jpg', 1, 1),
(7, 'Cream Cheese', '37.00', 'E:\\laricao\\img\\cream_cheese.jpg', 1, 1),
(8, 'Costela', '42.00', 'E:\\laricao\\img\\costela.jpg', 1, 1),
(9, 'Junior', '30.00', 'E:\\laricao\\img\\junior.jpg', 1, 1),
(10, 'Picles', '38.00', 'E:\\laricao\\img\\picles.jpg', 1, 1),
(12, 'Pão de alho', '5.00', 'E:\\laricao\\img\\pãodalho.jpg', 3, 1),
(13, 'Batata canoa', '10.00', 'E:\\laricao\\img\\batata_canoa.jpg', 3, 1),
(14, 'Batata frita', '20.00', 'E:\\laricao\\img\\batata_frita.jpg', 3, 1),
(15, 'Batata especial', '30.00', 'E:\\laricao\\img\\batata_especial.jpg', 3, 1),
(16, 'Anel de cebola', '20.00', 'E:\\laricao\\img\\Anel_cb.jpg', 3, 1),
(17, 'Mini coxinhas', '25.00', 'E:\\laricao\\img\\Coxinha.jpg', 3, 1),
(18, 'Brownie', '7.00', 'E:\\Laricao\\img\\brownie.jpg', 4, 1),
(19, 'Cookies', '5.00', 'E:\\Laricao\\img\\kuk.jpg', 4, 1),
(20, 'Donuts', '15.00', 'E:\\Laricao\\img\\dunuts.jpg', 4, 1),
(21, 'Agua C/G', '4.00', 'E:\\Laricao\\img\\agua.jpg', 2, 1),
(22, 'Agua S/G', '4.00', 'E:\\Laricao\\img\\agua-Sc.jpg\r\n', 2, 1),
(23, 'Chopp de vinho', '10.00', 'E:\\Laricao\\img\\chop.jpg', 2, 1),
(24, 'Coca', '6.00', 'E:\\Laricao\\img\\coca.jpg', 2, 1),
(25, 'Coca 600ml', '8.00', 'E:\\Laricao\\img\\coca600.jpg', 2, 1),
(26, 'Coca Zero', '6.00', 'E:\\Laricao\\img\\cocaZero.jpg', 2, 1),
(28, 'Dell vale', '7.00', 'E:\\Laricao\\img\\suco.jpg', 2, 1),
(29, 'Fanta laranja', '6.00', 'E:\\Laricao\\img\\fanta-laranja.jpg', 2, 1),
(30, 'Fanta uva', '6.00', 'E:\\Laricao\\img\\fanta-uva.jpg', 2, 1),
(31, 'Guaraná lata', '6.00', 'E:\\Laricao\\img\\guarana.jpg', 2, 1),
(32, 'Guaraná 600ml ', '6.00', 'E:\\Laricao\\img\\guarana600.jpg', 2, 1),
(33, 'Pepsi', '6.00', 'E:\\Laricao\\img\\pepsi.jpg', 2, 1),
(34, 'Tubaina', '6.00', 'E:\\Laricao\\img\\tubaina.jpg', 2, 1),
(1, 'regulador', '0.00', 'E:\\Laricao\\img\\default.png', 0, 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `carrinho`
--

DROP TABLE IF EXISTS `carrinho`;
CREATE TABLE IF NOT EXISTS `carrinho` (
  `cod_prod` int NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`cod_prod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `categoria`
--

DROP TABLE IF EXISTS `categoria`;
CREATE TABLE IF NOT EXISTS `categoria` (
  `id` int NOT NULL AUTO_INCREMENT,
  `categoria` varchar(20) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `fk_categoria` (`categoria`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `categoria`
--

INSERT INTO `categoria` (`id`, `categoria`) VALUES
(1, 'Hambúrguer'),
(2, 'Bebidas'),
(3, 'Porções'),
(4, 'Sobremesas');

-- --------------------------------------------------------

--
-- Estrutura da tabela `pagamento`
--

DROP TABLE IF EXISTS `pagamento`;
CREATE TABLE IF NOT EXISTS `pagamento` (
  `id` int NOT NULL AUTO_INCREMENT,
  `pag` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `pagamento`
--

INSERT INTO `pagamento` (`id`, `pag`) VALUES
(1, 'Dinheiro'),
(2, 'Débito'),
(3, 'Crédito'),
(4, 'Pix'),
(5, 'Vale Alimentação'),
(6, 'Vale Refeição');

-- --------------------------------------------------------

--
-- Estrutura da tabela `pedidos`
--

DROP TABLE IF EXISTS `pedidos`;
CREATE TABLE IF NOT EXISTS `pedidos` (
  `id_pedido` int NOT NULL AUTO_INCREMENT,
  `Nome` varchar(50) NOT NULL,
  `idusuario` int NOT NULL,
  `cep` varchar(11) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `bairro` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `endereco` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `num` varchar(10) NOT NULL,
  `tel` varchar(15) NOT NULL,
  `status` varchar(50) NOT NULL,
  `pedido` varchar(1100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `obs` varchar(300) NOT NULL,
  `pagamento` int NOT NULL,
  PRIMARY KEY (`id_pedido`),
  KEY `pagamento` (`pagamento`)
) ENGINE=MyISAM AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `perfil`
--

DROP TABLE IF EXISTS `perfil`;
CREATE TABLE IF NOT EXISTS `perfil` (
  `id_perfil` int NOT NULL AUTO_INCREMENT,
  `perfil` varchar(60) NOT NULL,
  PRIMARY KEY (`id_perfil`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `perfil`
--

INSERT INTO `perfil` (`id_perfil`, `perfil`) VALUES
(1, 'Usuario'),
(2, 'Administrador'),
(3, 'Cozinheiro');

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE IF NOT EXISTS `usuario` (
  `idusuario` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(60) DEFAULT NULL,
  `sobrenome` varchar(100) NOT NULL,
  `cpf` varchar(14) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `telefone` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `senha` varchar(42) DEFAULT NULL,
  `id_perfil` int NOT NULL,
  `email` varchar(75) NOT NULL,
  `status` tinyint NOT NULL DEFAULT '1',
  PRIMARY KEY (`idusuario`),
  KEY `FK_perfil` (`id_perfil`),
  KEY `fk_status` (`status`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `usuario`
--

INSERT INTO `usuario` (`idusuario`, `nome`, `sobrenome`, `cpf`, `telefone`, `senha`, `id_perfil`, `email`, `status`) VALUES
(2, 'Duardo', 'Sampaio', '139.167.549-55', '(41) 95555-5555', 'e8c0653fea13f91bf3c48159f7c24f78', 2, 'sampaioeeduardo36@gmail.com', 2),
(15, 'Admin', 'da Silva', '319,671,459-55', '(66) 66666-6666', '81dc9bdb52d04dc20036dbd8313ed055', 2, 'adm@gmail.com', 1),
(16, 'Usuario', 'dos Santos', '193,761,954-55', '(77) 77777-7777', '81dc9bdb52d04dc20036dbd8313ed055', 1, 'user@gmail.com', 1),
(17, 'Cozinheiro', 'Ribeiro', '931,671,495-46', '(11) 11111-1111', '81dc9bdb52d04dc20036dbd8313ed055', 3, 'cozinheiro@gmail.com', 1);

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `usuario`
--
ALTER TABLE `usuario`
  ADD CONSTRAINT `FK_perfil` FOREIGN KEY (`id_perfil`) REFERENCES `perfil` (`id_perfil`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
