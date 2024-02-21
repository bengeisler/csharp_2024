create database BestellungDb

go

use BestellungDb


CREATE TABLE [dbo].[Bestellung] (
    [BestellNr] INT            IDENTITY (1, 1) NOT NULL,
    [KundenNr]  INT            NOT NULL,
    [Text]      VARCHAR (1024) NOT NULL,
    [Preis]     MONEY          NOT NULL,
    [Datum]     DATETIME       NOT NULL,
    CONSTRAINT [PK_Bestellungen] PRIMARY KEY CLUSTERED ([BestellNr] ASC)
);


GO
PRINT N'Creating [dbo].[Kunde]...';


GO
CREATE TABLE [dbo].[Kunde] (
    [KundenNr] INT          IDENTITY (1, 1) NOT NULL,
    [Name]     VARCHAR (50) NOT NULL,
    [Adresse]  VARCHAR (50) NOT NULL,
    [PLZ]      VARCHAR (5)  NOT NULL,
    [Ort]      VARCHAR (50) NOT NULL,
    [Telefon]  VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Kunden] PRIMARY KEY CLUSTERED ([KundenNr] ASC)
);


GO
PRINT N'Creating [dbo].[FK_Bestellungen_Kunden]...';


GO
ALTER TABLE [dbo].[Bestellung] WITH NOCHECK
    ADD CONSTRAINT [FK_Bestellungen_Kunden] FOREIGN KEY ([KundenNr]) REFERENCES [dbo].[Kunde] ([KundenNr]);


GO
PRINT N'Checking existing data against newly created constraints';




GO
ALTER TABLE [dbo].[Bestellung] WITH CHECK CHECK CONSTRAINT [FK_Bestellungen_Kunden];


GO
PRINT N'Update complete.';


GO

/*
This script was created by Visual Studio on 01.07.2015 at 22:13.
Run this script on (localDb)\ProjectsV12.BestellungDb (PCSarah\Piehler) to make it the same as (localdb)\MyDb.BestellungDb (PCSarah\Piehler).
This script performs its actions in the following order:
1. Disable foreign-key constraints.
2. Perform DELETE commands. 
3. Perform UPDATE commands.
4. Perform INSERT commands.
5. Re-enable foreign-key constraints.
Please back up your target database before running this script.
*/
SET NUMERIC_ROUNDABORT OFF
GO
SET XACT_ABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, ARITHABORT, QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
/*Pointer used for text / image updates. This might not be needed, but is declared here just in case*/
DECLARE @pv binary(16)
BEGIN TRANSACTION
ALTER TABLE [dbo].[Bestellung] DROP CONSTRAINT [FK_Bestellungen_Kunden]
SET IDENTITY_INSERT [dbo].[Kunde] ON
INSERT INTO [dbo].[Kunde] ([KundenNr], [Name], [Adresse], [PLZ], [Ort], [Telefon]) VALUES (2, N'Maria Anders', N'Obere Str. 100', N'12209', N'Berlin', N'030-0074321')
INSERT INTO [dbo].[Kunde] ([KundenNr], [Name], [Adresse], [PLZ], [Ort], [Telefon]) VALUES (3, N'Hanna Moos', N'Forsterstr. 57', N'68306', N'Mannheim', N'0621-08460')
INSERT INTO [dbo].[Kunde] ([KundenNr], [Name], [Adresse], [PLZ], [Ort], [Telefon]) VALUES (4, N'Sven Ottlieb', N'Walserweg 21', N'52066', N'Aachen', N'0241-039123')
INSERT INTO [dbo].[Kunde] ([KundenNr], [Name], [Adresse], [PLZ], [Ort], [Telefon]) VALUES (5, N'Peter Franken', N'Berliner Platz 43', N'80805', N'München', N'089-0877310')
INSERT INTO [dbo].[Kunde] ([KundenNr], [Name], [Adresse], [PLZ], [Ort], [Telefon]) VALUES (6, N'Philip Cramer', N'Maubelstr. 90', N'14776', N'Brandenburg', N'0555-09876')
INSERT INTO [dbo].[Kunde] ([KundenNr], [Name], [Adresse], [PLZ], [Ort], [Telefon]) VALUES (7, N'Renate Messner', N'Magazinweg 7', N'60528', N'Frankfurt a.M.', N'069-0245984')
INSERT INTO [dbo].[Kunde] ([KundenNr], [Name], [Adresse], [PLZ], [Ort], [Telefon]) VALUES (8, N'Alexander Feuer', N'Heerstr. 22', N'04179', N'Leipzig', N'0342-023176')
INSERT INTO [dbo].[Kunde] ([KundenNr], [Name], [Adresse], [PLZ], [Ort], [Telefon]) VALUES (9, N'Henriette Pfalzheim', N'Mehrheimerstr. 369', N'50739', N'Köln', N'0221-0644327')
INSERT INTO [dbo].[Kunde] ([KundenNr], [Name], [Adresse], [PLZ], [Ort], [Telefon]) VALUES (10, N'Horst Kloss', N'Taucherstraße 10', N'01307', N'Cunewalde', N'0372-035188')
INSERT INTO [dbo].[Kunde] ([KundenNr], [Name], [Adresse], [PLZ], [Ort], [Telefon]) VALUES (11, N'Karin Josephs', N'Luisenstr. 48', N'44087', N'Münster', N'0251-031259')
INSERT INTO [dbo].[Kunde] ([KundenNr], [Name], [Adresse], [PLZ], [Ort], [Telefon]) VALUES (12, N'Rita Müller', N'Adenauerallee 900', N'70563', N'Stuttgart', N'0711-020361')
INSERT INTO [dbo].[Kunde] ([KundenNr], [Name], [Adresse], [PLZ], [Ort], [Telefon]) VALUES (14, N'Franz, Heinz', N'Testweg 2', N'12345', N'Örtchen', N' ')
SET IDENTITY_INSERT [dbo].[Kunde] OFF
SET IDENTITY_INSERT [dbo].[Bestellung] ON
INSERT INTO [dbo].[Bestellung] ([BestellNr], [KundenNr], [Text], [Preis], [Datum]) VALUES (7, 3, N'HP PC D760, i5 ', 500.0000, '20150618 00:00:00.000')
INSERT INTO [dbo].[Bestellung] ([BestellNr], [KundenNr], [Text], [Preis], [Datum]) VALUES (8, 2, N'TFT Asus X27', 200.0000, '20150623 00:00:00.000')
INSERT INTO [dbo].[Bestellung] ([BestellNr], [KundenNr], [Text], [Preis], [Datum]) VALUES (9, 3, N'PC i7', 800.0000, '20150315 00:00:00.000')
INSERT INTO [dbo].[Bestellung] ([BestellNr], [KundenNr], [Text], [Preis], [Datum]) VALUES (10, 6, N'HP Probook G2 450', 600.0000, '20150312 00:00:00.000')
SET IDENTITY_INSERT [dbo].[Bestellung] OFF
ALTER TABLE [dbo].[Bestellung]
    ADD CONSTRAINT [FK_Bestellungen_Kunden] FOREIGN KEY ([KundenNr]) REFERENCES [dbo].[Kunde] ([KundenNr])
COMMIT TRANSACTION
