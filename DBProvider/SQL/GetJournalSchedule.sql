
IF(OBJECT_ID('GetJournalSchedule', 'P') IS NOT NULL)
BEGIN
	DROP PROCEDURE [dbo].[GetJournalSchedule]
END
GO

CREATE PROCEDURE [dbo].[GetJournalSchedule]
(
	@idClass int,
	@dateFrom Date,
	@dateTo Date
)
AS
BEGIN
	SELECT      Schedule.id,Schedule.Date, Project.Name , Class.NumberClass , Project.id , Class.id
			FROM            dbo.Schedule INNER JOIN
                         dbo.Project ON dbo.Schedule.idProject = dbo.Project.id INNER JOIN
                         dbo.Class ON dbo.Schedule.idClass = dbo.Class.id
						 where dbo.Class.id = @idClass and dbo.Schedule.Date >= @dateFrom and dbo.Schedule.Date <= @dateTo
						 --год день месяц
END