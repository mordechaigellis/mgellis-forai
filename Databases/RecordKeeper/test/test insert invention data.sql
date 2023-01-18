insert Invention(InventionName, InventionDesc, YearInvented, InventorFirstName, InventorLastName, Country, YearBorn, YearDied)
select '', 'Coolest Invention', 1990, 'James', 'Jones', 'USA', 1980, null

insert Invention(InventionName, InventionDesc, YearInvented, InventorFirstName, InventorLastName, Country, YearBorn, YearDied)
select 'Cool!', '', 1990, 'James', 'Jones', 'USA', 1980, null

insert Invention(InventionName, InventionDesc, YearInvented, InventorFirstName, InventorLastName, Country, YearBorn, YearDied)
select 'Cool!', 'Coolest Invention', -1, 'James', 'Jones', 'USA', 1980, null

insert Invention(InventionName, InventionDesc, YearInvented, InventorFirstName, InventorLastName, Country, YearBorn, YearDied)
select 'Cool!', 'Coolest Invention', 1990, '', 'Jones', 'USA', 1980, null

insert Invention(InventionName, InventionDesc, YearInvented, InventorFirstName, InventorLastName, Country, YearBorn, YearDied)
select 'Cool!', 'Coolest Invention', 1990, 'James', '', 'USA', 1980, null

insert Invention(InventionName, InventionDesc, YearInvented, InventorFirstName, InventorLastName, Country, YearBorn, YearDied)
select 'Cool!', 'Coolest Invention', 1990, 'James', 'Jones', '', 1980, null

insert Invention(InventionName, InventionDesc, YearInvented, InventorFirstName, InventorLastName, Country, YearBorn, YearDied)
select 'Cool!', 'Coolest Invention', 1990, 'James', 'Jones', 'USA', -1, null

insert Invention(InventionName, InventionDesc, YearInvented, InventorFirstName, InventorLastName, Country, YearBorn, YearDied)
select 'Cool!', 'Coolest Invention', 1990, 'James', 'Jones', 'USA', 1980, -2
-- 7. Ensure that not null columns block nulls
insert Invention(InventionName, InventionDesc, YearInvented, InventorFirstName, InventorLastName, Country, YearBorn, YearDied)
select null, 'Coolest Invention', 1990, 'James', 'Jones', 'USA', 1980, null

insert Invention(InventionName, InventionDesc, YearInvented, InventorFirstName, InventorLastName, Country, YearBorn, YearDied)
select 'Cool!', null, 1990, 'James', 'Jones', 'USA', 1980, null

insert Invention(InventionName, InventionDesc, YearInvented, InventorFirstName, InventorLastName, Country, YearBorn, YearDied)
select 'Cool!', 'Coolest Invention', null, 'James', 'Jones', 'USA', 1980, null

insert Invention(InventionName, InventionDesc, YearInvented, InventorFirstName, InventorLastName, Country, YearBorn, YearDied)
select 'Cool!', 'Coolest Invention', 1990, null, 'Jones', 'USA', 1980, null

insert Invention(InventionName, InventionDesc, YearInvented, InventorFirstName, InventorLastName, Country, YearBorn, YearDied)
select 'Cool!', 'Coolest Invention', 1990, 'James', null, 'USA', 1980, null

insert Invention(InventionName, InventionDesc, YearInvented, InventorFirstName, InventorLastName, Country, YearBorn, YearDied)
select 'Cool!', 'Coolest Invention', 1990, 'James', 'Jones', null, 1980, null

insert Invention(InventionName, InventionDesc, YearInvented, InventorFirstName, InventorLastName, Country, YearBorn, YearDied)
select 'Cool!', 'Coolest Invention', 1990, 'James', 'Jones', 'USA', null, null

insert Invention(InventionName, InventionDesc, YearInvented, InventorFirstName, InventorLastName, Country, YearBorn, YearDied)
select top 1 InventionName, 'It is a very nice invention...', YearInvented, 'John', InventorLastName, Country, YearBorn, YearDied
from Invention i

insert Invention(InventionName, InventionDesc, YearInvented, InventorFirstName, InventorLastName, Country, YearBorn, YearDied)
select top 1 'How Wheels', 'It is a very nice invention...', 1991, 'John', InventorLastName, Country, 1990, YearDied
from Invention i

insert Invention(InventionName, InventionDesc, YearInvented, InventorFirstName, InventorLastName, Country, YearBorn, YearDied)
select top 1 'How Wheels', 'It is a very nice invention...', 2000, 'John', InventorLastName, Country, 1990, YearDied
from Invention i

---- 2. Year Invented must be between year born and year died
insert Invention(InventionName, InventionDesc, YearInvented, InventorFirstName, InventorLastName, Country, YearBorn, YearDied)
select top 1 'How Wheels', 'It is a very nice invention...', 2020, 'John', InventorLastName, Country, 1990, 2019
from Invention i

insert Invention(InventionName, InventionDesc, YearInvented, InventorFirstName, InventorLastName, Country, YearBorn, YearDied)
select top 1 'How Wheels', 'It is a very nice invention...', 2020, 'John', InventorLastName, Country, 1990, 2020
from Invention i
