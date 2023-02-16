declare @Message varchar(500) = '', @return int, @partyid int, @num int, @presidentid int,
	@FirstName varchar (100),
	@LastName varchar (100),
	@DateBorn date,
	@DateDied datetime2,
	@TermStart int,
	@TermEnd int

select top 1 
	@presidentid = p.PresidentId,
	@partyid = p.PartyId,
	@Num = Num, 
	@FirstName = FirstName, 
	@LastName = LastName, 
	@DateBorn = DateBorn, 
	@DateDied = DateDied, 
	@TermStart = TermStart, 
	@TermEnd = TermEnd 
from President p 
where p.TermEnd is null
--order by p.Num 

select @FirstName = REVERSE(@FirstName)--, @TermEnd = 0

exec @return = PresidentUpdate
	@PresidentId = @presidentid output,
	@PartyId = @partyid,
	@Num = @num,
	@FirstName = @FirstName,
	@LastName = @LastName,
	@DateBorn = @DateBorn,
	@DateDied = @DateDied,
	@TermStart = @TermStart,
	@TermEnd = @TermEnd,
	@Message  = @Message output

select @return, @Message, @presidentid

select * from President p where PresidentId = @presidentid



--delete President where num = 44

