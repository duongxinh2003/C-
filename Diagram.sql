/*
   Monday, March 20, 20177:25:50 PM
   User: sa
   Server: DESKTOP-INAKV7S
   Database: Booking
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Passenger SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Passenger', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Passenger', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Passenger', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Bus SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Bus', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Bus', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Bus', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Booking ADD CONSTRAINT
	PK_Booking PRIMARY KEY CLUSTERED 
	(
	booking_Id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Booking ADD CONSTRAINT
	FK_Booking_Bus FOREIGN KEY
	(
	bus_Id
	) REFERENCES dbo.Bus
	(
	bus_Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Booking ADD CONSTRAINT
	FK_Booking_Passenger FOREIGN KEY
	(
	passenger_Id
	) REFERENCES dbo.Passenger
	(
	passenger_Id
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Booking SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Booking', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Booking', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Booking', 'Object', 'CONTROL') as Contr_Per 