--select count(p.PartyId), c.ColorName
--from party p
--left join color c
--on c.ColorId = p.ColorId
--group by c.ColorName

select p.PresidentId, p.Num, p.LastName, e.*
from President p
join ExecutiveOrder e
on p.PresidentId = e.PresidentId

select p.PresidentId, p.Num, p.LastName, pm.*
from PresidentMedal pm
join President p
on p.PresidentId = pm.PresidentId

--select * from President order by 1 desc