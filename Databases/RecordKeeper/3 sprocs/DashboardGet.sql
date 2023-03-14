create or alter proc dbo.DashboardGet(
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select DashboardType = 'president', DashBoardText = concat('Click here to search from among ',count(*),' Presidents') from President p
	union 
	select DashboardType = 'olympics', DashBoardText = concat('Click here to search from among ',count(*),' Olympic Games') from Olympics p

	return @return
end
go
exec DashboardGet