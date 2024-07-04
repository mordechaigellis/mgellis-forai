create or alter procedure dbo.MedalGet(
	@MedalId int = 0,
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All,0), @MedalId = isnull(@MedalId,0)

	select m.MedalId, m.MedalName
	from Medal m
	where MedalId = @MedalId
	or @All = 1
	union select 0,' ' where isnull(@IncludeBlank,0) = 1
	order by medalId 

	return @return
end
go
