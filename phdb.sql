/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50527
Source Host           : localhost:3306
Source Database       : phdb

Target Server Type    : MYSQL
Target Server Version : 50527
File Encoding         : 65001

Date: 2013-09-27 15:27:36
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
  `LoginDate` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of logs
-- ----------------------------
INSERT INTO `logs` VALUES ('admin', '635145050255686000');
INSERT INTO `logs` VALUES ('admin', '635145053740356000');
INSERT INTO `logs` VALUES ('3', '635145053798156000');
INSERT INTO `logs` VALUES ('admin', '635145056658416000');
INSERT INTO `logs` VALUES ('admin', '635145057020436000');
INSERT INTO `logs` VALUES ('3', '635145111137867000');
INSERT INTO `logs` VALUES ('admin', '635145114998503000');
INSERT INTO `logs` VALUES ('3', '635145115541187000');
INSERT INTO `logs` VALUES ('admin', '635145422131267000');
INSERT INTO `logs` VALUES ('admin', '635145423247567000');
INSERT INTO `logs` VALUES ('admin', '635145770290540000');
INSERT INTO `logs` VALUES ('admin', '635145800616960000');
INSERT INTO `logs` VALUES ('admin', '635145802101320000');
INSERT INTO `logs` VALUES ('admin', '635145802404580000');
INSERT INTO `logs` VALUES ('admin', '635151113062510000');
INSERT INTO `logs` VALUES ('admin', '635151114447000000');
INSERT INTO `logs` VALUES ('admin', '635151115864000000');
INSERT INTO `logs` VALUES ('admin', '635151116632420000');
INSERT INTO `logs` VALUES ('admin', '635151118632350000');
INSERT INTO `logs` VALUES ('admin', '635151203418734000');
INSERT INTO `logs` VALUES ('admin', '635151205653344000');
INSERT INTO `logs` VALUES ('admin', '635151207383834000');
INSERT INTO `logs` VALUES ('admin', '635151219831220000');
INSERT INTO `logs` VALUES ('admin', '635151220596860000');
INSERT INTO `logs` VALUES ('admin', '635151220755940000');
INSERT INTO `logs` VALUES ('admin', '635151221818340000');
INSERT INTO `logs` VALUES ('admin', '635151222364140000');
INSERT INTO `logs` VALUES ('admin', '635151222883320000');
INSERT INTO `logs` VALUES ('admin', '635151223967950000');
INSERT INTO `logs` VALUES ('3', '635151225177900000');
INSERT INTO `logs` VALUES ('3', '635151229452340000');
INSERT INTO `logs` VALUES ('admin', '635151230872090000');
INSERT INTO `logs` VALUES ('admin', '635151432067360000');
INSERT INTO `logs` VALUES ('admin', '635151433153130000');
INSERT INTO `logs` VALUES ('admin', '635151434101300000');
INSERT INTO `logs` VALUES ('admin', '635151435157730000');
INSERT INTO `logs` VALUES ('admin', '635151436356890000');
INSERT INTO `logs` VALUES ('admin', '635151436724920000');
INSERT INTO `logs` VALUES ('admin', '635151436962690000');
INSERT INTO `logs` VALUES ('admin', '635151438891950000');
INSERT INTO `logs` VALUES ('admin', '635151440362740000');
INSERT INTO `logs` VALUES ('admin', '635151440965490000');
INSERT INTO `logs` VALUES ('admin', '635151441275820000');
INSERT INTO `logs` VALUES ('admin', '635151441721670000');
INSERT INTO `logs` VALUES ('admin', '635151442017070000');
INSERT INTO `logs` VALUES ('admin', '635151442373790000');
INSERT INTO `logs` VALUES ('admin', '635151442985090000');
INSERT INTO `logs` VALUES ('3', '635156490782924000');
INSERT INTO `logs` VALUES ('admin', '635156518774990000');
INSERT INTO `logs` VALUES ('admin', '635158282380921000');
INSERT INTO `logs` VALUES ('admin', '635158906179650000');
INSERT INTO `logs` VALUES ('admin', '635158906910160000');
INSERT INTO `logs` VALUES ('admin', '635158913610850000');
INSERT INTO `logs` VALUES ('admin', '635158917233830000');
INSERT INTO `logs` VALUES ('admin', '635158918254190000');
INSERT INTO `logs` VALUES ('admin', '635158919490950000');
INSERT INTO `logs` VALUES ('admin', '635158922800300000');

-- ----------------------------
-- Table structure for medics
-- ----------------------------
DROP TABLE IF EXISTS `medics`;
CREATE TABLE `medics` (
  `Name` varchar(50) NOT NULL,
  `Substance` varchar(50) NOT NULL,
  `Expiry` varchar(10) NOT NULL DEFAULT '0',
  `Type` tinyint(5) unsigned NOT NULL DEFAULT '0',
  `Note` varchar(100) DEFAULT NULL,
  `Count` bigint(18) NOT NULL DEFAULT '0',
  `Price` varchar(18) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Name`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of medics
-- ----------------------------
INSERT INTO `medics` VALUES ('1', 'dfdh', '26/02/2012', '1', 'dfg fdg df gfd gfd gdf g dfgdf  لبابلا تبياليب يب ايبا لت', '17', '15');
INSERT INTO `medics` VALUES ('Ahmed', '', '15/05/2014', '2', 'ليس دواء', '12', '15');
INSERT INTO `medics` VALUES ('Felix', '', '02/12/2012', '3', null, '5', '150');
INSERT INTO `medics` VALUES ('mohamed', '', '30/08/2015', '4', '', '4', '30');
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
