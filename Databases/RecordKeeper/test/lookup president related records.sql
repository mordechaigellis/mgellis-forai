--select count(p.PartyId), c.ColorName
--from party p
--left join color c
--on c.ColorId = p.ColorId
--group by c.ColorName

select count(distinct p.PresidentId)
from President p
join ExecutiveOrder e
on p.PresidentId = e.PresidentId

select count(distinct PresidentId)
from PresidentMedal

select * from President order by 1 desc