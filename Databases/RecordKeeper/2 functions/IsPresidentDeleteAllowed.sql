create or alter function dbo.IsPresidentDeleteAllowed(@PresidentId int)
returns varchar(60)
as
begin
	declare @value varchar(60) = ''
	if exists(select * from ExecutiveOrder e where e.PresidentId = @PresidentId and e.UpheldByCourt = 1)
	begin
		select @value = 'Cannot delete president that has upheld executive orders.'
	end
	return @value
end
go
select dbo.IsPresidentDeleteAllowed(p.PresidentId),e.ExecutiveOrderId, e.UpheldByCourt,*
from President p 
left join ExecutiveOrder e
on e.PresidentId = p.PresidentId

