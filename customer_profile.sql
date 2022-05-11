-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3308
-- Generation Time: Apr 10, 2022 at 10:02 PM
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
-- Database: `customer`
--

-- --------------------------------------------------------

--
-- Table structure for table `customer_profile`
--

DROP TABLE IF EXISTS `customer_profile`;
CREATE TABLE IF NOT EXISTS `customer_profile` (
  `Customer_ID` int(11) NOT NULL,
  `FName` varchar(25) NOT NULL,
  `LName` varchar(25) NOT NULL,
  `User_Name` varchar(25) NOT NULL,
  `Password` varchar(25) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `Email` varchar(30) NOT NULL,
  `Phone_Number` varchar(10) NOT NULL,
  `Credit_Card` int(11) NOT NULL,
  PRIMARY KEY (`Customer_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `customer_profile`
--

INSERT INTO `customer_profile` (`Customer_ID`, `FName`, `LName`, `User_Name`, `Password`, `Address`, `Email`, `Phone_Number`, `Credit_Card`) VALUES
(1001, 'Rashon', 'Morrison', 'RashonM12', 'DogLover2', '123 Main Street', 'rashonmorrison12@gmail.com', '9175455645', 2147483647),
(1002, 'Dan', 'Man', 'DanDaMan45', 'Nascar45', '435 Ocean Drive', 'DanDaMan45@gmail.com', '7185676035', 2147483647),
(1003, 'Daniel', 'Okpara', 'DanielOkpara18', 'YankeesHat66', '92 East 65th Street', 'DanielOkpara66@yahoo.com', '7187749374', 2147483647);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
