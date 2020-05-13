ALTER TABLE [dbo].[Drivers]  WITH CHECK ADD  CONSTRAINT [FK_Drivers_Countries] FOREIGN KEY([extCountry])
REFERENCES [dbo].[Countries] ([countryCode])
ON UPDATE CASCADE;

ALTER TABLE [dbo].[Teams]  WITH CHECK ADD  CONSTRAINT [FK_Teams_Countries] FOREIGN KEY([extCountry])
REFERENCES [dbo].[Countries] ([countryCode])
ON UPDATE CASCADE;

ALTER TABLE [dbo].[Teams]  WITH CHECK ADD  CONSTRAINT [FK_Teams_Drivers_First] FOREIGN KEY([extFirstDriver])
REFERENCES [dbo].[Drivers] ([id])

ALTER TABLE [dbo].[Teams]  WITH CHECK ADD  CONSTRAINT [FK_Teams_Drivers_Second] FOREIGN KEY([extSecondDriver])
REFERENCES [dbo].[Drivers] ([id])

ALTER TABLE [dbo].[Circuits]  WITH CHECK ADD  CONSTRAINT [FK_Circuits_Countries] FOREIGN KEY([extCountry])
REFERENCES [dbo].[Countries] ([countryCode])
ON UPDATE CASCADE;

ALTER TABLE [dbo].[Races]  WITH CHECK ADD  CONSTRAINT [FK_Races_Circuits] FOREIGN KEY([extCircuit])
REFERENCES [dbo].[Circuits] ([id])
ON UPDATE CASCADE;

ALTER TABLE [dbo].[RacesScores]  WITH CHECK ADD  CONSTRAINT [FK_RacesScores_Drivers] FOREIGN KEY([extDriver])
REFERENCES [dbo].[Drivers] ([id])
ON UPDATE CASCADE;

ALTER TABLE [dbo].[RacesScores]  WITH CHECK ADD  CONSTRAINT [FK_RacesScores_Scores] FOREIGN KEY([extPos])
REFERENCES [dbo].[Scores] ([pos])
ON UPDATE CASCADE;

ALTER TABLE [dbo].[RacesScores]  WITH CHECK ADD  CONSTRAINT [FK_RacesScores_Races] FOREIGN KEY([extRace])
REFERENCES [dbo].[Races] ([id])
ON UPDATE NO ACTION;