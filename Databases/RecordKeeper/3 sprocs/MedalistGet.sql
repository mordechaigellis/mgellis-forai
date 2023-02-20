create or alter procedure dbo.MedalistGet(@MedalistId int = 0, @All bit = 0, @LastName varchar(50) = '')
as
begin

	select @LastName = nullif(@LastName, '')

	select m.MedalistId, m.OlympicYear, m.Season, m.OlympicLocation,m.Sport, m.SportSubcategory, m.Medal, m.LastName, m.FirstName, m.Country, m.YearBorn
	from Medalist m
	where m.MedalistId = @MedalistId
	or @All = 1
	or m.LastName like '%' + @LastName + '%'
	order by m.OlympicYear, m.Season, m.Sport, m.SportSubcategory, m.Country, m.LastName, m.FirstName
end
go


/*
exec MedalistGet

exec MedalistGet @All = 1

exec MedalistGet @LastName = '' --return no results
exec MedalistGet @LastName = 'a' 


declare @id int
select top 1 @id = m.MedalistId from Medalist m 
exec MedalistGet @MedalistId = @id
*/