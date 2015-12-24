/*
Navicat MySQL Data Transfer

Source Server         : FelixCo
Source Server Version : 50527
Source Host           : localhost:3306
Source Database       : phdb

Target Server Type    : MYSQL
Target Server Version : 50527
File Encoding         : 65001

Date: 2013-12-22 15:15:04
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for accounts
-- ----------------------------
DROP TABLE IF EXISTS `accounts`;
CREATE TABLE `accounts` (
  `Username` varchar(16) NOT NULL,
  `Password` text NOT NULL,
  `State` tinyint(5) unsigned NOT NULL,
  `Phone` varchar(100) DEFAULT NULL,
  `LastCheck` bigint(255) unsigned DEFAULT NULL,
  PRIMARY KEY (`Username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of accounts
-- ----------------------------
INSERT INTO `accounts` VALUES ('admin', 'admin', '2', '', '9858480008860545808');
INSERT INTO `accounts` VALUES ('user', 'user', '1', '123456', null);

-- ----------------------------
-- Table structure for bills
-- ----------------------------
DROP TABLE IF EXISTS `bills`;
CREATE TABLE `bills` (
  `ID` int(20) NOT NULL AUTO_INCREMENT,
  `Name` varchar(100) DEFAULT NULL,
  `User` varchar(100) DEFAULT NULL,
  `Medic` text,
  `BillDate` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of bills
-- ----------------------------
INSERT INTO `bills` VALUES ('12', 'fe', 'user', '1~15.5#Felix~150#Ahmed~15#gta~50#gta~50#', '20/12/2013 06:40:37 م');

-- ----------------------------
-- Table structure for logs
-- ----------------------------
DROP TABLE IF EXISTS `logs`;
CREATE TABLE `logs` (
  `Account` varchar(255) NOT NULL,
  `LoginDate` varchar(30) NOT NULL,
  `LogoutDate` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of logs
-- ----------------------------
INSERT INTO `logs` VALUES ('admin', '22/12/2013 02:52:27 م', null);
INSERT INTO `logs` VALUES ('user', '22/12/2013 02:52:35 م', null);
INSERT INTO `logs` VALUES ('admin', '22/12/2013 02:52:54 م', null);
INSERT INTO `logs` VALUES ('admin', '22/12/2013 02:54:58 م', null);
INSERT INTO `logs` VALUES ('admin', '22/12/2013 02:59:16 م', null);

-- ----------------------------
-- Table structure for medics
-- ----------------------------
DROP TABLE IF EXISTS `medics`;
CREATE TABLE `medics` (
  `Name` varchar(50) NOT NULL,
  `Substance` varchar(50) NOT NULL,
  `Expiry` varchar(10) NOT NULL DEFAULT '0',
  `Type` tinyint(5) unsigned NOT NULL DEFAULT '0',
  `Note` varchar(500) DEFAULT NULL,
  `Count` bigint(18) NOT NULL DEFAULT '0',
  `Price` varchar(18) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of medics
-- ----------------------------
INSERT INTO `medics` VALUES ('1', 'dfdh', '26/02/2012', '1', 'dfg fdg df gfd gfd gdf g dfgdf  لبابلا تبياليب يب ايبا لت', '9', '15.5');
INSERT INTO `medics` VALUES ('12', 'ghfgh', '05/09/2013', '2', 'فيه شريط ناقص من العلبه الاولى', '8', '4');
INSERT INTO `medics` VALUES ('Ahmed', '', '15/05/2014', '2', 'ليس دواء', '18', '15');
INSERT INTO `medics` VALUES ('asprin', 'ghfg', '10/09/2013', '1', 'fgdf df gdf', '0', '21.75');
INSERT INTO `medics` VALUES ('Felix', '', '02/12/2012', '3', '', '4', '150');
INSERT INTO `medics` VALUES ('fsdgf', 'gfd', '26/02/2014', '1', 'مفيش', '12', '123');
INSERT INTO `medics` VALUES ('gta', '', '18/10/2013', '1', '', '28', '50');
INSERT INTO `medics` VALUES ('mags', '543', '09/09/2013', '2', '', '21', '56.75');
INSERT INTO `medics` VALUES ('mm', 'mhbnf', '18/06/2013', '1', 'فى الرف رقم 8', '12', '10.5');
INSERT INTO `medics` VALUES ('mohamed', 'ghgf', '30/08/2015', '4', 'fghgfh', '3', '30.25');
INSERT INTO `medics` VALUES ('yy', '', '11/06/2014', '4', '', '5', '3');

-- ----------------------------
-- Table structure for medlog
-- ----------------------------
DROP TABLE IF EXISTS `medlog`;
CREATE TABLE `medlog` (
  `Name` varchar(50) NOT NULL,
  `SellDate` varchar(20) NOT NULL DEFAULT '0',
  `Total` decimal(15,0) NOT NULL DEFAULT '0',
  `Cost` varchar(15) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of medlog
-- ----------------------------
INSERT INTO `medlog` VALUES ('1', '18/09/2013 05:02:49 ', '1', '18.25');
INSERT INTO `medlog` VALUES ('Ahmed', '18/09/2013 05:28:07 ', '0', '15');
INSERT INTO `medlog` VALUES ('Ahmed', '18/09/2013 05:45:26 ', '0', '23');
INSERT INTO `medlog` VALUES ('Ahmed', '18/09/2013 05:46:42 ', '0', '15.5');
INSERT INTO `medlog` VALUES ('mohamed', '27/09/2013 02:57:09 ', '0', '30.5');
INSERT INTO `medlog` VALUES ('1', '28/09/2013 09:53:05 ', '0', '15');
INSERT INTO `medlog` VALUES ('mohamed', '28/09/2013 09:53:16 ', '0', '30');
INSERT INTO `medlog` VALUES ('1', '30/09/2013 11:32:54 ', '0', '15');
INSERT INTO `medlog` VALUES ('Felix', '30/09/2013 11:33:35 ', '0', '150');
INSERT INTO `medlog` VALUES ('gta', '18/10/2013 01:10:38 ', '0', '50');
INSERT INTO `medlog` VALUES ('1', '01/11/2013 06:01:07 ', '0', '15.5');
INSERT INTO `medlog` VALUES ('1', '01/11/2013 06:01:11 ', '0', '15.5');
INSERT INTO `medlog` VALUES ('1', '01/11/2013 06:01:13 ', '0', '15.5');
INSERT INTO `medlog` VALUES ('1', '01/11/2013 06:01:14 ', '0', '15.5');
INSERT INTO `medlog` VALUES ('1', '01/11/2013 06:01:16 ', '0', '15.5');
INSERT INTO `medlog` VALUES ('1', '01/11/2013 06:09:02 ', '0', '15.5');
INSERT INTO `medlog` VALUES ('Felix', '01/11/2013 06:09:12 ', '0', '150');
INSERT INTO `medlog` VALUES ('Ahmed', '01/11/2013 06:09:42 ', '0', '15');
INSERT INTO `medlog` VALUES ('gta', '01/11/2013 06:10:45 ', '0', '50');
INSERT INTO `medlog` VALUES ('1', '05/12/2013 11:24:55 ', '0', '15.5');
INSERT INTO `medlog` VALUES ('1', '05/12/2013 11:25:00 ', '0', '15.5');
INSERT INTO `medlog` VALUES ('1', '05/12/2013 11:25:01 ', '0', '15.5');
INSERT INTO `medlog` VALUES ('1', '05/12/2013 11:28:50 ', '0', '15.5');
INSERT INTO `medlog` VALUES ('1', '05/12/2013 11:29:06 ', '0', '15.5');
INSERT INTO `medlog` VALUES ('1', '05/12/2013 11:30:48 ', '0', '15.5');
INSERT INTO `medlog` VALUES ('1', '05/12/2013 11:32:17 ', '0', '15.5');
INSERT INTO `medlog` VALUES ('1', '05/12/2013 11:35:33 ', '0', '15.5');
INSERT INTO `medlog` VALUES ('1', '05/12/2013 11:40:43 ', '0', '15.5');
INSERT INTO `medlog` VALUES ('1', '05/12/2013 11:43:01 ', '0', '15.5');
INSERT INTO `medlog` VALUES ('1', '05/12/2013 11:43:52 ', '0', '15.5');
INSERT INTO `medlog` VALUES ('1', '05/12/2013 11:49:35 ', '0', '15.5');
INSERT INTO `medlog` VALUES ('1', '05/12/2013 11:52:31 ', '0', '15.5');
INSERT INTO `medlog` VALUES ('1', '05/12/2013 11:55:38 ', '0', '15.5');
INSERT INTO `medlog` VALUES ('Felix', '05/12/2013 11:56:06 ', '0', '150');
INSERT INTO `medlog` VALUES ('Felix', '05/12/2013 11:56:15 ', '0', '150');
INSERT INTO `medlog` VALUES ('1', '05/12/2013 11:58:47 ', '0', '15.5');
INSERT INTO `medlog` VALUES ('1', '06/12/2013 12:01:29 ', '0', '15.5');
INSERT INTO `medlog` VALUES ('Felix', '06/12/2013 03:13:23 ', '0', '150');
INSERT INTO `medlog` VALUES ('Felix', '06/12/2013 03:15:28 ', '0', '150');
INSERT INTO `medlog` VALUES ('Felix', '06/12/2013 03:15:31 ', '0', '150');
INSERT INTO `medlog` VALUES ('Felix', '06/12/2013 03:15:49 ', '0', '150');
INSERT INTO `medlog` VALUES ('Felix', '06/12/2013 03:16:54 ', '0', '150');
INSERT INTO `medlog` VALUES ('1', '06/12/2013 03:17:42 ', '0', '15.5');
INSERT INTO `medlog` VALUES ('12', '06/12/2013 03:21:58 ', '0', '4');
INSERT INTO `medlog` VALUES ('1', '06/12/2013 03:26:23 ', '0', '15.5');
INSERT INTO `medlog` VALUES ('Felix', '06/12/2013 03:26:44 ', '0', '150');
INSERT INTO `medlog` VALUES ('Felix', '06/12/2013 03:27:31 ', '0', '150');
INSERT INTO `medlog` VALUES ('Felix', '06/12/2013 03:27:35 ', '0', '150');
INSERT INTO `medlog` VALUES ('1', '06/12/2013 05:07:58 ', '0', '15.5');
INSERT INTO `medlog` VALUES ('1', '06/12/2013 05:12:31 ', '0', '15.5');
INSERT INTO `medlog` VALUES ('1', '20/12/2013 05:18:19 ', '0', '15.5');
INSERT INTO `medlog` VALUES ('1', '20/12/2013 05:18:47 ', '0', '15.5');
INSERT INTO `medlog` VALUES ('1', '20/12/2013 05:50:49 ', '0', '15.5');
INSERT INTO `medlog` VALUES ('gta', '20/12/2013 05:51:10 ', '0', '50');
INSERT INTO `medlog` VALUES ('Felix', '20/12/2013 05:51:21 ', '0', '150');
INSERT INTO `medlog` VALUES ('1', '20/12/2013 05:51:40 ', '0', '15.5');
INSERT INTO `medlog` VALUES ('gta', '20/12/2013 06:15:08 ', '0', '50');
INSERT INTO `medlog` VALUES ('Ahmed', '20/12/2013 06:17:38 ', '0', '15');
INSERT INTO `medlog` VALUES ('1', '20/12/2013 06:18:08 ', '0', '15.5');
INSERT INTO `medlog` VALUES ('1', '20/12/2013 06:35:23 ', '0', '15.5');
INSERT INTO `medlog` VALUES ('Felix', '20/12/2013 06:35:30 ', '0', '150');
INSERT INTO `medlog` VALUES ('1', '20/12/2013 06:38:21 ', '0', '15.5');
INSERT INTO `medlog` VALUES ('1', '20/12/2013 06:38:23 ', '0', '15.5');
INSERT INTO `medlog` VALUES ('1', '20/12/2013 06:38:24 ', '0', '15.5');
INSERT INTO `medlog` VALUES ('1', '20/12/2013 06:40:37 ', '0', '15.5');
INSERT INTO `medlog` VALUES ('Felix', '20/12/2013 06:40:44 ', '0', '150');
INSERT INTO `medlog` VALUES ('Ahmed', '20/12/2013 06:40:51 ', '0', '15');
INSERT INTO `medlog` VALUES ('gta', '20/12/2013 06:40:58 ', '0', '50');
INSERT INTO `medlog` VALUES ('gta', '20/12/2013 06:40:59 ', '0', '50');
