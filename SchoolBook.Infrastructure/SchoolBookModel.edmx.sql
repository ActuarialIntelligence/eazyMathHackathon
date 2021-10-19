
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/25/2017 17:47:55
-- Generated from EDMX file: C:\Users\jyp1510\Documents\Projects\SchoolBookBackup20171114\SchoolBookBackup\SchoolBook.Infrastructure\SchoolBookModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SchoolBook];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__HomeWork___SubSy__35BCFE0A]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HomeWork_Assign] DROP CONSTRAINT [FK__HomeWork___SubSy__35BCFE0A];
GO
IF OBJECT_ID(N'[dbo].[FK__HomeWorkP__Param__286302EC]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HomeWorkParametersStudentPairings] DROP CONSTRAINT [FK__HomeWorkP__Param__286302EC];
GO
IF OBJECT_ID(N'[dbo].[FK__SubSyllab__Sylla__2D27B809]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SubSyllabus] DROP CONSTRAINT [FK__SubSyllab__Sylla__2D27B809];
GO
IF OBJECT_ID(N'[dbo].[FK_HomeWork_HomeWork_Assign]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HomeWork] DROP CONSTRAINT [FK_HomeWork_HomeWork_Assign];
GO
IF OBJECT_ID(N'[dbo].[FK_HomeWork_SubSyllabus]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HomeWork] DROP CONSTRAINT [FK_HomeWork_SubSyllabus];
GO
IF OBJECT_ID(N'[dbo].[FK_HomeWorkParametersStudentPairings_HomeWork_Assign]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HomeWorkParametersStudentPairings] DROP CONSTRAINT [FK_HomeWorkParametersStudentPairings_HomeWork_Assign];
GO
IF OBJECT_ID(N'[dbo].[FK_PairingStudentPairing_HomeWorkParametersStudentPairings]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PairingStudentPairing] DROP CONSTRAINT [FK_PairingStudentPairing_HomeWorkParametersStudentPairings];
GO
IF OBJECT_ID(N'[dbo].[FK_PairingStudentPairing_StudentTable]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PairingStudentPairing] DROP CONSTRAINT [FK_PairingStudentPairing_StudentTable];
GO
IF OBJECT_ID(N'[dbo].[FK_Syllabus_GradeSyllabusPairing]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Syllabus] DROP CONSTRAINT [FK_Syllabus_GradeSyllabusPairing];
GO
IF OBJECT_ID(N'[dbo].[FK_TutorStudentRelationship_StudentTable]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TutorStudentRelationship] DROP CONSTRAINT [FK_TutorStudentRelationship_StudentTable];
GO
IF OBJECT_ID(N'[dbo].[FK_TutorStudentRelationship_TutorTable]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TutorStudentRelationship] DROP CONSTRAINT [FK_TutorStudentRelationship_TutorTable];
GO
IF OBJECT_ID(N'[dbo].[FK_YouTubeSpecific_SubSyllabus]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[YouTubeSpecific] DROP CONSTRAINT [FK_YouTubeSpecific_SubSyllabus];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[GradeSyllabusPairing]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GradeSyllabusPairing];
GO
IF OBJECT_ID(N'[dbo].[HomeWork]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HomeWork];
GO
IF OBJECT_ID(N'[dbo].[HomeWork_Assign]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HomeWork_Assign];
GO
IF OBJECT_ID(N'[dbo].[HomeworkParameters]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HomeworkParameters];
GO
IF OBJECT_ID(N'[dbo].[HomeWorkParametersStudentPairings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HomeWorkParametersStudentPairings];
GO
IF OBJECT_ID(N'[dbo].[PairingStudentPairing]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PairingStudentPairing];
GO
IF OBJECT_ID(N'[dbo].[StudentTable]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StudentTable];
GO
IF OBJECT_ID(N'[dbo].[SubSyllabus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SubSyllabus];
GO
IF OBJECT_ID(N'[dbo].[Syllabus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Syllabus];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[TutorStudentRelationship]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TutorStudentRelationship];
GO
IF OBJECT_ID(N'[dbo].[TutorTable]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TutorTable];
GO
IF OBJECT_ID(N'[dbo].[YouTubeSpecific]', 'U') IS NOT NULL
    DROP TABLE [dbo].[YouTubeSpecific];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'HomeWork'
CREATE TABLE [dbo].[HomeWork] (
    [HomeWorkID] int  NOT NULL,
    [Questions] nvarchar(max)  NULL,
    [Answers] nvarchar(max)  NULL,
    [IsCorrect] int  NULL,
    [Percentage_Correct] decimal(18,0)  NULL,
    [SubSyllabusID] int  NOT NULL,
    [ID] int IDENTITY(1,1) NOT NULL,
    [StudentAnswers] nvarchar(max)  NULL
);
GO

-- Creating table 'HomeWork_Assign'
CREATE TABLE [dbo].[HomeWork_Assign] (
    [SubSyllabusID] int  NOT NULL,
    [NoOfQuestions] int  NOT NULL,
    [HomeWorkID] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NULL
);
GO

-- Creating table 'HomeworkParameters'
CREATE TABLE [dbo].[HomeworkParameters] (
    [ParametersID] int  NOT NULL,
    [NoOfTerms] int  NULL,
    [NoOfLawsInUse] int  NULL,
    [HighestNumber] decimal(18,0)  NULL,
    [HighestNumberPow] int  NULL,
    [ComplexityID] int  NULL,
    [ArithOrGeom] int  NULL,
    [highest_a] decimal(18,0)  NULL,
    [highest_n] int  NULL,
    [highest_d] decimal(18,0)  NULL,
    [highest_r] decimal(18,0)  NULL,
    [DegreeOfRemoval] int  NULL,
    [maxSides] int  NULL,
    [AngleOrSide] int  NULL
);
GO

-- Creating table 'HomeWorkParametersStudentPairings'
CREATE TABLE [dbo].[HomeWorkParametersStudentPairings] (
    [PairingID] int  NOT NULL,
    [ParametersID] int  NOT NULL,
    [HomeWorkID] int  NOT NULL,
    [DateTime] datetime  NULL
);
GO

-- Creating table 'PairingStudentPairings'
CREATE TABLE [dbo].[PairingStudentPairings] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [PairingID] int  NOT NULL,
    [StudentID] int  NOT NULL,
    [DateTime] datetime  NULL
);
GO

-- Creating table 'StudentTables'
CREATE TABLE [dbo].[StudentTables] (
    [StudentID] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(255)  NOT NULL,
    [ImgUrl] varchar(max)  NULL,
    [AreaCode] int  NULL,
    [EmailAddress] varchar(max)  NULL,
    [PlaceKey] nvarchar(max)  NULL
);
GO

-- Creating table 'SubSyllabus'
CREATE TABLE [dbo].[SubSyllabus] (
    [ID] int  NOT NULL,
    [SyllabusID] int  NOT NULL,
    [Name] varchar(400)  NULL
);
GO

-- Creating table 'Syllabus'
CREATE TABLE [dbo].[Syllabus] (
    [ID] int  NOT NULL,
    [Name] varchar(400)  NOT NULL,
    [GradeID] int  NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'TutorStudentRelationships'
CREATE TABLE [dbo].[TutorStudentRelationships] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [TutorID] int  NOT NULL,
    [StudentID] int  NOT NULL
);
GO

-- Creating table 'TutorTables'
CREATE TABLE [dbo].[TutorTables] (
    [TutorID] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(255)  NOT NULL,
    [ImgUrl] varchar(max)  NULL,
    [AreaCode] int  NULL,
    [EmailAddress] varchar(max)  NULL,
    [PlaceKey] varchar(max)  NULL
);
GO

-- Creating table 'YouTubeSpecifics'
CREATE TABLE [dbo].[YouTubeSpecifics] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [SubSyllabusID] int  NOT NULL,
    [ImageLink] varchar(max)  NULL,
    [VideoLink] varchar(max)  NULL
);
GO

-- Creating table 'GradeSyllabusPairings'
CREATE TABLE [dbo].[GradeSyllabusPairings] (
    [GradeID] int IDENTITY(1,1) NOT NULL,
    [Grade] int  NOT NULL,
    [Name] varchar(255)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'HomeWork'
ALTER TABLE [dbo].[HomeWork]
ADD CONSTRAINT [PK_HomeWork]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [HomeWorkID] in table 'HomeWork_Assign'
ALTER TABLE [dbo].[HomeWork_Assign]
ADD CONSTRAINT [PK_HomeWork_Assign]
    PRIMARY KEY CLUSTERED ([HomeWorkID] ASC);
GO

-- Creating primary key on [ParametersID] in table 'HomeworkParameters'
ALTER TABLE [dbo].[HomeworkParameters]
ADD CONSTRAINT [PK_HomeworkParameters]
    PRIMARY KEY CLUSTERED ([ParametersID] ASC);
GO

-- Creating primary key on [PairingID] in table 'HomeWorkParametersStudentPairings'
ALTER TABLE [dbo].[HomeWorkParametersStudentPairings]
ADD CONSTRAINT [PK_HomeWorkParametersStudentPairings]
    PRIMARY KEY CLUSTERED ([PairingID] ASC);
GO

-- Creating primary key on [ID] in table 'PairingStudentPairings'
ALTER TABLE [dbo].[PairingStudentPairings]
ADD CONSTRAINT [PK_PairingStudentPairings]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [StudentID] in table 'StudentTables'
ALTER TABLE [dbo].[StudentTables]
ADD CONSTRAINT [PK_StudentTables]
    PRIMARY KEY CLUSTERED ([StudentID] ASC);
GO

-- Creating primary key on [ID] in table 'SubSyllabus'
ALTER TABLE [dbo].[SubSyllabus]
ADD CONSTRAINT [PK_SubSyllabus]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Syllabus'
ALTER TABLE [dbo].[Syllabus]
ADD CONSTRAINT [PK_Syllabus]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [ID] in table 'TutorStudentRelationships'
ALTER TABLE [dbo].[TutorStudentRelationships]
ADD CONSTRAINT [PK_TutorStudentRelationships]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [TutorID] in table 'TutorTables'
ALTER TABLE [dbo].[TutorTables]
ADD CONSTRAINT [PK_TutorTables]
    PRIMARY KEY CLUSTERED ([TutorID] ASC);
GO

-- Creating primary key on [ID] in table 'YouTubeSpecifics'
ALTER TABLE [dbo].[YouTubeSpecifics]
ADD CONSTRAINT [PK_YouTubeSpecifics]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [GradeID] in table 'GradeSyllabusPairings'
ALTER TABLE [dbo].[GradeSyllabusPairings]
ADD CONSTRAINT [PK_GradeSyllabusPairings]
    PRIMARY KEY CLUSTERED ([GradeID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [HomeWorkID] in table 'HomeWork'
ALTER TABLE [dbo].[HomeWork]
ADD CONSTRAINT [FK_HomeWork_HomeWork_Assign]
    FOREIGN KEY ([HomeWorkID])
    REFERENCES [dbo].[HomeWork_Assign]
        ([HomeWorkID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HomeWork_HomeWork_Assign'
CREATE INDEX [IX_FK_HomeWork_HomeWork_Assign]
ON [dbo].[HomeWork]
    ([HomeWorkID]);
GO

-- Creating foreign key on [SubSyllabusID] in table 'HomeWork'
ALTER TABLE [dbo].[HomeWork]
ADD CONSTRAINT [FK_HomeWork_SubSyllabus]
    FOREIGN KEY ([SubSyllabusID])
    REFERENCES [dbo].[SubSyllabus]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HomeWork_SubSyllabus'
CREATE INDEX [IX_FK_HomeWork_SubSyllabus]
ON [dbo].[HomeWork]
    ([SubSyllabusID]);
GO

-- Creating foreign key on [SubSyllabusID] in table 'HomeWork_Assign'
ALTER TABLE [dbo].[HomeWork_Assign]
ADD CONSTRAINT [FK__HomeWork___SubSy__35BCFE0A]
    FOREIGN KEY ([SubSyllabusID])
    REFERENCES [dbo].[SubSyllabus]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__HomeWork___SubSy__35BCFE0A'
CREATE INDEX [IX_FK__HomeWork___SubSy__35BCFE0A]
ON [dbo].[HomeWork_Assign]
    ([SubSyllabusID]);
GO

-- Creating foreign key on [HomeWorkID] in table 'HomeWorkParametersStudentPairings'
ALTER TABLE [dbo].[HomeWorkParametersStudentPairings]
ADD CONSTRAINT [FK_HomeWorkParametersStudentPairings_HomeWork_Assign]
    FOREIGN KEY ([HomeWorkID])
    REFERENCES [dbo].[HomeWork_Assign]
        ([HomeWorkID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HomeWorkParametersStudentPairings_HomeWork_Assign'
CREATE INDEX [IX_FK_HomeWorkParametersStudentPairings_HomeWork_Assign]
ON [dbo].[HomeWorkParametersStudentPairings]
    ([HomeWorkID]);
GO

-- Creating foreign key on [ParametersID] in table 'HomeWorkParametersStudentPairings'
ALTER TABLE [dbo].[HomeWorkParametersStudentPairings]
ADD CONSTRAINT [FK__HomeWorkP__Param__286302EC]
    FOREIGN KEY ([ParametersID])
    REFERENCES [dbo].[HomeworkParameters]
        ([ParametersID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__HomeWorkP__Param__286302EC'
CREATE INDEX [IX_FK__HomeWorkP__Param__286302EC]
ON [dbo].[HomeWorkParametersStudentPairings]
    ([ParametersID]);
GO

-- Creating foreign key on [PairingID] in table 'PairingStudentPairings'
ALTER TABLE [dbo].[PairingStudentPairings]
ADD CONSTRAINT [FK_PairingStudentPairing_HomeWorkParametersStudentPairings]
    FOREIGN KEY ([PairingID])
    REFERENCES [dbo].[HomeWorkParametersStudentPairings]
        ([PairingID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PairingStudentPairing_HomeWorkParametersStudentPairings'
CREATE INDEX [IX_FK_PairingStudentPairing_HomeWorkParametersStudentPairings]
ON [dbo].[PairingStudentPairings]
    ([PairingID]);
GO

-- Creating foreign key on [StudentID] in table 'PairingStudentPairings'
ALTER TABLE [dbo].[PairingStudentPairings]
ADD CONSTRAINT [FK_PairingStudentPairing_StudentTable]
    FOREIGN KEY ([StudentID])
    REFERENCES [dbo].[StudentTables]
        ([StudentID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PairingStudentPairing_StudentTable'
CREATE INDEX [IX_FK_PairingStudentPairing_StudentTable]
ON [dbo].[PairingStudentPairings]
    ([StudentID]);
GO

-- Creating foreign key on [StudentID] in table 'TutorStudentRelationships'
ALTER TABLE [dbo].[TutorStudentRelationships]
ADD CONSTRAINT [FK_TutorStudentRelationship_StudentTable]
    FOREIGN KEY ([StudentID])
    REFERENCES [dbo].[StudentTables]
        ([StudentID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TutorStudentRelationship_StudentTable'
CREATE INDEX [IX_FK_TutorStudentRelationship_StudentTable]
ON [dbo].[TutorStudentRelationships]
    ([StudentID]);
GO

-- Creating foreign key on [SyllabusID] in table 'SubSyllabus'
ALTER TABLE [dbo].[SubSyllabus]
ADD CONSTRAINT [FK__SubSyllab__Sylla__2D27B809]
    FOREIGN KEY ([SyllabusID])
    REFERENCES [dbo].[Syllabus]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__SubSyllab__Sylla__2D27B809'
CREATE INDEX [IX_FK__SubSyllab__Sylla__2D27B809]
ON [dbo].[SubSyllabus]
    ([SyllabusID]);
GO

-- Creating foreign key on [SubSyllabusID] in table 'YouTubeSpecifics'
ALTER TABLE [dbo].[YouTubeSpecifics]
ADD CONSTRAINT [FK_YouTubeSpecific_SubSyllabus]
    FOREIGN KEY ([SubSyllabusID])
    REFERENCES [dbo].[SubSyllabus]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_YouTubeSpecific_SubSyllabus'
CREATE INDEX [IX_FK_YouTubeSpecific_SubSyllabus]
ON [dbo].[YouTubeSpecifics]
    ([SubSyllabusID]);
GO

-- Creating foreign key on [TutorID] in table 'TutorStudentRelationships'
ALTER TABLE [dbo].[TutorStudentRelationships]
ADD CONSTRAINT [FK_TutorStudentRelationship_TutorTable]
    FOREIGN KEY ([TutorID])
    REFERENCES [dbo].[TutorTables]
        ([TutorID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TutorStudentRelationship_TutorTable'
CREATE INDEX [IX_FK_TutorStudentRelationship_TutorTable]
ON [dbo].[TutorStudentRelationships]
    ([TutorID]);
GO

-- Creating foreign key on [GradeID] in table 'Syllabus'
ALTER TABLE [dbo].[Syllabus]
ADD CONSTRAINT [FK_Syllabus_GradeSyllabusPairing]
    FOREIGN KEY ([GradeID])
    REFERENCES [dbo].[GradeSyllabusPairings]
        ([GradeID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Syllabus_GradeSyllabusPairing'
CREATE INDEX [IX_FK_Syllabus_GradeSyllabusPairing]
ON [dbo].[Syllabus]
    ([GradeID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------