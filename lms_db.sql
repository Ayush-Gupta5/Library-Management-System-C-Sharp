-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 31, 2023 at 08:41 AM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.0.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `lms_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `Id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`Id`, `username`, `Password`) VALUES
(1, 'admin', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `book`
--

CREATE TABLE `book` (
  `Id` int(11) NOT NULL,
  `Book_No` int(11) NOT NULL,
  `Name` varchar(200) NOT NULL,
  `Author` varchar(100) NOT NULL,
  `Publisher` varchar(100) NOT NULL,
  `Price` double NOT NULL,
  `Quantity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `book`
--

INSERT INTO `book` (`Id`, `Book_No`, `Name`, `Author`, `Publisher`, `Price`, `Quantity`) VALUES
(5, 1, 'PHP Beginners Practical Guide ', 'Guleria Pratiyush', 'BPB Publications', 309, 2),
(6, 2, 'Programming in Python  ', 'Dr Pooja Sharma', 'BPB Publication', 460, 13),
(7, 3, 'Java the Complete Reference', '\r\nSCHILDT', 'McGraw Hill Education India', 915, 5),
(8, 4, 'Software Engineering  ', '\r\nSommerville Ian', ' Pearson Education India', 856, 11),
(9, 5, 'C in Depth', '\r\nSrivastava Deepali', ' BPB Publications', 440, 1),
(10, 6, 'andriod ', 'abc', 'abcccc', 245, 1);

-- --------------------------------------------------------

--
-- Table structure for table `issuebook`
--

CREATE TABLE `issuebook` (
  `id` int(11) NOT NULL,
  `Issue_No` int(11) NOT NULL,
  `Kid` varchar(20) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Department` varchar(50) NOT NULL,
  `Mobile` bigint(13) NOT NULL,
  `Book_Name` varchar(200) NOT NULL,
  `Date` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `issuebook`
--

INSERT INTO `issuebook` (`id`, `Issue_No`, `Kid`, `Name`, `Department`, `Mobile`, `Book_Name`, `Date`) VALUES
(5, 1, 'K23180', 'Ayush Gupta', 'Computer Application', 9414078069, 'PHP Beginners Practical Guide ', '16 April 2023'),
(6, 2, 'K23519', 'Arihant Jain', 'Computer Application', 1234567890, 'C in Depth', '16 April 2023'),
(7, 3, 'K23834', 'Renu Sharma', 'Computer Application', 1234567890, 'C in Depth', '19 April 2023'),
(8, 4, 'K23770', 'Sohin Ali', 'Computer Application', 1234567890, 'Programming in Python  ', '18 April 2023'),
(9, 5, 'K23180', 'Ayush Gupta', 'Computer Application', 9414078069, 'andriod ', '06 May 2023');

-- --------------------------------------------------------

--
-- Table structure for table `returnbook`
--

CREATE TABLE `returnbook` (
  `id` int(11) NOT NULL,
  `Issue_no` int(11) NOT NULL,
  `Return_no` int(11) NOT NULL,
  `Kid` varchar(20) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Department` varchar(50) NOT NULL,
  `Mobile` bigint(13) NOT NULL,
  `Book_name` varchar(100) NOT NULL,
  `Issue_date` varchar(20) NOT NULL,
  `Return_date` varchar(20) NOT NULL,
  `Penalty` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `returnbook`
--

INSERT INTO `returnbook` (`id`, `Issue_no`, `Return_no`, `Kid`, `Name`, `Department`, `Mobile`, `Book_name`, `Issue_date`, `Return_date`, `Penalty`) VALUES
(1, 1, 1, 'K23180', 'Ayush Gupta', 'Computer Application', 9414078069, 'PHP Beginners Practical Guide ', '16 April 2023', '24 April 2023', 5),
(2, 2, 2, 'K23519', 'Arihant Jain', 'Computer Application', 1234567890, 'C in Depth', '16 April 2023', '27 April 2023', 20),
(3, 5, 3, 'K23180', 'Ayush Gupta', 'Computer Application', 9414078069, 'andriod ', '06 May 2023', '11 May 2023', 0);

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE `student` (
  `id` int(11) NOT NULL,
  `Kid` varchar(20) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Department` varchar(50) NOT NULL,
  `Course` varchar(50) NOT NULL,
  `Year` varchar(20) NOT NULL,
  `Mobile` bigint(13) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`id`, `Kid`, `Name`, `Department`, `Course`, `Year`, `Mobile`) VALUES
(18, 'K23180', 'Ayush Gupta', 'Computer Application', 'MCA', '1st ', 9414078069),
(19, 'K23519', 'Arihant Jain', 'Computer Application', 'MCA', '1st ', 1234567890),
(20, 'K23771', 'Divyansh Bhattacharya', 'Computer Application', 'MCA', '1st ', 1234567890),
(21, 'K23040', 'Rahul Yadav', 'Computer Application', 'MCA', '1st ', 1234567890),
(22, 'K23834', 'Renu Sharma', 'Computer Application', 'MCA', '1st ', 1234567890),
(23, 'K23770', 'Sohin Ali', 'Computer Application', 'MCA', '1st ', 1234567890),
(24, 'K23793', 'Teena Sukhwani', 'Computer Application', 'MCA', '1st ', 1234567890);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `book`
--
ALTER TABLE `book`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `issuebook`
--
ALTER TABLE `issuebook`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `returnbook`
--
ALTER TABLE `returnbook`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `book`
--
ALTER TABLE `book`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `issuebook`
--
ALTER TABLE `issuebook`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `returnbook`
--
ALTER TABLE `returnbook`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `student`
--
ALTER TABLE `student`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
