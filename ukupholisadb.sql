-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 31, 2022 at 06:58 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ukupholisadb`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `AddAccount` (IN `HKey` INT, IN `HID` VARCHAR(255), IN `HCell` VARCHAR(255), IN `Package` INT)   INSERT INTO account(Holder_key, Holder_ID, Holder_Cell, Package_ID)
VALUES (HKey, HID, HCell, Package)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CheckAccount` (IN `hID` VARCHAR(13))   SELECT COUNT(*) FROM account WHERE Holder_ID = hID$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getAccounts` ()   SELECT *
FROM account$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getLoginAdmin` (IN `UName` VARCHAR(50), IN `UPassword` VARCHAR(50))   SELECT * FROM staff WHERE Username = UName AND UserPassword = UPassword AND Clearance = 1$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getLoginUser` (IN `UName` VARCHAR(50), IN `UPassword` VARCHAR(50))   SELECT * FROM staff WHERE Username = UName AND UserPassword = UPassword AND Clearance = 0$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `GetProviderWithTreatment` (IN `TreatmentName` VARCHAR(255))   SELECT provider.Provider_Name, treatments.Treatment, provider.Contact
FROM treatments
INNER JOIN providermedical
ON treatments.Treatment_ID = providermedical.Treatment_ID
INNER JOIN provider 
ON providermedical.Provider_ID = provider.Provider_ID
AND treatments.Treatment LIKE Concat('%',TreatmentName,'%')
AND provider.Provider_Status = 1$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `GetTreatments` ()   BEGIN
SELECT * FROM treatments;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ViewAccountCall` (IN `hID` VARCHAR(13))   SELECT dependants.Dependant_ID,dependants.Dep_Name, dependants.Dep_Surname,dependants.DOB,dependants.Sex, conditions.Condition
FROM account
INNER JOIN dependants
ON account.Account_ID = dependants.Account_ID
INNER JOIN dependantcondition
ON dependantcondition.Dependant_ID = dependants.Dependant_ID
INNER JOIN conditions 
ON conditions.Condition_ID = dependantcondition.Condition_ID
AND dependants.Account_ID = account.Account_ID WHERE
account.Holder_ID = hID$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `account`
--

CREATE TABLE `account` (
  `Account_ID` int(11) NOT NULL,
  `Holder_Key` int(5) NOT NULL,
  `Holder_ID` varchar(13) NOT NULL,
  `Holder_Cell` varchar(10) NOT NULL,
  `Package_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `account`
--

INSERT INTO `account` (`Account_ID`, `Holder_Key`, `Holder_ID`, `Holder_Cell`, `Package_ID`) VALUES
(1, 12345, '0101265114088', '0843140211', 1),
(5, 98765, '0105285084080', '0832786754', 1),
(6, 45678, '0105071467813', '0843312597', 1);

-- --------------------------------------------------------

--
-- Table structure for table `accountcall`
--

CREATE TABLE `accountcall` (
  `Holder_ID` varchar(13) NOT NULL,
  `Call_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `calls`
--

CREATE TABLE `calls` (
  `Call_ID` int(11) NOT NULL,
  `Holder_ID` varchar(13) NOT NULL,
  `Call_Date` int(11) NOT NULL,
  `Call_Start_Time` datetime NOT NULL,
  `Call_End_Time` datetime NOT NULL,
  `Call_Duration` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `claims`
--

CREATE TABLE `claims` (
  `Account_ID` int(11) NOT NULL,
  `Claim_Description` varchar(300) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `conditions`
--

CREATE TABLE `conditions` (
  `Condition_ID` int(11) NOT NULL,
  `Condition` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `conditiontreatment`
--

CREATE TABLE `conditiontreatment` (
  `Condition_ID` int(11) NOT NULL,
  `Treatment_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `dependantcondition`
--

CREATE TABLE `dependantcondition` (
  `Dependant_ID` varchar(13) NOT NULL,
  `Condition_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `dependants`
--

CREATE TABLE `dependants` (
  `Dependant_ID` varchar(13) NOT NULL,
  `Account_ID` int(11) NOT NULL,
  `Dep_Name` varchar(75) NOT NULL,
  `Dep_Surname` varchar(75) NOT NULL,
  `DOB` date NOT NULL,
  `Sex` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `dependants`
--

INSERT INTO `dependants` (`Dependant_ID`, `Account_ID`, `Dep_Name`, `Dep_Surname`, `DOB`, `Sex`) VALUES
('0105071467813', 6, 'Riaan', 'Niebuhr', '1973-12-12', 'Male'),
('0803131579746', 6, 'Aidan', 'Niebuhr', '2008-03-13', 'Male'),
('7009251236547', 6, 'Tanitha', 'Niebuhr', '1970-09-25', 'Female');

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `Package_ID` int(11) NOT NULL,
  `Package_Name` varchar(20) NOT NULL,
  `Price` double NOT NULL,
  `Availability` tinyint(1) NOT NULL,
  `Performance` double NOT NULL,
  `Cover_Level` int(11) NOT NULL,
  `Promotion` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`Package_ID`, `Package_Name`, `Price`, `Availability`, `Performance`, `Cover_Level`, `Promotion`) VALUES
(1, 'Standard', 1500, 1, 0, 5, 0);

-- --------------------------------------------------------

--
-- Table structure for table `producttreatments`
--

CREATE TABLE `producttreatments` (
  `Package_ID` int(11) NOT NULL,
  `Treatment_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `producttreatments`
--

INSERT INTO `producttreatments` (`Package_ID`, `Treatment_ID`) VALUES
(1, 1),
(1, 7),
(1, 6),
(1, 4);

-- --------------------------------------------------------

--
-- Table structure for table `provider`
--

CREATE TABLE `provider` (
  `Provider_ID` int(11) NOT NULL,
  `Provider_Name` varchar(100) NOT NULL,
  `Provider_Status` tinyint(1) NOT NULL,
  `Agreement` varchar(100) NOT NULL,
  `Contact` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `provider`
--

INSERT INTO `provider` (`Provider_ID`, `Provider_Name`, `Provider_Status`, `Agreement`, `Contact`) VALUES
(1, 'Witbank Hospital', 1, 'Discount on leg surgeries', '0845672140'),
(2, 'Middelburg Hospital', 0, 'Discount on physiotherapy', '0791256789'),
(3, 'James Dentists', 1, 'Discount on Crowns', '0823375762');

-- --------------------------------------------------------

--
-- Table structure for table `providermedical`
--

CREATE TABLE `providermedical` (
  `Provider_ID` int(11) NOT NULL,
  `Treatment_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `providermedical`
--

INSERT INTO `providermedical` (`Provider_ID`, `Treatment_ID`) VALUES
(1, 1),
(1, 3),
(1, 4),
(2, 5),
(2, 4),
(3, 6),
(3, 7),
(3, 8);

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE `staff` (
  `Staff_ID` int(11) NOT NULL,
  `Employee_Name` varchar(50) NOT NULL,
  `Employee_Surname` varchar(150) NOT NULL,
  `Contact` varchar(10) NOT NULL,
  `Employee_ID` varchar(13) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `UserPassword` varchar(100) NOT NULL,
  `Clearance` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`Staff_ID`, `Employee_Name`, `Employee_Surname`, `Contact`, `Employee_ID`, `Username`, `UserPassword`, `Clearance`) VALUES
(1, 'Francois-Dean', 'Birkholtz', '0843140211', '0101265114088', 'Dean', '12345', 1),
(2, 'Eric', 'Reyneke', '0832786754', '0105285084080', 'King', '01234', 0);

-- --------------------------------------------------------

--
-- Table structure for table `treatments`
--

CREATE TABLE `treatments` (
  `Treatment_ID` int(11) NOT NULL,
  `Treatment` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `treatments`
--

INSERT INTO `treatments` (`Treatment_ID`, `Treatment`) VALUES
(1, 'Surgery'),
(2, 'Radiation Therapy'),
(3, 'Chemotherapy'),
(4, 'Blood Transfusion'),
(5, 'Physiotherapy'),
(6, 'Dental Bridge'),
(7, 'Dental Crown'),
(8, 'Braces');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `account`
--
ALTER TABLE `account`
  ADD PRIMARY KEY (`Account_ID`),
  ADD UNIQUE KEY `Holder_Key` (`Holder_Key`),
  ADD UNIQUE KEY `Holder_ID` (`Holder_ID`),
  ADD KEY `Package_ID` (`Package_ID`);

--
-- Indexes for table `accountcall`
--
ALTER TABLE `accountcall`
  ADD KEY `Holder_ID` (`Holder_ID`),
  ADD KEY `Call_ID` (`Call_ID`);

--
-- Indexes for table `calls`
--
ALTER TABLE `calls`
  ADD PRIMARY KEY (`Call_ID`),
  ADD KEY `Holder_ID` (`Holder_ID`);

--
-- Indexes for table `claims`
--
ALTER TABLE `claims`
  ADD KEY `Account_ID` (`Account_ID`);

--
-- Indexes for table `conditions`
--
ALTER TABLE `conditions`
  ADD PRIMARY KEY (`Condition_ID`);

--
-- Indexes for table `conditiontreatment`
--
ALTER TABLE `conditiontreatment`
  ADD KEY `cd_ID` (`Condition_ID`),
  ADD KEY `trt_ID` (`Treatment_ID`),
  ADD KEY `Treatment_ID` (`Treatment_ID`);

--
-- Indexes for table `dependantcondition`
--
ALTER TABLE `dependantcondition`
  ADD KEY `Dependant_ID` (`Dependant_ID`),
  ADD KEY `Condition_ID` (`Condition_ID`),
  ADD KEY `Dependant_ID_2` (`Dependant_ID`),
  ADD KEY `Dependant_ID_3` (`Dependant_ID`,`Condition_ID`);

--
-- Indexes for table `dependants`
--
ALTER TABLE `dependants`
  ADD PRIMARY KEY (`Dependant_ID`),
  ADD KEY `Account_ID` (`Account_ID`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`Package_ID`);

--
-- Indexes for table `producttreatments`
--
ALTER TABLE `producttreatments`
  ADD KEY `Package_ID` (`Package_ID`),
  ADD KEY `Treatment_ID` (`Treatment_ID`);

--
-- Indexes for table `provider`
--
ALTER TABLE `provider`
  ADD PRIMARY KEY (`Provider_ID`);

--
-- Indexes for table `providermedical`
--
ALTER TABLE `providermedical`
  ADD KEY `prv_ID` (`Provider_ID`),
  ADD KEY `trt_ID` (`Treatment_ID`);

--
-- Indexes for table `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`Staff_ID`),
  ADD UNIQUE KEY `Username` (`Username`);

--
-- Indexes for table `treatments`
--
ALTER TABLE `treatments`
  ADD PRIMARY KEY (`Treatment_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `account`
--
ALTER TABLE `account`
  MODIFY `Account_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `conditions`
--
ALTER TABLE `conditions`
  MODIFY `Condition_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `product`
--
ALTER TABLE `product`
  MODIFY `Package_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `provider`
--
ALTER TABLE `provider`
  MODIFY `Provider_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `staff`
--
ALTER TABLE `staff`
  MODIFY `Staff_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `treatments`
--
ALTER TABLE `treatments`
  MODIFY `Treatment_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `account`
--
ALTER TABLE `account`
  ADD CONSTRAINT `account_ibfk_2` FOREIGN KEY (`Package_ID`) REFERENCES `product` (`Package_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `accountcall`
--
ALTER TABLE `accountcall`
  ADD CONSTRAINT `accountcall_ibfk_1` FOREIGN KEY (`Holder_ID`) REFERENCES `account` (`Holder_ID`),
  ADD CONSTRAINT `accountcall_ibfk_2` FOREIGN KEY (`Call_ID`) REFERENCES `calls` (`Call_ID`);

--
-- Constraints for table `claims`
--
ALTER TABLE `claims`
  ADD CONSTRAINT `claims_ibfk_1` FOREIGN KEY (`Account_ID`) REFERENCES `account` (`Account_ID`);

--
-- Constraints for table `conditions`
--
ALTER TABLE `conditions`
  ADD CONSTRAINT `conditions_ibfk_1` FOREIGN KEY (`Condition_ID`) REFERENCES `conditiontreatment` (`Condition_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `conditiontreatment`
--
ALTER TABLE `conditiontreatment`
  ADD CONSTRAINT `conditiontreatment_ibfk_1` FOREIGN KEY (`Treatment_ID`) REFERENCES `treatments` (`Treatment_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `dependantcondition`
--
ALTER TABLE `dependantcondition`
  ADD CONSTRAINT `dependantcondition_ibfk_2` FOREIGN KEY (`Condition_ID`) REFERENCES `conditions` (`Condition_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `dependantcondition_ibfk_3` FOREIGN KEY (`Dependant_ID`) REFERENCES `dependants` (`Dependant_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `dependants`
--
ALTER TABLE `dependants`
  ADD CONSTRAINT `dependants_ibfk_1` FOREIGN KEY (`Account_ID`) REFERENCES `account` (`Account_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `product`
--
ALTER TABLE `product`
  ADD CONSTRAINT `product_ibfk_1` FOREIGN KEY (`Package_ID`) REFERENCES `producttreatments` (`Package_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `producttreatments`
--
ALTER TABLE `producttreatments`
  ADD CONSTRAINT `producttreatments_ibfk_1` FOREIGN KEY (`Treatment_ID`) REFERENCES `treatments` (`Treatment_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `providermedical`
--
ALTER TABLE `providermedical`
  ADD CONSTRAINT `providermedical_ibfk_1` FOREIGN KEY (`Provider_ID`) REFERENCES `provider` (`Provider_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `providermedical_ibfk_2` FOREIGN KEY (`Treatment_ID`) REFERENCES `treatments` (`Treatment_ID`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
