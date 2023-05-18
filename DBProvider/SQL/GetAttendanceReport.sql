IF(OBJECT_ID('GetAttendanceReport', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE [dbo].[GetAttendanceReport]
END
GO

CREATE PROCEDURE [dbo].[GetAttendanceReport]
(
    @idClass int
)
AS
BEGIN

CREATE TABLE #DD_CodeTempResul (
id int,
resul  int 
)

INSERT INTO #DD_CodeTempResul(id,resul)
select 
Student.id, 0
from Student	
	where Student.idClass = @idClass  
	group by Student.id

CREATE TABLE #DD_CodeTemp (
id int,
resul  int 
)

INSERT INTO #DD_CodeTemp(id,resul)
select 
Student.id
,ISNULL(count(Journal.Cost ), 0) as resul
from Student
	inner join Journal
		on Journal.idStudent = Student.id
			inner join Project
				on Project.id = Journal.idProject
				where Student.idClass = @idClass and Journal.Cost = 'Б'
				group by Student.id
				order by Student.id

select 
(Student.LastName + ' ' + Student.MidleName + ' '+Student.FirstName) as FIO,
ISNULL(resul.resul + tmp.resul, 0) as resul
from #DD_CodeTempResul as resul
left join Student
on resul.id = Student.id
left join #DD_CodeTemp as tmp
on tmp.id = resul.id

drop table #DD_CodeTemp
drop table #DD_CodeTempResul
end