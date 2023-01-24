create or alter procedure dbo.PresidentGet(
	@PresidentId int = 0, 
	@LastName varchar(100) = '',
	@All bit = 0
)
as
begin
	select p.PresidentId, p.PartyId, p.Num, p.FirstName, p.LastName, p.DateBorn, p.DateDied, p.TermStart, p.TermEnd
	from President p
	where p.PresidentId = @PresidentId
	or @All = 1
	or p.LastName like '%' + @LastName + '%'
	order by p.num
end
go

exec PresidentGet

exec PresidentGet @LastName = '' --no results

exec PresidentGet @LastName = null --no results

exec PresidentGet @LastName = 'm'

exec PresidentGet @All = 1

exec PresidentGet @LastName = 'a', @All = null

declare @PresidentId int 

select top 1 @PresidentId = p.PresidentId from President p 

exec PresidentGet @PresidentId = @PresidentId