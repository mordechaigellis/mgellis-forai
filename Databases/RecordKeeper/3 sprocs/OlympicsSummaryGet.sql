create or alter proc dbo.OlympicsSummaryGet(
	@Message varchar(500) = '' output
)
as
begin
	select 
		o.OlympicsId, 
		s.SeasonName, 
		c.CityName,
		o.OlympicYear, 
		NumOlympicSports = count(distinct osc.OlympicSportSubCategoryId), 
		NumOlympians = count(osco.OlympicSportSubCategoryOlympianId) 
	from Olympics o 
	join Season s
	on s.SeasonId = o.SeasonId
	join City c
	on c.CityId = o.CityId
	left join OlympicSportSubCategory osc
	on o.OlympicsId = osc.OlympicsId
	left join OlympicSportSubCategoryOlympian osco
	on osco.OlympicSportSubCategoryId = osc.OlympicSportSubCategoryId
	group by o.OlympicsId, o.OlympicYear, s.SeasonName, c.CityName
	order by o.OlympicYear desc, s.SeasonName
end
go
exec OlympicsSummaryGet