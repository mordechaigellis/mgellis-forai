delete users
delete roles

insert roles(rolename, rolerank)
select 'user', '1'
union select 'superuser', '2'
union select 'admin', '3'

insert users(roleId,username, password)
select r.roleId, 'user', 'password' from roles r where r.rolerank = 1
union
select r.roleId, 'sam', 'password' from roles r where r.rolerank = 2
union 
select r.roleId, 'admin', 'password' from roles r where r.rolerank = 3

select * from roles
select * from users