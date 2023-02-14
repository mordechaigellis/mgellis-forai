set nocount on
declare @presidentid int

select top 1 @presidentid = p.PresidentId
from President p
join ExecutiveOrder e
on e.PresidentId = p.PresidentId
left join PresidentMedal pm
on pm.PresidentId = p.PresidentId
where pm.PresidentMedalId is null
and e.UpheldByCourt = 1
order by p.PresidentId

select 'president',p.PresidentId, p.LastName from President p where p.PresidentId = @presidentid
union select 'exec order',e.ExecutiveOrderId, e.OrderName from ExecutiveOrder e where e.PresidentId = @presidentid
union select 'president medal',pm.PresidentMedalId, m.MedalName from PresidentMedal pm join medal m on m.MedalId = pm.MedalId where pm.PresidentId = @presidentid

declare @return int, @message varchar(500)
exec @return = PresidentDelete @PresidentId = @presidentid, @Message = @message output

select @return, @message


select 'president',p.PresidentId, concat(p.Num, ' ', p.LastName) from President p where p.PresidentId = @presidentid
union select 'exec order',e.ExecutiveOrderId, e.OrderName from ExecutiveOrder e where e.PresidentId = @presidentid
union select 'president medal',pm.PresidentMedalId, m.MedalName from PresidentMedal pm join medal m on m.MedalId = pm.MedalId where pm.PresidentId = @presidentid
