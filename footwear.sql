-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3308
-- Generation Time: Apr 10, 2022 at 10:03 PM
-- Server version: 8.0.18
-- PHP Version: 7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `inventory`
--

-- --------------------------------------------------------

--
-- Table structure for table `footwear`
--

DROP TABLE IF EXISTS `footwear`;
CREATE TABLE IF NOT EXISTS `footwear` (
  `Brand_Name` varchar(25) DEFAULT NULL,
  `Shoe_Name` varchar(25) NOT NULL,
  `Shoe_Price` decimal(6,2) DEFAULT NULL,
  `Shoe_Material` varchar(25) DEFAULT NULL,
  `Shoe_Rating` decimal(3,1) DEFAULT NULL,
  `Shoe_Size` decimal(3,1) DEFAULT NULL,
  `Shoe_Style` varchar(25) DEFAULT NULL,
  `Shoe_Color` varchar(15) DEFAULT NULL,
  `Shoe_ID` int(11) NOT NULL,
  PRIMARY KEY (`Shoe_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `footwear`
--

INSERT INTO `footwear` (`Brand_Name`, `Shoe_Name`, `Shoe_Price`, `Shoe_Material`, `Shoe_Rating`, `Shoe_Size`, `Shoe_Style`, `Shoe_Color`, `Shoe_ID`) VALUES
('Nike', 'Air Force One', '90.00', 'Leather & Rubber', '4.5', '7.0', 'Sneaker', 'White', 1),
('Nike', 'Air Force One', '90.00', 'Leather & Rubber', '4.5', '7.0', 'Sneaker', 'Black', 2),
('Nike', 'Air Force One', '90.00', 'Leather & Rubber', '4.5', '7.5', 'Sneaker', 'White', 3),
('Nike', 'Air Force One', '90.00', 'Leather & Rubber', '4.5', '7.5', 'Sneaker', 'Black', 4),
('Nike', 'Air Force One', '90.00', 'Leather & Rubber', '4.5', '8.0', 'Sneaker', 'White', 5),
('Nike', 'Air Force One', '90.00', 'Leather & Rubber', '4.5', '8.0', 'Sneaker', 'Black', 6),
('Nike', 'Air Force One', '90.00', 'Leather & Rubber', '4.5', '8.5', 'Sneaker', 'White', 7),
('Nike', 'Air Force One', '90.00', 'Leather & Rubber', '4.5', '8.5', 'Sneaker', 'Black', 8),
('Nike', 'Air Force One', '90.00', 'Leather & Rubber', '4.5', '9.0', 'Sneaker', 'White', 9),
('Nike', 'Air Force One', '90.00', 'Leather & Rubber', '4.5', '10.0', 'Sneaker', 'Black', 10);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
