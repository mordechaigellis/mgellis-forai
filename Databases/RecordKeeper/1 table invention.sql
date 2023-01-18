use RecordKeeperDB
go
drop table if exists Invention
go
create table dbo.Invention(
	InventionId int not null identity primary key,
	InventionName varchar (200) not null constraint ck_Invention_invention_name_cannot_be_blank check(InventionName<> ''),
	InventionDesc varchar (max) not null constraint ck_Invention_invention_description_cannot_be_blank check(InventionDesc<> ''),
	YearInvented int not null constraint ck_Invention_year_invented_must_be_greater_than_zero check(YearInvented > 0),
	InventorFirstName varchar (100) not null constraint ck_Invention_inventor_first_name_cannot_be_blank check(InventorFirstName<> ''), 
	InventorLastName varchar (100) not null constraint ck_Invention_inventor_lastName_cannot_be_blank check(InventorLastName<> ''),
	Country varchar (50) not null constraint ck_Invention_country_cannot_be_blank check(Country<> ''),
	YearBorn int not null constraint ck_Invention_year_born_must_be_greater_than_zero check(YearBorn > 0),
	YearDied int constraint ck_Invention_year_died_must_be_greater_than_zero check(YearDied > 0),
	constraint u_Invention_invention_name_and_year_invented unique(InventionName, YearInvented),
	constraint ck_inventors_must_be_at_10_years_old check(YearInvented - YearBorn >=10),
	-- 2. Year Invented must be between year born and year died
	constraint ck_inventor_year_invented_must_be_between_year_born_and_year_died check(YearInvented between YearBorn and YearDied)
	)
go
-- 1. Create a new computed column called AgeAtTimeOfInvention showing how old each inventor was when they invented their invention.
alter table invention drop column if exists AgeAtTimeOfInvention
go
alter table Invention add AgeAtTimeOfInvention as YearInvented - YearBorn persisted

-- 2. Create a new computed column called AgeAtDeath showing how old each inventor was when they died.
alter table invention drop column if exists AgeAtDeath
go
alter table Invention add AgeAtDeath as YearDied - YearBorn persisted

alter table invention drop column if exists InventionCode
go
alter table Invention add InventionCode as 
	replace(
		concat(YearInvented,substring(InventorFirstName,1,1),substring(InventorLastName,1,1), substring(upper(InventionName),1,15))
		,' ','') 
		persisted 
--------------
go
alter table Invention drop constraint if exists d_Invention_InventorPhoneNumber
alter table Invention drop column if exists InventorPhoneNumber
go
alter table Invention add InventorPhoneNumber varchar (15) not null constraint d_Invention_InventorPhoneNumber default ''

go
alter table Invention drop constraint if exists d_Invention_Patended
alter table Invention drop column if exists Patented
go
alter table Invention add Patented bit not null constraint d_Invention_Patended default 0



