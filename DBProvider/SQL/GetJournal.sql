IF(OBJECT_ID('GetJournal', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE [dbo].[GetJournal]
END
GO

CREATE PROCEDURE [dbo].[GetJournal]
(
    @idClass int,
	@idProject int,
	@date date
)
AS
BEGIN
	

SELECT Journal.[id]
      ,Journal.[Date]
      ,[idProject]
	  ,Project.Name
	  ,Student.FirstName
	  ,Student.MidleName
	  ,Student.LastName
      ,[idStudent]
      ,[Cost]
  FROM [dbo].[Journal]
  left join dbo.Student 
	ON Student.id = dbo.Journal.idStudent
left join dbo.Project 
	ON Project.id = dbo.Journal.idProject
	where Journal.idProject = @idProject
	and Journal.[Date] = @date
	and Student.idClass = @idClass
  order by Student.LastName

END