USE [StudentDB]
GO

/****** Object: Table [dbo].[Admins] Script Date: 8/29/2026 10:43:39 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Admins] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [Name]      NVARCHAR (100) NOT NULL,
    [Phone]     VARCHAR (20)   NULL,
    [BirthDate] DATE           NULL,
    [Gender]    VARCHAR (10)   NULL,
    [Username]  VARCHAR (50)   NOT NULL,
    [Password]  VARCHAR (255)  NOT NULL,
    [Address]   NVARCHAR (255) NULL
);


