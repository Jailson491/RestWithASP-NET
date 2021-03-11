CREATE TABLE IF NOT EXISTS `person` 
(
`id` BIGINT(20) NOT NULL auto_increment,
`address` VARCHAR(100) NOT NULL, 
`First_Name` VARCHAR(80) NOT NULL, 
`gender` VARCHAR(6) NOT NULL, 
`Last_Name` VARCHAR(80) NOT NULL, 
PRIMARY KEY(`id`)

)