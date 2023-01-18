--block blank and negative
insert WorldRecord(Category, RecordName, RecordDesc, FullName, Amount, UnitOfMeasure, YearAchieved, Country)
select '', 'Coolest Record', 'truly amazing', 'Mr. Jones', 2.5, 'Inches', 2020, 'USA'

insert WorldRecord(Category, RecordName, RecordDesc, FullName, Amount, UnitOfMeasure, YearAchieved, Country)
select 'Animals', '', 'truly amazing', 'Mr. Jones', 2.5, 'Inches', 2020, 'USA'

insert WorldRecord(Category, RecordName, RecordDesc, FullName, Amount, UnitOfMeasure, YearAchieved, Country)
select 'Animals', 'Coolest Record', '', 'Mr. Jones', 2.5, 'Inches', 2020, 'USA'
--union select 'Animals', 'Coolest Record', 'truly amazing', '', 2.5, 'Inches', 2020, 'USA'
--union
--select 'Animals', 'Coolest Record', 'truly amazing', 'Mr. Jones', -2, 'Inches', 2020, 'USA'
--union select 'Animals', 'Coolest Record', 'truly amazing', 'Mr. Jones', 2.5, '', 2020, 'USA'
--union 
select 'Animals', 'Coolest Record', 'truly amazing', 'Mr. Jones', 2.5, 'Inches', -1, 'USA'
union select 'Animals', 'Coolest Record', 'truly amazing', 'Mr. Jones', 2.5, 'Inches', 2020, ''

insert WorldRecord(Category, RecordName, RecordDesc, FullName, Amount, UnitOfMeasure, YearAchieved, Country)
select top 1 Category, 'Some new world record', RecordDesc, FullName, Amount, UnitOfMeasure, YearAchieved, Country
from WorldRecord w

-- 1. Two records cannot have the same Record Name, Unit of Measure, and Amount 
insert WorldRecord(Category, RecordName, RecordDesc, FullName, Amount, UnitOfMeasure, YearAchieved, Country)
select top 1 'Food', RecordName, 'Amazing record...', FullName, Amount, UnitOfMeasure, YearAchieved, Country
from WorldRecord w

insert WorldRecord(Category, RecordName, RecordDesc, FullName, Amount, UnitOfMeasure, YearAchieved, Country)
select top 1 'Food', RecordName, 'Amazing record...', FullName, Amount + 100, UnitOfMeasure, YearAchieved, Country
from WorldRecord w

--block nulls
/*
select null, 'Coolest Record', 'truly amazing', 'Mr. Jones', 2.5, 'Inches', 2020, 'USA'
union 
select 'Animals', null, 'truly amazing', 'Mr. Jones', 2.5, 'Inches', 2020, 'USA'
union
select 'Animals', 'Coolest Record', null, 'Mr. Jones', 2.5, 'Inches', 2020, 'USA'
union
select 'Animals', 'Coolest Record', 'truly amazing', null, 2.5, 'Inches', 2020, 'USA'
union 
select 'Animals', 'Coolest Record', 'truly amazing', 'Mr. Jones', null, 'Inches', 2020, 'USA'
union
select 'Animals', 'Coolest Record', 'truly amazing', 'Mr. Jones', 2.5, null, 2020, 'USA'
union
select 'Animals', 'Coolest Record', 'truly amazing', 'Mr. Jones', 2.5, 'Inches', null, 'USA'
union
select 'Animals', 'Coolest Record', 'truly amazing', 'Mr. Jones', 2.5, 'Inches', 2020, null
*/