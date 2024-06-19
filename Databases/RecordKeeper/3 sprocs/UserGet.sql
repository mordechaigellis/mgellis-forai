create or alter procedure dbo.UserGet(
	@userId int, 
	@sessionkey varchar(255),
	@message varchar(500) = '' output
)
as
begin
	declare @return int = 0

		select u.userId, u.roleId, u.username, u.sessionkey, r.rolename, r.rolerank
		from users u
		join roles r
		on r.roleId = u.roleId
		where u.userId = @userid
		or (u.sessionkey = @sessionkey and @sessionkey != '')

	return @return
end
go
grant execute on UserGet to approle