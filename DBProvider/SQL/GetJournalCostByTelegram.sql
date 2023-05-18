IF(OBJECT_ID('GetJournalCostByTelegram', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE [dbo].[GetJournalCostByTelegram]
END
GO

CREATE PROCEDURE [dbo].[GetJournalCostByTelegram]
(
    @telegram varchar(max)
)
AS
BEGIN

DECLARE @d DATETIME
SET @d = GETDATE()
SELECT
       Journal.[Date]
	  ,Project.Name
      ,[Cost]
FROM[dbo].[Journal]
  left join dbo.Student 
	ON Student.id = dbo.Journal.idStudent
left join dbo.Project 
	ON Project.id = dbo.Journal.idProject
	where Student.Telegram = 'moskvin_ad' 
	and Journal.[Date] >= '2023-05-22'--DATEADD(dd, 0 - (@@DATEFIRST + 5 + DATEPART(dw, @d)) % 7, @d)

    and Journal.[Date] <= '2023-05-26'--DATEADD(dd, 4 - (@@DATEFIRST + 5 + DATEPART(dw, @d)) % 7, @d)
  order by Journal.[Date]

END
