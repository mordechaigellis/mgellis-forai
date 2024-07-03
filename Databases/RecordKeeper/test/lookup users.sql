	select u.userId, u.roleId, u.username, u.password,u.sessionkey, r.rolename, r.rolerank, DATEDIFF(second,u.sessionkeyDate, getdate())
		from users u
		join roles r
		on r.roleId = u.roleId
--01952AEB-014E-4F8D-9F79-E00356D23776

--select * from party	

--exec UserLogout @sessionkey = 'admin', @message = ''