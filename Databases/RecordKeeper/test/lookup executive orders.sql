select p.Num, p.LastName, o.* 
from ExecutiveOrder o 
join President p
on p.PresidentId = o.PresidentId
where p.Num = 7
order by o.ExecutiveOrderId desc