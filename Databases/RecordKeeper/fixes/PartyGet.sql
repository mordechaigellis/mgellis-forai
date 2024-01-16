create or alter procedure dbo.PartyGet(@PartyId int = 0, @PartyName varchar(35) = '', @All bit = 0, @IncludeBlank bit = 0)
as
begin
	select @PartyName = nullif(@PartyName,''), @IncludeBlank = isnull(@IncludeBlank,0)

	select p.PartyId, p.PartyName, p.YearStart, p.ColorId, PartyColor = c.ColorName, p.PartyDesc
	from Party p
	left join Color c
	on c.ColorId = p.ColorId
	where p.PartyId = @PartyId
	or @All = 1
	or p.PartyName like '%' + @PartyName + '%'
	union select 0, ' ', 0, 0, '',''
	where @IncludeBlank = 1
	order by p.PartyName
end
go
/*
exec PartyGet @all = 1
exec PartyGet @PartyName = '' --no results

exec PartyGet @PartyName = 'u'

exec PartyGet @All = 1, @IncludeBlank = 0

--exec 

declare @PartyId int 

select top 1 @PartyId = p.PartyId from Party p 

exec PartyGet @PartyId = @PartyId
*/