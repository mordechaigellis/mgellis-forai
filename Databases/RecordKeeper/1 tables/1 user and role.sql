drop table if exists users
drop table if exists roles
go
create table dbo.roles(
	roleId int not null identity primary key,
	rolename varchar(10) not null constraint u_Role_Role_Name unique, --constraint min chars
	rolerank int not null constraint u_Role_Rank unique --constraint > -1
)
go
create table dbo.users(
	userId int not null identity primary key,
	roleId int not null constraint f_Roles_Users foreign key references roles(roleId),
	username varchar(20) not null constraint u_Users_User_Name unique, --constrain min amount chars
	password varchar(20) not null, --constraint min amount chars
	sessionkey varchar(255) not null default '', --constraint u_Users_Session_key unique,
	sessionkeyDate datetime null 
)
go