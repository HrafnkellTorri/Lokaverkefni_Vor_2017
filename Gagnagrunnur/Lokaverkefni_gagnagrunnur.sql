-- phpMyAdmin SQL Dump
-- version 4.5.4.1deb2ubuntu2
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: May 09, 2017 at 10:33 PM
-- Server version: 5.7.18-0ubuntu0.16.04.1
-- PHP Version: 7.0.15-0ubuntu0.16.04.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `Lokaverkefni`
--

-- --------------------------------------------------------

--
-- Table structure for table `Company`
--

CREATE TABLE `Company` (
  `ID` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `type` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `phone_no` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Company`
--

INSERT INTO `Company` (`ID`, `name`, `type`, `email`, `phone_no`) VALUES
(1, 'R&B Studio', 'Game Development', 'R&B@Gmail.com', '5552873');

-- --------------------------------------------------------

--
-- Table structure for table `Employee`
--

CREATE TABLE `Employee` (
  `ID` int(11) NOT NULL,
  `Fname` varchar(50) NOT NULL,
  `Lname` varchar(50) NOT NULL,
  `speciality` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `phone_no` varchar(20) NOT NULL,
  `company_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Employee`
--

INSERT INTO `Employee` (`ID`, `Fname`, `Lname`, `speciality`, `email`, `phone_no`, `company_ID`) VALUES
(1, 'Hrafnkell', 'Þorri Þrastarson', 'GameDesigner', 'Kallinnhannhrabbi@hotmail.com', '6616363', 1),
(2, 'Erla', 'Óskarsdóttir', 'Game Designer', 'erla.oskarsdottir@gmail.com', '6911997', 1);

-- --------------------------------------------------------

--
-- Table structure for table `Games`
--

CREATE TABLE `Games` (
  `ID` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `description` varchar(150) NOT NULL,
  `game_designer_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Games`
--

INSERT INTO `Games` (`ID`, `name`, `description`, `game_designer_ID`) VALUES
(1, 'Spacebar', 'A game where absolutely anything can happen........PRESS SPACEBAR AS OFTEN AS YOU CAN IN THESE EVENTFULL 10 SECONDS!', 1),
(2, 'TypingGame', 'Type as many words right as you can in 30 seconds! Get many words in a row, you get combo which gives you extra points!', 2),
(3, 'Village', 'Lead you villagers into the modern age!', 1);

-- --------------------------------------------------------

--
-- Table structure for table `Scores`
--

CREATE TABLE `Scores` (
  `user_ID` int(11) NOT NULL,
  `game_ID` int(11) NOT NULL,
  `score` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Scores`
--

INSERT INTO `Scores` (`user_ID`, `game_ID`, `score`) VALUES
(6, 1, 50),
(6, 2, 50),
(3, 1, 30),
(11, 2, 36),
(10, 1, 56),
(8, 2, 220),
(2, 2, 2220),
(1, 2, 2180),
(1, 1, 153),
(12, 1, 78),
(12, 2, 815),
(13, 2, 140),
(2, 1, 58),
(14, 2, 190),
(14, 1, 88),
(15, 1, 76),
(15, 2, 1450),
(16, 2, 530),
(17, 1, 40),
(17, 2, 690),
(1, 3, 1943),
(8, 3, 2076),
(18, 1, 68),
(18, 2, 40);

-- --------------------------------------------------------

--
-- Table structure for table `Users`
--

CREATE TABLE `Users` (
  `ID` int(11) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `date_of_birth` date NOT NULL,
  `email` varchar(50) NOT NULL,
  `country` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Users`
--

INSERT INTO `Users` (`ID`, `username`, `password`, `date_of_birth`, `email`, `country`) VALUES
(1, 'Hrafnkell', 'Hrafnkell321', '1997-10-16', 'Kallinnhannhrabbi@hotmail.com', 'Iceland'),
(2, 'Erla', 'Erla321', '1997-01-09', 'Erla@gmail.com', 'Iceland'),
(3, 'mokka', '12345', '1970-12-24', 'mokka@hotmail.com', 'Belarus'),
(6, 'intro', '12345', '1999-09-13', 'intro@gmail.com', 'Uzbekistan'),
(7, 'villi', 'villi', '1959-05-03', 'villi@hotmail.com', 'Tunisia'),
(8, 'skúli', 'skelfir', '1917-08-18', 'skuli@skelfir.is', 'Congo'),
(9, 'test', '12', '2017-11-10', 'tt@kk.is', 'Brazil'),
(10, 'lilla', 'lilla', '2015-04-07', 'lilla@is.is', 'Kosovo'),
(11, 'kalli', 'kalli', '1984-10-19', 'k@k.k', 'Uruguay'),
(12, 'Atli', 'Erla', '2000-02-02', 'atlio@outlook.com', 'Russian Federation'),
(13, 'Throstur', 'the1234567', '1975-06-19', 'throstur@flug.is', 'Iceland'),
(14, 'stefagunn', 'babbi', '2017-05-08', 'stefania.gunnarsdotti@gamil.com', 'Iceland'),
(15, 'oad', '12345', '1969-10-19', 'oskar.adalbjarnarson@gmail.com', 'Iceland'),
(16, 'grautur', '12345', '2004-05-09', 'g@grautur.is', 'Andorra'),
(17, 'Rosa', 'rosa', '2012-09-13', 'r@r.is', 'Equatorial Guinea'),
(18, 'sorli', '1212', '1964-05-05', 'sem@tskoli.is', 'Iceland');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `Company`
--
ALTER TABLE `Company`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `Employee`
--
ALTER TABLE `Employee`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `company_ID` (`company_ID`);

--
-- Indexes for table `Games`
--
ALTER TABLE `Games`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `game_designer_ID` (`game_designer_ID`);

--
-- Indexes for table `Scores`
--
ALTER TABLE `Scores`
  ADD KEY `user_ID` (`user_ID`),
  ADD KEY `game_ID` (`game_ID`);

--
-- Indexes for table `Users`
--
ALTER TABLE `Users`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `username` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `Company`
--
ALTER TABLE `Company`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `Employee`
--
ALTER TABLE `Employee`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `Games`
--
ALTER TABLE `Games`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `Users`
--
ALTER TABLE `Users`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `Employee`
--
ALTER TABLE `Employee`
  ADD CONSTRAINT `Employee_ibfk_1` FOREIGN KEY (`company_ID`) REFERENCES `Company` (`ID`);

--
-- Constraints for table `Games`
--
ALTER TABLE `Games`
  ADD CONSTRAINT `Games_ibfk_1` FOREIGN KEY (`game_designer_ID`) REFERENCES `Employee` (`ID`);

--
-- Constraints for table `Scores`
--
ALTER TABLE `Scores`
  ADD CONSTRAINT `Scores_ibfk_1` FOREIGN KEY (`user_ID`) REFERENCES `Users` (`ID`),
  ADD CONSTRAINT `Scores_ibfk_2` FOREIGN KEY (`game_ID`) REFERENCES `Games` (`ID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
