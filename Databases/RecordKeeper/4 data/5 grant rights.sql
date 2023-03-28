use RecordKeeperDB
go
--select concat('grant execute on ',r.ROUTINE_NAME,' to approle')
--from INFORMATION_SCHEMA.ROUTINES r
--where r.ROUTINE_NAME not like '%gener%'
--and r.ROUTINE_NAME not like '%colna%'

grant execute on PresidentMedalGet to approle
grant execute on PresidentMedalDelete to approle
grant execute on PresidentMedalUpdate to approle
grant execute on PresidentSearch to approle
grant execute on PresidentDelete to approle
grant execute on CountryUpdate to approle
grant execute on OlympicMedalGet to approle
grant execute on PartyGet to approle
grant execute on PresidentGet to approle
grant execute on OlympicsGet to approle
grant execute on OlympicsSummaryGet to approle
grant execute on PresidentUpdate to approle
grant execute on OlympicMedalUpdate to approle
grant execute on OlympicMedalDelete to approle
grant execute on SportUpdate to approle
grant execute on SportSubCategoryUpdate to approle
grant execute on SportSubCategoryGet to approle
grant execute on SportGet to approle
grant execute on SportDelete to approle
grant execute on SeasonUpdate to approle
grant execute on SeasonGet to approle
grant execute on SeasonDelete to approle
grant execute on CityGet to approle
grant execute on SportSubCategoryDelete to approle
grant execute on CityUpdate to approle
grant execute on CityDelete to approle
grant execute on PresidentDesc to approle
grant execute on PartyDesc to approle
grant execute on OlympicsCreateBasedOnPrevious to approle
grant execute on IsPresidentDeleteAllowed to approle
--grant execute on PartyUpdate to approle
grant execute on DashboardGet to approle
grant execute on MedalGet to approle
--grant execute on ColorGet to approle
--grant execute on PartyDelete to approle
grant execute on ExecutiveOrderGet to approle
grant execute on CountryGet to approle
grant execute on CountryDelete to approle