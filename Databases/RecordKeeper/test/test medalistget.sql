exec MedalistGet

exec MedalistGet @All = 1

declare @id int
select top 1 @id = m.MedalistId from Medalist m 
exec MedalistGet @MedalistId = @id
