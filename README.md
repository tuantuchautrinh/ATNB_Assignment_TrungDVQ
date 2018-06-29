# Made by Trịnh Châu Tuấn Tú 
ATNB_Assignment_TrungDVQ exercise.

	<!-- Tạo mới Project với Microsoft Visual Studio -->
		// Create new project with .NET Framework 4.5 to setup EntityFramework.

	<!--  Add New Item - Models with ADO.NET Entity Data Model with name 'ATNB_Assignment_TrungDVQDbContext' -->
	
		/****** EF Design from database ******/
		Creates a model in the EF Designer based on an existing database. You can choose the database
		connection, settings for the model, and database objects to include in the model. The classes your
		application will interact with are generated from the model.

		/****** Empty EF Designer model ******/
		Creates an empty model in the EF Designer as a starting point for visually designing your model.
		Later, you can generate a database from your model. The classes your application will interact with
		are generated from the model.

		/****** Empty Code First model ******/
		Creates an empty Code First model as a starting point for designing your model using code. Later,
		you can generate a database from your model.

           choose  =>    /****** Code First from database ******/
		Creates a Code First model based on an existing database. You can choose the database connection,
		settings for the model, and database objects to include in the model.

	<!-- Tạo Database với Microsoft SQL Server Mangament Studio -->

 	 _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _
	|														|
	|	/****** Xóa Database cũ với tên 'BookStoreDatabase' ******/					  	|
	|	DROP DATABASE BookStoreDatabase;							  		|
	|											  			|
	|	/****** Tạo mới Database mới với tên 'BookStoreDatabase' ******/					|
	|	CREATE DATABASE BookStoreDatabase;									|
	|														|
	|	USE [BookStoreDatabase]											|
	|	GO													|
	|	/****** Object:  Table [dbo].[Admin]    Script Date: **/**/**** **:**:** ******/			|
	|	SET ANSI_NULLS ON											|
	|	GO													|
	|	SET QUOTED_IDENTIFIER ON										|
	|	GO													|
	|	SET ANSI_PADDING ON											|
	|	GO													|
	|	CREATE TABLE [dbo].[Admin](										|
	|		[UserName] [varchar](50) NOT NULL,								|
	|		[Password] [varchar](50) NULL,									|
	|	 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 								|
	|	(													|
	|		[UserName] ASC											|
	|	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,				|
	|		ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]					|
	|	) ON [PRIMARY]												|
	|														|
	|	GO													|
	|	SET ANSI_PADDING OFF											|
	|	GO													|
	|	/****** Object:  Table [dbo].[Author]    Script Date: **/**/**** **:**:** ******/			|
	|	SET ANSI_NULLS ON											|
	|	GO													|
	|	SET QUOTED_IDENTIFIER ON										|
	|	GO													|
	|	CREATE TABLE [dbo].[Author](										|
	|		[AuthorId] [int] IDENTITY(1,1) NOT NULL,							|
	|		[AuthorName] [nvarchar](50) NULL,								|
	|		[History] [nvarchar](max) NULL,									|
	|	 CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED 								|
	|	(													|
	|		[AuthorId] ASC											|
	|	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,				|
	|		ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]					|
	|	) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]									|
	|														|
	|	GO													|
	|	/****** Object:  Table [dbo].[Book]    Script Date: **/**/**** **:**:** ******/				|
	|	SET ANSI_NULLS ON											|
	|	GO													|
	|	SET QUOTED_IDENTIFIER ON										|
	|	GO													|
	|	SET ANSI_PADDING ON											|
	|	GO													|
	|	CREATE TABLE [dbo].[Book](										|
	|		[BookId] [int] IDENTITY(1,1) NOT NULL,								|
	|		[Title] [nvarchar](50) NULL,									|
	|		[CateId] [int] NULL,										|
	|		[AuthorId] [int] NULL,										|
	|		[PubId] [int] NULL,										|
	|		[Summary] [nvarchar](max) NULL,									|
	|		[ImgUrl] [varchar](50) NULL,									|
	|		[Price] [float] NULL,										|
	|		[Quantity] [int] NULL,										|
	|		[CreatedDate] [date] NULL,									|
	|		[ModifiedDate] [date] NULL,									|
	|		[IsActive] [bit] NULL,										|
	|	 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 								|
	|	(													|
	|		[BookId] ASC											|
	|	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,				|
	|		ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]					|
	|	) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]									|
	|														|
	|	GO													|
	|	SET ANSI_PADDING OFF											|
	|	GO													|
	|	/****** Object:  Table [dbo].[Category]    Script Date: **/**/**** **:**:** ******/			|
	|	SET ANSI_NULLS ON											|
	|	GO													|
	|	SET QUOTED_IDENTIFIER ON										|
	|	GO													|
	|	CREATE TABLE [dbo].[Category](										|
	|		[CateId] [int] IDENTITY(1,1) NOT NULL,								|
	|		[CateName] [nvarchar](50) NULL,									|
	|		[Description] [nvarchar](max) NULL,								|
	|	 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 							|
	|	(													|
	|		[CateId] ASC											|
	|	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,				|
	|		ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]					|
	|	) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]									|
	|														|
	|	GO													|
	|	/****** Object:  Table [dbo].[Comment]    Script Date: **/**/**** **:**:** ******/			|
	|	SET ANSI_NULLS ON											|
	|	SET QUOTED_IDENTIFIER ON										|
	|	GO													|
	|	CREATE TABLE [dbo].[Comment](										|
	|		[CommentId] [int] IDENTITY(1,1) NOT NULL,							|
	|		[BookId] [int] NULL,										|
	|		[Content] [nvarchar](max) NULL,									|
	|		[CreatedDate] [date] NULL,									|
	|		[IsActive] [bit] NULL,										|
	|	 CONSTRAINT [PK_Comment] PRIMARY KEY CLUSTERED 								|
	|	(													|
	|		[CommentId] ASC											|
	|	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,				|
	|		ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]					|
	|	) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]									|
	|														|
	|	GO													|
	|	/****** Object:  Table [dbo].[Publisher]    Script Date: **/**/**** **:**:** ******/			|
	|	SET ANSI_NULLS ON											|
	|	GO													|
	|	SET QUOTED_IDENTIFIER ON										|
	|	GO													|
	|	CREATE TABLE [dbo].[Publisher](										|
	|		[PubId] [int] IDENTITY(1,1) NOT NULL,								|
	|		[Name] [nvarchar](50) NULL,									|
	|		[Description] [nvarchar](max) NULL,								|
	|	 CONSTRAINT [PK_Publisher] PRIMARY KEY CLUSTERED 							|
	|	(													|
	|		[PubId] ASC											|
	|	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,				|
	|		ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]					|
	|	) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]									|
	|														|
	|	GO													|
	|	/****** Object:  Table [dbo].[Users]    Script Date: **/**/**** **:**:** ******/			|
	|	SET ANSI_NULLS ON											|
	|	GO													|
	|	SET QUOTED_IDENTIFIER ON										|
	|	GO													|
	|	SET ANSI_PADDING ON											|
	|	GO													|
	|	CREATE TABLE [dbo].[Users](										|
	|		[UserName] [varchar](50) NOT NULL,								|
	|		[Password] [varchar](50) NULL,									|
	|		[Email] [varchar](50) NULL,									|
	|		[IsActive] [bit] NULL,										|
	|	 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 								|
	|	(													|
	|		[UserName] ASC											|
	|	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,				|
	|		ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]					|
	|	) ON [PRIMARY]												|
	|														|
	|	GO													|
	|	SET ANSI_PADDING OFF											|
	|	GO													|
	|	ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_Author]					|
	|	FOREIGN KEY([AuthorId])											|
	|	REFERENCES [dbo].[Author] ([AuthorId])									|
	|	GO													|
	|	ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_Author]						|
	|	GO													|
	|	ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_Category]					|
	|	FOREIGN KEY([CateId])											|
	|	REFERENCES [dbo].[Category] ([CateId])									|
	|	GO													|
	|	ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_Category]						|
	|	GO													|
	|	ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_Publisher]				|
	|	FOREIGN KEY([PubId])											|
	|	REFERENCES [dbo].[Publisher] ([PubId])									|
	|	GO													|
	|	ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_Publisher]						|
	|	GO													|
	|	ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_Comment_Book]				|
	|	FOREIGN KEY([BookId])											|
	|	REFERENCES [dbo].[Book] ([BookId])									|
	|	GO													|
	|	ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK_Comment_Book]						|
	|	GO													|
	|_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _|

	<!-- Tạo procedure cho Users -->
		// Create PROCEDURE Users_Login
		 _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _
		|						|
		|	USE [BookStoreDatabase]			|
		|	GO					|
		|						|
		|	SET ANSI_NULLS ON			|
		|	GO					|
		|	SET QUOTED_IDENTIFIER ON		|
		|	GO					|
		|	CREATE PROCEDURE Admin_Login		|
		|	AS					|
		|	BEGIN					|
		|		select * from Admin		|
		|	END					|
		|_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _|
