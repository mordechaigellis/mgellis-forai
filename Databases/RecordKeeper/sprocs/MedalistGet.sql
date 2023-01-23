create or alter procedure dbo.MedalistGet(@MedalistId int = 0, @All bit = 0)
as
begin
	select m.MedalistId, m.OlympicYear, m.Season, m.OlympicLocation,m.Sport, m.SportSubcategory, m.Medal, m.LastName, m.FirstName, m.Country, m.YearBorn
	from Medalist m
	where m.MedalistId = @MedalistId
	or @All = 1
	order by m.OlympicYear, m.Season, m.Sport, m.SportSubcategory, m.Country, m.LastName, m.FirstName
end
go
/*
exec MedalistGet

exec MedalistGet @All = 1

declare @id int
select top 1 @id = m.MedalistId from Medalist m 
exec MedalistGet @MedalistId = @id
*/