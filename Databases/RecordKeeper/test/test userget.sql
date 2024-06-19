--select userid, sessionkey from users

declare @message varchar(500), @return int, @sessionkey varchar(255)
select top 1 @sessionkey = sessionkey from users where sessionkey != ''
select @sessionkey
exec @return = UserGet @userid = 0, @sessionkey = @sessionkey, @message = @message output

select @return, @message
