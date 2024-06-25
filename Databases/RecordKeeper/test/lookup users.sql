	select u.userId, u.roleId, u.username, u.password,u.sessionkey, r.rolename, r.rolerank, DATEDIFF(second,u.sessionkeyDate, getdate())
		from users u
		join roles r
		on r.roleId = u.roleId

--select * from party	

exec UserLogout @username = 'admin', @message = ''