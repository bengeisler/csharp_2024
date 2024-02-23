

create database FirmaDb

go

use FirmaDb


CREATE TABLE [dbo].[Abteilung] (
[AbteilungsNr] INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
[Bezeichnung]      VARCHAR (50) NOT NULL,
);

GO
PRINT N'Creating [dbo].[Mitarbeiter]...';

GO
CREATE TABLE [dbo].[Mitarbeiter] (
[PersonalNr] INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
[AbteilungsNr] INT           NOT NULL,
[Name]     VARCHAR (50) NOT NULL,
[Vorname]     VARCHAR (50) NOT NULL,
[Stellenbezeichnung]     VARCHAR (50) NOT NULL,
[Adresse]  VARCHAR (50) NOT NULL,
[PLZ]      VARCHAR (5)  NOT NULL,
[Ort]      VARCHAR (50) NOT NULL,
[Telefon]  VARCHAR (50) NOT NULL,
);

GO
PRINT N'Creating [dbo].[FK_Mitarbeiter_Abteilungen]...';

GO
ALTER TABLE [dbo].[Mitarbeiter] WITH NOCHECK
    ADD CONSTRAINT [FK_Mitarbeiter_Abteilungen] FOREIGN KEY([AbteilungsNr]) REFERENCES[dbo].[Abteilung]([AbteilungsNr]);

GO
PRINT N'Checking existing data against newly created constraints';

GO
ALTER TABLE [dbo].[Mitarbeiter] WITH CHECK CHECK CONSTRAINT [FK_Mitarbeiter_Abteilungen];

GO
PRINT N'Update complete.';

GO
BEGIN TRANSACTION
SET IDENTITY_INSERT [dbo].[Abteilung] ON
INSERT INTO[dbo].[Abteilung] ([AbteilungsNr], [Bezeichnung]) VALUES(7, N'Einkauf')
INSERT INTO[dbo].[Abteilung] ([AbteilungsNr], [Bezeichnung]) VALUES(8, N'Instandhaltung')
INSERT INTO[dbo].[Abteilung] ([AbteilungsNr], [Bezeichnung]) VALUES(9, N'Vertrieb')
INSERT INTO[dbo].[Abteilung] ([AbteilungsNr], [Bezeichnung]) VALUES(10, N'Management')
INSERT INTO[dbo].[Abteilung] ([AbteilungsNr], [Bezeichnung]) VALUES(11, N'Buchhaltung')
SET IDENTITY_INSERT[dbo].[Abteilung] OFF
SET IDENTITY_INSERT [dbo].[Mitarbeiter] ON
INSERT INTO[dbo].[Mitarbeiter] ([PersonalNr], [AbteilungsNr], [Name], [Vorname], [Stellenbezeichnung], [Adresse], [PLZ], [Ort], [Telefon]) VALUES(2, 7, N'Anders', N'Maria', N'Einkäuferin', N'Obere Str. 100', N'12209', N'Berlin', N'030-0074321')
INSERT INTO[dbo].[Mitarbeiter] ([PersonalNr], [AbteilungsNr], [Name], [Vorname], [Stellenbezeichnung], [Adresse], [PLZ], [Ort], [Telefon]) VALUES(3, 9, N'Moos', N'Hanna', N'Vertriebsinnendienst', N'Forsterstr. 57', N'68306', N'Mannheim', N'0621-08460')
INSERT INTO[dbo].[Mitarbeiter] ([PersonalNr], [AbteilungsNr], [Name], [Vorname], [Stellenbezeichnung], [Adresse], [PLZ], [Ort], [Telefon]) VALUES(4, 9, N'Ottlieb', N'Sven', N'Vertriebsaußendienst', N'Walserweg 21', N'52066', N'Aachen', N'0241-039123')
INSERT INTO[dbo].[Mitarbeiter] ([PersonalNr], [AbteilungsNr], [Name], [Vorname], [Stellenbezeichnung], [Adresse], [PLZ], [Ort], [Telefon]) VALUES(5, 10, N'Franken', N'Peter', N'Fuhrparkmanagement', N'Berliner Platz 43', N'80805', N'München', N'089-0877310')
INSERT INTO[dbo].[Mitarbeiter] ([PersonalNr], [AbteilungsNr], [Name], [Vorname], [Stellenbezeichnung], [Adresse], [PLZ], [Ort], [Telefon]) VALUES(6, 10, N'Cramer', N'Philip', N'Boss', N'Maubelstr. 90', N'14776', N'Brandenburg', N'0555-09876')
INSERT INTO[dbo].[Mitarbeiter] ([PersonalNr], [AbteilungsNr], [Name], [Vorname], [Stellenbezeichnung], [Adresse], [PLZ], [Ort], [Telefon]) VALUES(7, 8, N'Messner', N'Renate', N'Instandhalterin', N'Magazinweg 7', N'60528', N'Frankfurt a.M.', N'069-0245984')
INSERT INTO[dbo].[Mitarbeiter] ([PersonalNr], [AbteilungsNr], [Name], [Vorname], [Stellenbezeichnung], [Adresse], [PLZ], [Ort], [Telefon]) VALUES(8, 8, N'Feuer', N'Alexander', N'Instandhalter', N'Heerstr. 22', N'04179', N'Leipzig', N'0342-023176')
INSERT INTO[dbo].[Mitarbeiter] ([PersonalNr], [AbteilungsNr], [Name], [Vorname], [Stellenbezeichnung], [Adresse], [PLZ], [Ort], [Telefon]) VALUES(9, 11, N'Pfalzheim', N'Henriette', N'Sachbearbeiterin', N'Mehrheimerstr. 369', N'50739', N'Köln', N'0221-0644327')
INSERT INTO[dbo].[Mitarbeiter] ([PersonalNr], [AbteilungsNr], [Name], [Vorname], [Stellenbezeichnung], [Adresse], [PLZ], [Ort], [Telefon]) VALUES(10, 7, N'Kloss', N'Horst', N'Sachbearbeiter', N'Taucherstraße 10', N'01307', N'Cunewalde', N'0372-035188')
INSERT INTO[dbo].[Mitarbeiter] ([PersonalNr], [AbteilungsNr], [Name], [Vorname], [Stellenbezeichnung], [Adresse], [PLZ], [Ort], [Telefon]) VALUES(11, 8, N'Müller', N'Karin', N'Sachbearbeiterin', N'Luisenstr. 48', N'44087', N'Münster', N'0251-031259')
INSERT INTO[dbo].[Mitarbeiter] ([PersonalNr], [AbteilungsNr], [Name], [Vorname], [Stellenbezeichnung], [Adresse], [PLZ], [Ort], [Telefon]) VALUES(12, 10, N'Müller', N'Rita ', N'Sekretärin', N'Adenauerallee 900', N'70563', N'Stuttgart', N'0711-020361')
INSERT INTO[dbo].[Mitarbeiter] ([PersonalNr], [AbteilungsNr], [Name], [Vorname], [Stellenbezeichnung], [Adresse], [PLZ], [Ort], [Telefon]) VALUES(14, 9, N'Heinz', N'Franz', N'Vertriebsleiter', N'Testweg 2', N'12345', N'Örtchen', N' ')
SET IDENTITY_INSERT[dbo].[Mitarbeiter] OFF
COMMIT TRANSACTION

