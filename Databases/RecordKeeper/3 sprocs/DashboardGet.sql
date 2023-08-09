create or alter proc dbo.DashboardGet(
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select DashboardType = 'president', DashBoardText = concat('Search ',count(*),' Presidents') from President p
	union 
	select DashboardType = 'olympics', DashBoardText = concat('Search ',count(*),' Olympic Games') from Olympics p

	return @return
end
go
exec DashboardGet