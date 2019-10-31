# Host: localhost  (Version 5.7.20-log)
# Date: 2018-06-15 21:46:37
# Generator: MySQL-Front 6.0  (Build 2.20)


#
# Structure for table "carinfo"
#

DROP TABLE IF EXISTS `carinfo`;
CREATE TABLE `carinfo` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `c_name` varchar(20) DEFAULT NULL,
  `c_year` varchar(8) DEFAULT NULL,
  `c_price` varchar(10) DEFAULT NULL,
  `c_door` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
