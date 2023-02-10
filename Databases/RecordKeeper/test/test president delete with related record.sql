declare @presidentid int

select top 1 @presidentid = p.PresidentId
from President p
join ExecutiveOrder e
on e.PresidentId = p.PresidentId
order by p.PresidentId

select * from President p where p.PresidentId = @presidentid

exec PresidentDelete @PresidentId = @presidentid


select * from President p where p.PresidentId = @presidentid