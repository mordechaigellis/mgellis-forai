create or alter procedure dbo.PresidentGet(@PresidentId int = 0, @All bit = 0)
as
begin
	select p.PresidentId, p.PartyId, p.Num, p.FirstName, p.LastName, p.DateBorn, p.DateDied, p.TermStart, p.TermEnd
	from President p
	where p.PresidentId = @PresidentId
	or @All = 1
	order by p.num
end
go
exec PresidentGet

exec PresidentGet @All = 1

declare @PresidentId int 

select top 1 @PresidentId = p.PresidentId from President p 

exec PresidentGet @PresidentId = @PresidentId