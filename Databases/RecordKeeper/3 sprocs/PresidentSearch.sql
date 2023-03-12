create or alter procedure dbo.PresidentSearch(
	@PartyId int = 0,
	@BeginTermStart int = 0,
	@EndTermStart int = 0,
	@LastName varchar(100) = ''
)
as
begin
	declare @return int = 0

	select @PartyId = isnull(@PartyId,0), @LastName = isnull(@LastName,''),
	@BeginTermStart = nullif(@BeginTermStart,0), @EndTermStart = nullif(@EndTermStart,0)

	select p.PresidentId, p.PartyId, p.Num, p.FirstName, p.LastName, p.DateBorn, p.DateDied, p.TermStart, p.TermEnd,
		PresidentDesc = dbo.PresidentDesc(p.PresidentId),
		IsDeleteAllowed = dbo.IsPresidentDeleteAllowed(p.PresidentId)
	from President p
	where (@LastName = '' or p.LastName like '%' + @LastName + '%')
	and (@PartyId = 0 or p.PartyId = @PartyId)
	and (p.TermStart between isnull(@BeginTermStart,p.TermStart) and isnull(@EndTermStart,p.TermStart))
	order by p.num

	return @return
end
go
exec PresidentSearch @BeginTermStart = 1950, @EndTermStart = 0

exec PresidentSearch @BeginTermStart = 0, @EndTermStart = 1800

exec PresidentSearch @BeginTermStart = 1850, @EndTermStart = 1899

--exec PresidentSearch

--exec PresidentSearch @LastName = '' --no results

--exec PresidentSearch @LastName = null --no results
--select * from Party

--exec PresidentSearch @PartyId = 213

--exec PresidentSearch @LastName = 'm', @PartyId = 213

--exec PresidentSearch @LastName = 'm'--, @PartyId = null


