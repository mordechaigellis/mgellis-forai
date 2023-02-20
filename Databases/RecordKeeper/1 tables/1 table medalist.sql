use recordkeeperdb
go

drop table if exists Medalist
go
create table dbo.Medalist(
	MedalistId int not null identity primary key,
	OlympicYear int,
	Season varchar (50),
	OlympicLocation varchar (100),
	Sport varchar (100),
	SportSubcategory varchar (100),
	Medal varchar (6),
	FirstName varchar (50),
	LastName varchar (50),
	Country varchar (50),
	YearBorn int
)
go