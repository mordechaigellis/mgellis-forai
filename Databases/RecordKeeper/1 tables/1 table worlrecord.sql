-- 1. All columns should block nulls
-- 3. Block blank values for all varchar column
-- 4. Block negative numbers for int columns
-- 5. Rerun the World Record data

use RecordKeeperDB
go
drop table if exists WorldRecord
go
create table dbo.WorldRecord(
	WorldRecordId int not null identity primary key,
	Category varchar (100) not null constraint ck_World_Record_category_cannot_be_blank check(Category <> ''),
	RecordName varchar (200) not null constraint ck_World_Record_record_name_cannot_be_blank check(RecordName <> ''),
	RecordDesc varchar (2000) not null 
		constraint ck_World_Record_record_description_cannot_be_blank check(RecordDesc <> '')
		constraint u_WorldRecord_record_description unique,
	FullName varchar (100) not null constraint ck_World_Record_full_name_cannot_be_blank check(FullName <> ''),
	Amount decimal not null constraint ck_World_Record_amount_cannot_be_negative check(Amount > 0), 
	UnitOfMeasure varchar (100) not null constraint ck_World_Record_unit_of_meaure_cannot_be_blank check(UnitOfMeasure <> ''),
	YearAchieved int not null constraint ck_World_Record_year_achieved_cannot_be_negative check(YearAchieved > 0), 
	Country varchar (50) not null constraint ck_World_Record_country_cannot_be_blank check(Country <> ''),
	-- 1. Two records cannot have the same Record Name, Unit of Measure, and Amount 
	constraint u_WorldRecord_record_name_and_unit_of_measure_and_amount unique(RecordName, UnitOfMeasure, Amount)
	)
go
alter table worldrecord drop column if exists WorldRecordCode
go
alter table WorldRecord add WorldRecordCode as concat(substring(replace(RecordName, ' ',''),1,20),YearAchieved) persisted
    CONSTRAINT u_WorldRecord_WorlRecordCode unique
GO
alter table WorldRecord drop column if exists OfficialDesc
go
alter table WorldRecord add OfficialDesc as concat(Category,': ', RecordName,'-' , Amount,' ' , UnitOfMeasure,'. ', 'Achieved By ', FullName,' (', YearAchieved,')') persisted
go
alter table WorldRecord drop constraint if exists d_WorldRecord_RecordBreakerAddress
alter table WorldRecord drop column if exists RecordBreakerAddress 
go
alter table WorldRecord add RecordBreakerAddress varchar(50) not null constraint d_WorldRecord_RecordBreakerAddress default ''
/* 2. Add a new bit column called RecordBroken. It shouldn't allow nulls and should be defaulted to zero.
      If someone else breaks the same record afterwards, then the old one's RecordBroken column will have to be updated to a one.
*/
alter table WorldRecord drop constraint if exists d_WorldRecord_RecordBroken 
alter table WorldRecord drop column if exists RecordBroken 
go
alter table WorldRecord add RecordBroken bit not null constraint d_WorldRecord_RecordBroken default 0
-- 3. Test the new default values. Insert a record without specifying values for those columns, and then select the new record
go
