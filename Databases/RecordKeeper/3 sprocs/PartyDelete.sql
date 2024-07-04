create or alter proc dbo.PartyDelete(
	@PartyId int,
	@Message varchar(1000) = '' output
)
as
begin
	declare @return int = 0

	delete party where PartyId = @PartyId

	return @return
end
GO

grant execute on PartyDelete to approle
