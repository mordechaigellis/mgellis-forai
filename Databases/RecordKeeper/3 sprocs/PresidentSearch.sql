create or alter procedure dbo.PresidentSearch(
	@PartyId int = 0,
	@BeginTermStart int = 0,
	@EndTermStart int = 0,
	@LastName varchar(100) = '',
	@Message varchar(1000) = '' output
)
as
begin
	declare @return int = 0, @count int = 0
	declare @t table(presidentid int)

	select @PartyId = isnull(@PartyId,0), @LastName = isnull(@LastName,''),
	@BeginTermStart = nullif(@BeginTermStart,0), @EndTermStart = nullif(@EndTermStart,0)

	insert @t(presidentid)
	select p.PresidentId
	from President p
	join party y
	on y.PartyId = p.PartyId
	where (@LastName = '' or p.LastName like '%' + @LastName + '%')
	and (@PartyId = 0 or p.PartyId = @PartyId)
	and (p.TermStart between isnull(@BeginTermStart,p.TermStart) and isnull(@EndTermStart,p.TermStart))
	
	select @count = count(*) 
	from @t 

	if @count > 10
	begin
		select @Return = 1,@Message = concat('Search would return ', @count,' rows. You are only allowed to return 10 rows')
		goto finished
	end

	select p.PresidentId, p.PartyId, p.Num, y.PartyName, p.FirstName, p.LastName, p.DateBorn, p.DateDied,
	NumExecutiveOrders = count(e.ExecutiveOrderId)
	from @t t
	join President p
	on t.presidentid = p.PresidentId
	join party y
	on y.PartyId = p.PartyId
	left join ExecutiveOrder e
	on e.PresidentId = p.PresidentId
	group by p.PresidentId, p.PartyId, y.PartyName, p.Num, p.FirstName, p.LastName, p.DateBorn, p.DateDied
	order by p.num


	finished:

	return @return
end
go

declare @i int, @m varchar(1000)
exec @i = PresidentSearch @BeginTermStart = 1950, @EndTermStart = 0, @Message = @m output

select @i, @m

exec PresidentSearch @BeginTermStart = 0, @EndTermStart = 1800

exec PresidentSearch @BeginTermStart = 1850, @EndTermStart = 1899

--exec PresidentSearch

--exec PresidentSearch @LastName = '' --no results

--exec PresidentSearch @LastName = null --no results
--select * from Party

--exec PresidentSearch @PartyId = 213

--exec PresidentSearch @LastName = 'm', @PartyId = 213

--exec PresidentSearch @LastName = 'm'--, @PartyId = null


