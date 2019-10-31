# Host: 143.248.38.192  (Version 5.5.5-10.1.22-MariaDB)
# Date: 2018-06-15 22:31:57
# Generator: MySQL-Front 6.0  (Build 2.20)


#
# Structure for table "test_data"
#

DROP TABLE IF EXISTS `test_data`;
CREATE TABLE `test_data` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `url` varchar(100) NOT NULL DEFAULT '',
  `ip` varchar(20) DEFAULT '',
  `cc` varchar(5) DEFAULT NULL,
  `pcn` varchar(255) DEFAULT NULL,
  `datetime` datetime DEFAULT NULL,
  `redirection` text,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4765359 DEFAULT CHARSET=utf8;
