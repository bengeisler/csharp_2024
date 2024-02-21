create database AutowerkstattDb

go

use AutowerkstattDb


CREATE TABLE [dbo].[Fahrzeug] (
    [Nr]          INT           IDENTITY (1000, 1) NOT NULL,
    [Kennzeichen] VARCHAR (50)  NOT NULL,
    [Marke]       VARCHAR (50)  NOT NULL,
    [Modell]      VARCHAR (50)  NOT NULL,
    [Halter]      VARCHAR (100) NOT NULL,
    [Ort]         VARCHAR (50)  NOT NULL,
    CONSTRAINT [PK_Fahrzeug] PRIMARY KEY CLUSTERED ([Nr] ASC)
);


GO
PRINT N'Creating [dbo].[Reparatur]...';


GO
CREATE TABLE [dbo].[Reparatur] (
    [Nr]           INT             IDENTITY (1, 1) NOT NULL,
    [Datum]        SMALLDATETIME   NOT NULL,
    [Beschreibung] VARCHAR (100)   NOT NULL,
    [Kosten]       DECIMAL (10, 2) NOT NULL,
    [FahrzeugNr]   INT             NOT NULL,
    CONSTRAINT [PK_Reparaturen] PRIMARY KEY CLUSTERED ([Nr] ASC)
);


GO
PRINT N'Creating [dbo].[FK_Reparaturen_Fahrzeug]...';


GO
ALTER TABLE [dbo].[Reparatur] WITH NOCHECK
    ADD CONSTRAINT [FK_Reparaturen_Fahrzeug] FOREIGN KEY ([FahrzeugNr]) REFERENCES [dbo].[Fahrzeug] ([Nr]);


GO
PRINT N'Checking existing data against newly created constraints';


GO



GO
ALTER TABLE [dbo].[Reparatur] WITH CHECK CHECK CONSTRAINT [FK_Reparaturen_Fahrzeug];


GO
PRINT N'Update complete.';


GO

SET NUMERIC_ROUNDABORT OFF
GO
SET XACT_ABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, ARITHABORT, QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
/*Pointer used for text / image updates. This might not be needed, but is declared here just in case*/
DECLARE @pv binary(16)
BEGIN TRANSACTION
ALTER TABLE [dbo].[Reparatur] DROP CONSTRAINT [FK_Reparaturen_Fahrzeug]
SET IDENTITY_INSERT [dbo].[Fahrzeug] ON
INSERT INTO [dbo].[Fahrzeug] ([Nr], [Kennzeichen], [Marke], [Modell], [Halter], [Ort]) VALUES (1000, 'SAD-XY 10', 'VW', 'Golf', 'Huber, Hans', 'Schwandorf')
INSERT INTO [dbo].[Fahrzeug] ([Nr], [Kennzeichen], [Marke], [Modell], [Halter], [Ort]) VALUES (1002, 'SAD-BP 99', 'Audi', 'A4', 'Meier, Sepp', 'Schwandorf')
INSERT INTO [dbo].[Fahrzeug] ([Nr], [Kennzeichen], [Marke], [Modell], [Halter], [Ort]) VALUES (1003, 'AM-EN 1', 'BMW', '750', 'Dr. Großkopf', 'Amberg')
SET IDENTITY_INSERT [dbo].[Fahrzeug] OFF
SET IDENTITY_INSERT [dbo].[Reparatur] ON
INSERT INTO [dbo].[Reparatur] ([Nr], [Datum], [Beschreibung], [Kosten], [FahrzeugNr]) VALUES (1, '20110228 00:00:00.000', 'Kotflügel neu lackiert', 350.00, 1002)
INSERT INTO [dbo].[Reparatur] ([Nr], [Datum], [Beschreibung], [Kosten], [FahrzeugNr]) VALUES (2, '20110301 00:00:00.000', 'Ölwechsel', 70.00, 1003)
INSERT INTO [dbo].[Reparatur] ([Nr], [Datum], [Beschreibung], [Kosten], [FahrzeugNr]) VALUES (3, '20150226 06:17:00.000', 'abc', 11.00, 1000)
SET IDENTITY_INSERT [dbo].[Reparatur] OFF
ALTER TABLE [dbo].[Reparatur]
    ADD CONSTRAINT [FK_Reparaturen_Fahrzeug] FOREIGN KEY ([FahrzeugNr]) REFERENCES [dbo].[Fahrzeug] ([Nr])
COMMIT TRANSACTION

