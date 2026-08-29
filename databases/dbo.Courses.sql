USE [StudentDB]
GO

/****** Object: Table [dbo].[Courses] Script Date: 8/29/2026 10:47:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Courses] (
    [CourseId]    INT          IDENTITY (1, 1) NOT NULL,
    [CourseName]  VARCHAR (50) NOT NULL,
    [CourseHour]  INT          NOT NULL,
    [Description] TEXT         NOT NULL
);

