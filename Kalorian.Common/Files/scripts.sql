IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_UserSave]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_UserSave]

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_UserGetById]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_UserGetById]

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_UserSave]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_UserSave]
	@UserName varchar(100),
	@Password varchar(100)
AS
BEGIN
	INSERT INTO kal_User (usr_Name, usr_Password) values (@UserName, @Password)
END'
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_UserGetById]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_UserGetById]
	@Id int
AS
BEGIN
	SELECT 
		usr_Id as Id,
		usr_Name as Name,
		usr_Password as Password
	FROM kal_User usr
	WHERE usr.usr_Id = @Id
END'
END