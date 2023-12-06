IF(OBJECT_ID('GetAverageScoreForByTelegram', 'P') IS NOT NULL)
BEGIN
    DROP PROCEDURE [dbo].[GetAverageScoreForByTelegram]
END
GO

CREATE PROCEDURE [dbo].[GetAverageScoreForByTelegram]
(
    @telegram varchar(max)

)
AS
BEGIN
	CREATE TABLE #DD_CodeTempResulProject (
name varchar(max),
summa  int,
counts int
)
  INSERT INTO #DD_CodeTempResulProject(name,summa,counts)
  SELECT pr.Name, sum(cast(jj.Cost as int)),ISNULL(count(jj.Cost ), 0)
  FROM [TrackingStudentProgressBD].[dbo].[Journal] as jj
  left join Project as pr
  on pr.id = jj.idProject
  left join Student as std
  on std.id = jj.idStudent
  where jj.Date >= '2022-09-01' and jj.Date <= '2023-06-01' and
  std.Telegram = @telegram and jj.Cost != 'Б'
  group by pr.Name

  select tt.name, (tt.summa / tt.counts) as resul
  from #DD_CodeTempResulProject as tt

drop table #DD_CodeTempResulProject
END