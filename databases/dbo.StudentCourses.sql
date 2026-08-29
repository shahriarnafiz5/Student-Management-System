USE [StudentDB]
GO

/****** Object: Table [dbo].[StudentCourses] Script Date: 8/29/2026 10:52:35 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[StudentCourses] (
    [EnrollmentID] INT           IDENTITY (1, 1) NOT NULL,
    [StdId]        INT           NULL,
    [CourseId]     INT           NULL,
    [CourseName]   VARCHAR (100) NULL
);


