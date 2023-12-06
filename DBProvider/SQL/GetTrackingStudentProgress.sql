IF(OBJECT_ID('GetTrackingStudentProgress', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE [dbo].[GetTrackingStudentProgress]
END
GO

CREATE PROCEDURE [dbo].[GetTrackingStudentProgress]
(
    @idClass int
)
AS
BEGIN


CREATE TABLE #DD_CodeTempResul (
id int,
resul1  varchar(4) ,
idProject1 int,
resul2  varchar(4) ,
idProject2 int,
resul3  varchar(4) ,
idProject3 int,
resul4  varchar(4) ,
idProject4 int,
resul5  varchar(4) ,
idProject5 int,
resul6  varchar(4) ,
idProject6 int,
resul7  varchar(4) ,
idProject7 int,

)

CREATE TABLE #DD_CodeTempResulProject1 (
id int,
summa  int,
counts int
)

INSERT INTO #DD_CodeTempResulProject1(id,summa,counts)
select 
Student.id
,sum(cast(Journal.Cost as int))
,ISNULL(count(Journal.Cost ), 0)
from Student
	inner join Journal
		on Journal.idStudent = Student.id
			inner join Project
				on Project.id = Journal.idProject
				where Student.idClass = @idClass and Journal.idProject = 1 and Journal.Cost != 'Б' and Journal.Cost != 'Nan'
				group by Student.id
				order by Student.id



CREATE TABLE #DD_CodeTempResulProject2 (
id int,
summa  int,
counts int
)

INSERT INTO #DD_CodeTempResulProject2(id,summa,counts)
select 
Student.id
,sum(cast(Journal.Cost as int))
,ISNULL(count(Journal.Cost ), 0)
from Student
	inner join Journal
		on Journal.idStudent = Student.id
			inner join Project
				on Project.id = Journal.idProject
				where Student.idClass = @idClass and Journal.idProject = 2 and Journal.Cost != 'Б' and Journal.Cost != 'Nan'
				group by Student.id
				order by Student.id

CREATE TABLE #DD_CodeTempResulProject3 (
id int,
summa  int,
counts int
)

INSERT INTO #DD_CodeTempResulProject3(id,summa,counts)
select 
Student.id
,sum(cast(Journal.Cost as int))
,ISNULL(count(Journal.Cost ), 0)
from Student
	inner join Journal
		on Journal.idStudent = Student.id
			inner join Project
				on Project.id = Journal.idProject
				where Student.idClass = @idClass and Journal.idProject = 3 and Journal.Cost != 'Б' and Journal.Cost != 'Nan'
				group by Student.id
				order by Student.id

CREATE TABLE #DD_CodeTempResulProject4 (
id int,
summa  int,
counts int
)

INSERT INTO #DD_CodeTempResulProject4(id,summa,counts)
select 
Student.id
,sum(cast(Journal.Cost as int))
,ISNULL(count(Journal.Cost ), 0)
from Student
	inner join Journal
		on Journal.idStudent = Student.id
			inner join Project
				on Project.id = Journal.idProject
				where Student.idClass = @idClass and Journal.idProject = 4 and Journal.Cost != 'Б' and Journal.Cost != 'Nan'
				group by Student.id
				order by Student.id

CREATE TABLE #DD_CodeTempResulProject5 (
id int,
summa  int,
counts int
)

INSERT INTO #DD_CodeTempResulProject5(id,summa,counts)
select 
Student.id
,sum(cast(Journal.Cost as int))
,ISNULL(count(Journal.Cost ), 0)
from Student
	inner join Journal
		on Journal.idStudent = Student.id
			inner join Project
				on Project.id = Journal.idProject
				where Student.idClass = @idClass and Journal.idProject = 5 and Journal.Cost != 'Б' and Journal.Cost != 'Nan'
				group by Student.id
				order by Student.id

CREATE TABLE #DD_CodeTempResulProject6 (
id int,
summa  int,
counts int
)

INSERT INTO #DD_CodeTempResulProject6(id,summa,counts)
select 
Student.id
,sum(cast(Journal.Cost as int))
,ISNULL(count(Journal.Cost ), 0)
from Student
	inner join Journal
		on Journal.idStudent = Student.id
			inner join Project
				on Project.id = Journal.idProject
				where Student.idClass = @idClass and Journal.idProject = 6 and Journal.Cost != 'Б' and Journal.Cost != 'Nan'
				group by Student.id
				order by Student.id

CREATE TABLE #DD_CodeTempResulProject7 (
id int,
summa  int,
counts int
)

INSERT INTO #DD_CodeTempResulProject7(id,summa,counts)
select 
Student.id
,sum(cast(Journal.Cost as int))
,ISNULL(count(Journal.Cost ), 0)
from Student
	inner join Journal
		on Journal.idStudent = Student.id
			inner join Project
				on Project.id = Journal.idProject
				where Student.idClass = @idClass and Journal.idProject = 7 and Journal.Cost != 'Б' and Journal.Cost != 'Nan'
				group by Student.id
				order by Student.id

INSERT INTO #DD_CodeTempResul(id,resul1,idProject1,resul2,idProject2,resul3,idProject3,resul4,idProject4,resul5,idProject5,resul6,idProject6,resul7,idProject7)
select tt.id, (tt.summa / tt.counts) as resul1 ,1 ,
(tt2.summa / tt2.counts) as resul2 ,2 ,
(tt3.summa / tt3.counts) as resul3 ,3 ,
(tt4.summa / tt4.counts) as resul4 ,4 ,
(tt5.summa / tt5.counts) as resul5 ,5 ,
(tt6.summa / tt6.counts) as resul6 ,6,
(tt7.summa / tt7.counts) as resul7 ,7 
from  #DD_CodeTempResulProject1 as tt
join  #DD_CodeTempResulProject2 as tt2
on tt.id = tt2.id 
join  #DD_CodeTempResulProject3 as tt3
on tt.id = tt3.id 
join  #DD_CodeTempResulProject4 as tt4
on tt.id = tt4.id 
join  #DD_CodeTempResulProject5 as tt5
on tt.id = tt5.id 
join  #DD_CodeTempResulProject6 as tt6
on tt.id = tt6.id 
join  #DD_CodeTempResulProject7 as tt7
on tt.id = tt7.id 

select 
(Student.LastName + ' ' + Student.MidleName + ' '+Student.FirstName) as FIO,
Project1.Name,
resul.resul1,
Project2.Name,
resul.resul2,
Project3.Name,
resul.resul3,
Project4.Name,
resul.resul4,
Project5.Name,
resul.resul5,
Project6.Name,
resul.resul6,
Project7.Name,
resul.resul7
from #DD_CodeTempResul as resul
left join Student
on resul.id = Student.id
left join Project as Project1
on resul.idProject1 = Project1.id
left join Project as Project2
on resul.idProject2 = Project2.id
left join Project as Project3
on resul.idProject3 = Project3.id
left join Project as Project4
on resul.idProject4 = Project4.id
left join Project as Project5
on resul.idProject5 = Project5.id
left join Project as Project6
on resul.idProject6 = Project6.id
left join Project as Project7
on resul.idProject7 = Project7.id

				
drop table #DD_CodeTempResulProject1
drop table #DD_CodeTempResulProject2
drop table #DD_CodeTempResulProject3
drop table #DD_CodeTempResulProject4
drop table #DD_CodeTempResulProject5
drop table #DD_CodeTempResulProject6
drop table #DD_CodeTempResulProject7

drop table #DD_CodeTempResul

END