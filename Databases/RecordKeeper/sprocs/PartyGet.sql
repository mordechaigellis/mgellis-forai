create or alter procedure dbo.PartyGet(@PartyId int = 0, @All bit = 0)
as
begin
	select p.PartyId, p.PartyName, p.YearStart, p.PartyColor
	from Party p
	where p.PartyId = @PartyId
	or @All = 1
	order by p.PartyName
end
go
exec PartyGet

exec PartyGet @All = 1

declare @PartyId int 

select top 1 @PartyId = p.PartyId from Party p 

exec PartyGet @PartyId = @PartyId