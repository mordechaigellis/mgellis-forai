create or alter procedure dbo.UserGet(
	@userId int = 0, 
	@sessionkey varchar(255) = '',
	@message varchar(500) = '' output
)
as
begin
	declare @return int = 0, @maxseconds int = 1200

	if isnull(@sessionkey,'') != ''
	begin
		select @userId = userid from users u where u.sessionkey = @sessionkey

		if isnull(@userId,0) = 0
		begin
			goto exit_proc
		end

		if(select top 1 DATEDIFF(second,u.sessionkeyDate, getdate()) from users u where u.userId = @userId) > @maxseconds
		begin
			update u set u.sessionkey = '', u.sessionkeyDate = null from users u where u.userId = @userId
		end
		else
		begin
			update u set u.sessionkeyDate = getdate() from users u where u.userId = @userId
		end
	end
		
   exit_proc:

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