IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[kal_User]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[kal_User](
	[usr_Id] [int] IDENTITY(1,1) NOT NULL,
	[usr_Name] [varchar](100) NOT NULL,
	[usr_Password] [varchar](100) NOT NULL,
 CONSTRAINT [PK_kal_User] PRIMARY KEY CLUSTERED 
(
	[usr_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END