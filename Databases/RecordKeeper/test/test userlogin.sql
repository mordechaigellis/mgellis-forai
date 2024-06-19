declare @message varchar(500), @return int

exec @return = UserLogin @username = '', @password = '', @message = @message output

select @return, @message

exec @return = UserLogin @username = 'sam', @password = 'password', @message = @message output

select @return, @message

