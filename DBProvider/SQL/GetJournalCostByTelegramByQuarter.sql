IF(OBJECT_ID('GetJournalCostByTelegramByQuarter', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE [dbo].[GetJournalCostByTelegramByQuarter]
END
GO

CREATE PROCEDURE [dbo].[GetJournalCostByTelegramByQuarter]
(
    @telegram varchar(max),
	@period int

)
AS
BEGIN

if(@period = 1)
begin
	SELECT pr.Name, STRING_AGG(jj.Cost,',')
  FROM [TrackingStudentProgressBD].[dbo].[Journal] as jj
  left join Project as pr
  on pr.id = jj.idProject
  left join Student as std
  on std.id = jj.idStudent
  where jj.Date >= '2022-09-01' and jj.Date <= '2022-10-01' and
  std.Telegram = @telegram
  group by pr.Name
end
else if(@period = 2)
begin
	SELECT pr.Name, STRING_AGG(jj.Cost,',')
  FROM [TrackingStudentProgressBD].[dbo].[Journal] as jj
  left join Project as pr
  on pr.id = jj.idProject
  left join Student as std
  on std.id = jj.idStudent
  where jj.Date >= '2022-10-01' and jj.Date <= '2022-12-31' and
  std.Telegram = @telegram
  group by pr.Name
end
else if(@period = 3)
begin
	SELECT pr.Name, STRING_AGG(jj.Cost,',')
  FROM [TrackingStudentProgressBD].[dbo].[Journal] as jj
  left join Project as pr
  on pr.id = jj.idProject
  left join Student as std
  on std.id = jj.idStudent
  where jj.Date >= '2022-12-31' and jj.Date <= '2023-03-01' and
  std.Telegram = @telegram
  group by pr.Name
end
else if(@period = 4)
begin
	SELECT pr.Name, STRING_AGG(jj.Cost,',')
  FROM [TrackingStudentProgressBD].[dbo].[Journal] as jj
  left join Project as pr
  on pr.id = jj.idProject
  left join Student as std
  on std.id = jj.idStudent
  where jj.Date >= '2023-03-01' and jj.Date <= '2023-06-01' and
  std.Telegram = @telegram--
  group by pr.Name
end
END



