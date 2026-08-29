USE [StudentDB]
GO

/****** Object: Table [dbo].[Users] Script Date: 8/29/2026 10:54:04 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Username] VARCHAR (50)  NOT NULL,
    [Password] VARCHAR (255) NOT NULL,
    [Role]     VARCHAR (20)  NOT NULL
);


