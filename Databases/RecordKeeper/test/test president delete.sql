declare @presidentid int

select top 1 @presidentid = p.PresidentId
from President p
left join ExecutiveOrder e
on e.PresidentId = p.PresidentId
left join PresidentMedal pm
on pm.PresidentId = p.PresidentId
where e.ExecutiveOrderId is null
and pm.PresidentMedalId is null
order by p.PresidentId

select * from President p where p.PresidentId = @presidentid

exec PresidentDelete @PresidentId = @presidentid


select * from President p where p.PresidentId = @presidentid