create or alter proc dbo.PresidentUpdate(
	@PresidentId int output,
	@PartyId int,
	@Num int,
	@FirstName varchar (100),
	@LastName varchar (100),
	@DateBorn date,
	@DateDied datetime2,
	@TermStart int,
	@TermEnd int,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @PresidentId = isnull(@PresidentId,0), @TermEnd = nullif(@TermEnd,0)

	if @TermEnd is null and exists(select * from President p where p.TermEnd is null and p.Presidentid <> @PresidentId)
	begin
		select @return = 1, @Message = 'There can be only one current president at a time.'
		goto finished
	end

	if @PresidentId = 0
	begin
		insert President(PartyId, Num, FirstName, LastName, DateBorn, DateDied, TermStart, TermEnd)
		values(@PartyId, @Num, @FirstName, @LastName, @DateBorn, @DateDied, @TermStart, @TermEnd)

		select @PresidentId = scope_identity()
	end
	else
	begin
		update President
		set
			PartyId = @PartyId, 
			Num = @Num, 
			FirstName = @FirstName, 
			LastName = @LastName, 
			DateBorn = @DateBorn, 
			DateDied = @DateDied, 
			TermStart = @TermStart, 
			TermEnd = @TermEnd 
		where PresidentId = @PresidentId
	end

	finished:
	return @return
end
go