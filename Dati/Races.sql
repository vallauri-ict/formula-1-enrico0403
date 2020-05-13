CREATE TABLE [dbo].[Races] (
    [id]         INT           IDENTITY (1, 1) NOT NULL,
    [name]       VARCHAR (128) NOT NULL,
    [extCircuit] INT NOT NULL,
    [date]       DATE          NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

SET IDENTITY_INSERT [dbo].[Races] ON;
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (1, N'FORMULA 1 ROLEX AUSTRALIAN GRAND PRIX 2019', 1, N'2019-03-17');
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (2, N'FORMULA 1 GULF AIR BAHRAIN GRAND PRIX 2019', 2, N'2019-03-31');
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (3, N'FORMULA 1 HEINEKEN CHINESE GRAND PRIX 2019', 3, N'2019-03-31');
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (4, N'FORMULA 1 SOCAR AZERBAIJAN GRAND PRIX 2019', 4, N'2019-04-28');
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (5, N'FORMULA 1 EMIRATES GRAN PREMIO DE ESPAÑA 2019', 5, N'2019-05-12');
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (6, N'FORMULA 1 GRAND PRIX DE MONACO 2019', 6, N'2019-05-12');
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (7, N'FORMULA 1 PIRELLI GRAND PRIX DU CANADA 2019', 7, N'2019-06-09');
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (8, N'FORMULA 1 PIRELLI GRAND PRIX DE FRANCE 2019', 8, N'2019-06-23');
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (9, N'FORMULA 1 MYWORLD GROSSER PREIS VON ÖSTERREICH 2019', 9, N'2019-06-30');
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (10, N'FORMULA 1 ROLEX BRITISH GRAND PRIX 2019', 10, N'2019-07-12');
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (11, N'FORMULA 1 MERCEDES-BENZ GROSSER PREIS VON DEUTSCHLAND 2019', 11, N'2019-07-28');
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (12, N'FORMULA 1 ROLEX MAGYAR NAGYDAJ 2019', 12, N'2019-08-04');
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (13, N'FORMULA 1 JOHNNIE WALKER BELGIAN GRAND PRIX 2019', 13, N'2019-09-01');
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (14, N'FORMULA 1 GRAN PREMIO HEINEKEN DI ITALIA 2019', 14, N'2019-11-08');
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (15, N'FORMULA 1 SINGAPORE AIRLINES SINGAPORE GRAND PRIX 2019', 15, N'2019-09-22');
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (16, N'FORMULA 1 VTB RUSSIAN GRAND PRIX 2019', 16, N'2019-09-29');
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (17, N'FORMULA 1 VTB RUSSIAN GRAND PRIX 2019', 17, N'2019-09-29');
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (18, N'FORMULA 1 GRAN PREMIO DE MEXICO 2019', 18, N'2019-10-25');
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (19, N'FORMULA 1 EMIRATES UNITED STATES GRAND PRIX 2019', 19, N'2019-10-25');
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (20, N'FORMULA 1 HEINEKEN GRANDE PREMIO DO BRASIL 2019', 20, N'2019-11-17');
INSERT INTO [dbo].[Races] ([id], [name], [extCircuit], [date]) VALUES (21, N'FORMULA 1 ETIHAD AIRWAYS ABU DHABI GRAND PRIX 2019', 21, N'2019-12-01');
SET IDENTITY_INSERT [dbo].[Races] OFF;