--IMPORTANT create login in MASTER
--use MASTER
create login dev_login with PASSWORD = 'HAPpy372(3&'

--important swtch to RecordKeeperDB
create user dev_user from login dev_login

alter role db_datareader add member dev_user
alter role db_datawriter add member dev_user
