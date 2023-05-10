
IF(OBJECT_ID('GetHomeWork', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE [dbo].[GetHomeWork]
END
GO

CREATE PROCEDURE [dbo].[GetHomeWork]
(
    @idClass int
)
AS
BEGIN
	SELECT      HomeWork.id,
HomeWork.idProject,
HomeWork.idClass ,
Class.NumberClass ,
Project.Name ,
HomeWork.DateFrom ,
HomeWork.DateTo ,
HomeWork.Description
			FROM            dbo.HomeWork INNER JOIN
                         dbo.Project ON dbo.HomeWork.idProject = dbo.Project.id INNER JOIN
                         dbo.Class ON dbo.HomeWork.idClass = dbo.Class.id
						 where dbo.HomeWork.idClass = @idClass
						 order by DateFrom
END