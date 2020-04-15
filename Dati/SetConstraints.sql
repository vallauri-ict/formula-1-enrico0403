ALTER TABLE [dbo].[Drivers]  WITH CHECK ADD  CONSTRAINT [FK_Drivers_Countries] FOREIGN KEY([extCountry])
REFERENCES [dbo].[Countries] ([countryCode])
ON UPDATE CASCADE;

ALTER TABLE [dbo].[Teams]  WITH CHECK ADD  CONSTRAINT [FK_Teams_Countries] FOREIGN KEY([extCountry])
REFERENCES [dbo].[Countries] ([countryCode])
ON UPDATE CASCADE;

ALTER TABLE [dbo].[Teams]  WITH CHECK ADD  CONSTRAINT [FK_Teams_Drivers_First] FOREIGN KEY([extFirstDriver])
REFERENCES [dbo].[Drivers] ([id]);

ALTER TABLE [dbo].[Teams]  WITH CHECK ADD  CONSTRAINT [FK_Teams_Drivers_Second] FOREIGN KEY([extSecondDriver])
REFERENCES [dbo].[Drivers] ([id]);

ALTER TABLE [dbo].[Races_Scores]  WITH CHECK ADD  CONSTRAINT [FK_Races_Scores_Drivers] FOREIGN KEY([driver])
REFERENCES [dbo].[Drivers] ([id]);

ALTER TABLE [dbo].[Races_Scores]  WITH CHECK ADD  CONSTRAINT [FK_Races_Scores_Races] FOREIGN KEY([idRace])
REFERENCES [dbo].[Races] ([id]);

ALTER TABLE [dbo].[Races_Scores]  WITH CHECK ADD  CONSTRAINT [FK_Races_Scores_Scores] FOREIGN KEY([pos])
REFERENCES [dbo].[Scores] ([pos]);

ALTER TABLE [dbo].[Races]  WITH CHECK ADD  CONSTRAINT [FK_Races_Circuits] FOREIGN KEY([idCircuit])
REFERENCES [dbo].[Circuits] ([id]);

