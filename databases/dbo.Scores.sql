USE [StudentDB]
GO

/****** Object: Table [dbo].[Scores] Script Date: 8/29/2026 10:49:06 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Scores] (
    [ScoreId]  INT            IDENTITY (1, 1) NOT NULL,
    [StdId]    INT            NOT NULL,
    [CourseId] INT            NOT NULL,
    [Score]    DECIMAL (5, 2) NULL
);


