DELIMITER // CREATE PROCEDURE sp_UserSave (IN in_UserName varchar(100), IN in_Password varchar(255)) BEGIN INSERT INTO kal_User (usr_Name, usr_Password) values (in_Username, in_Password); END

DELIMITER // CREATE PROCEDURE sp_UserGetByCredentials (IN in_UserName varchar(100), IN in_Password varchar(255)) BEGIN SELECT usr_Id, usr_Name, usr_Password FROM kal_User WHERE usr_Name = in_UserName and usr_Password = in_Password; END