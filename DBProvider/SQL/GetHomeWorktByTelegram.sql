IF(OBJECT_ID('GetHomeWorktByTelegram', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE [dbo].[GetHomeWorktByTelegram]
END
GO

CREATE PROCEDURE [dbo].[GetHomeWorktByTelegram]
(
    @telegram varchar(max)
)
AS
BEGIN

DECLARE @d DATETIME
SET @d = GETDATE()
SELECT 
       HomeWork.DateTo,
	   Project.Name,
	   HomeWork.Description
  FROM [dbo].[Student]
  left join dbo.HomeWork 
	ON Student.idClass = HomeWork.idClass
		left join dbo.Project 
			ON Project.id = HomeWork.idProject
	where Student.Telegram = @telegram 
	and HomeWork.DateTo = cast(DATEADD(DAY,+1, GETDATE()) as varchar(max))
  order by Project.Name
  

  END
