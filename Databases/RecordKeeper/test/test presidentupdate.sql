declare @Message varchar(500) = '', @return int, @partyid int, @num int, @presidentid int

select top 1 @partyid = partyid from party 
select @num = max(p.Num) + 1 from President p

exec @return = PresidentUpdate
	@PresidentId = @presidentid output,
	@PartyId = @partyid,
	@Num = @num,
	@FirstName = 'Will',
	@LastName = 'Sill',
	@DateBorn = '1/1/2090',
	@DateDied = null,
	@TermStart = 2130,
	@TermEnd = 0,
	@Message  = @Message output

select @return, @Message, @presidentid

select * from President p where PresidentId = @presidentid

delete President where PresidentId = @presidentid

