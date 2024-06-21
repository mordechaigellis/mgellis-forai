create or alter procedure dbo.UserLogin(
	@username varchar(20),
	@password varchar(20),
	@message varchar(500) = '' output
)
as
begin
	declare @return int = 0, @userid int
	select @message = ''

	select @userid = u.userId from users u where u.username = @username and u.password = @password

	if isnull(@userid,0) > 0
	begin
		select u.userId, u.roleId, u.username, u.sessionkey, r.rolename, r.rolerank
		from users u
		join roles r
		on r.roleId = u.roleId
		where u.userId = @userid
	end
	else
	begin
		select @return = 1, @message = 'invalid login'
	end


	return @return
end
go
grant execute on UserLogin to approle