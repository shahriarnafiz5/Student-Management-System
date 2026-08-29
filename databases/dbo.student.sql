USE [StudentDB]
GO

/****** Object: Table [dbo].[student] Script Date: 8/29/2026 10:51:10 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[student] (
    [StdId]        INT           IDENTITY (1, 1) NOT NULL,
    [StdFirstName] VARCHAR (15)  NOT NULL,
    [StdLastName]  VARCHAR (15)  NOT NULL,
    [Birthdate]    DATE          NOT NULL,
    [Gender]       VARCHAR (10)  NOT NULL,
    [Phone]        VARCHAR (15)  NOT NULL,
    [Address]      TEXT          NOT NULL,
    [username]     VARCHAR (50)  NULL,
    [password]     VARCHAR (255) NULL
);
