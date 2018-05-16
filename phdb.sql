/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50527
Source Host           : localhost:3306
Source Database       : phdb

Target Server Type    : MYSQL
Target Server Version : 50527
File Encoding         : 65001

Date: 2013-09-30 12:35:25
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for accounts
-- ----------------------------
DROP TABLE IF EXISTS `accounts`;
CREATE TABLE `accounts` (
  `Username` varchar(16) CHARACTER SET utf8 NOT NULL,
  `Password` varchar(16) CHARACTER SET utf8 NOT NULL,
  `State` tinyint(5) unsigned NOT NULL,
  `Phone` varchar(100) CHARACTER SET utf8 DEFAULT NULL,
  `LastCheck` bigint(255) unsigned DEFAULT NULL,
  PRIMARY KEY (`Username`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of accounts
-- ----------------------------
INSERT INTO `accounts` VALUES ('admin', 'admin', '2', '', '9858480008860545808');
INSERT INTO `accounts` VALUES ('3', '3', '1', null, null);
INSERT INTO `accounts` VALUES ('محمد جمال', 'محمد', '2', '011251', null);

-- ----------------------------
-- Table structure for logs
-- ----------------------------
DROP TABLE IF EXISTS `logs`;
CREATE TABLE `logs` (
  `Account` varchar(255) NOT NULL,
  `LoginDate` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of logs
-- ----------------------------

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
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of medics
-- ----------------------------
INSERT INTO `medics` VALUES ('1', 'dfdh', '26/02/2012', '1', 'dfg fdg df gfd gfd gdf g dfgdf  لبابلا تبياليب يب ايبا لت', '15', '15');
INSERT INTO `medics` VALUES ('Ahmed', '', '15/05/2014', '2', 'ليس دواء', '12', '15');
INSERT INTO `medics` VALUES ('Felix', '', '02/12/2012', '3', null, '4', '150');
INSERT INTO `medics` VALUES ('mohamed', 'ghgf', '30/08/2015', '4', 'fghgfh', '3', '30');
INSERT INTO `medics` VALUES ('fsdgf', 'gfd', '26/02/2014', '1', 'مفيش', '12', '123');
INSERT INTO `medics` VALUES ('12', 'ghfgh', '05/09/2013', '2', 'فيه شريط ناقص من العلبه الاولى', '10', '4');
INSERT INTO `medics` VALUES ('asprin', 'ghfg', '10/09/2013', '1', 'fgdf df gdf', '0', '21');
INSERT INTO `medics` VALUES ('mags', '543', '09/09/2013', '2', '', '21', '56');

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
