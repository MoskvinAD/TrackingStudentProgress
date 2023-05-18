IF(OBJECT_ID('GetScheduletByTelegram', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE [dbo].[GetScheduletByTelegram]
END
GO

CREATE PROCEDURE [dbo].[GetScheduletByTelegram]
(
    @telegram varchar(max)
)
AS
BEGIN

SELECT     Schedule.[Date], Project.[Name] 
FROM dbo.Schedule
	INNER JOIN dbo.Project 
		ON dbo.Schedule.idProject = dbo.Project.id 
			INNER JOIN dbo.Student 
				ON dbo.Schedule.idClass = dbo.Student.idClass
where Student.Telegram = @telegram
and dbo.Schedule.[Date] >= '2023-22-05 08:00:00.000' 
and dbo.Schedule.[Date] <= '2023-27-05 08:00:00.000'
order by Schedule.[Date]
  

  END
