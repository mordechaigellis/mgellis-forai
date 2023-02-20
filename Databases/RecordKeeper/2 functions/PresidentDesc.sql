create or alter function dbo.PresidentDesc(@PresidentId int)
returns varchar(250)
as
begin
	declare @value varchar(250) = ''

	select @value = concat(p.Num, ' ', p.LastName, ', ', p.FirstName, ' (',y.PartyName,')')
	from President p
	join party y
	on p.PartyId = y.PartyId
	where p.PresidentId = @PresidentId

	return @value
end
go
select PresidentDesc = dbo.PresidentDesc(p.PresidentId) ,p.* 
from President p