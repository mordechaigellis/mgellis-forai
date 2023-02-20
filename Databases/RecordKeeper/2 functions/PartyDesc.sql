create or alter function dbo.PartyDesc(@PartyId int)
returns varchar(75)
as
begin
	declare @value varchar(75) = ''

	select @value = concat(
		y.PartyName, 
		case when y.ColorId is not null then concat(' (',c.ColorName,')') else '' end
		,' ',count(p.PresidentId), ' Presidents')
	from Party y
	left join color c
	on c.ColorId = y.ColorId
	left join President p
	on p.PartyId = y.PartyId
	where y.PartyId = @PartyId
	group by y.PartyName, y.ColorId, c.ColorName

	return @value
end
go
select PartyDesc = dbo.PartyDesc(p.PartyId),*
from Party p