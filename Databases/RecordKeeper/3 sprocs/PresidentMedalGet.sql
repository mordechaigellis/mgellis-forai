create or alter procedure dbo.PresidentMedalGet(
	@PresidentMedalId int = 0,
	@PresidentId int = 0, 
	@All bit = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All,0), @PresidentMedalId = isnull(@PresidentMedalId,0), @PresidentId = isnull(@PresidentId,0)

	select p.PresidentMedalId, p.PresidentId, p.MedalId
	from PresidentMedal p
	where p.PresidentMedalId = @PresidentMedalId
	or @All = 1
	or p.PresidentId = @PresidentId
	
	return @return
end
go
/*
exec PresidentMedalGet @All = 1

exec PresidentMedalGet @PresidentId = 2360
*/