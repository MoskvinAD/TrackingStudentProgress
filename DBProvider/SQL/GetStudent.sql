IF(OBJECT_ID('GetStudent', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE [dbo].[GetStudent]
END
GO

CREATE PROCEDURE [dbo].[GetStudent]
(
    @idClass int
)
AS
BEGIN
	

SELECT Student.[id]
      ,Student.[LastName]
      ,Student.[FirstName]
      ,Student.[MidleName]
      ,Student.[DateCreate]
      ,Student.[Email]
      ,Student.[Telegram]
      ,Student.[idClass]
	  ,Class.NumberClass
	  ,ParentM.Fio
	  ,ParentM.Emal
	  ,ParentM.Telegram
	  ,ParentM.id
	  ,ParentF.Fio
	  ,ParentF.Emal
	  ,ParentF.Telegram
	  ,ParentF.id
  FROM[Student] as Student
  left join dbo.Class 
	ON Student.idClass = dbo.Class.id
  left join dbo.Parent as ParentM
	ON Student.idParentM = ParentM.id 
  left join dbo.Parent as ParentF
	ON Student.idParentF = ParentF.id
  where dbo.Class.id = @idClass
  order by Student.LastName

END