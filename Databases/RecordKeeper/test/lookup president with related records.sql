declare @presidentid int

select @presidentid = p.PresidentId from President p where p.Num = 39

select @presidentid

select 'president',p.PresidentId, p.LastName from President p where p.PresidentId = @presidentid
union select 'exec order',e.ExecutiveOrderId, e.OrderName from ExecutiveOrder e where e.PresidentId = @presidentid
union select 'president medal',pm.PresidentMedalId, m.MedalName from PresidentMedal pm join medal m on m.MedalId = pm.MedalId where pm.PresidentId = @presidentid
