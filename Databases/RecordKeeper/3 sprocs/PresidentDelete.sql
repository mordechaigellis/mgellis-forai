create or alter procedure dbo.PresidentDelete(
	@PresidentId int,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0, @deleteallowed varchar(60) = ''

	select @deleteallowed = isnull(dbo.IsPresidentDeleteAllowed(@PresidentId),'')

	if @deleteallowed <> ''
	begin
		select @return = 1, @Message = 'Cannot delete president that has upheld executive orders.'
		goto finished
	end

	begin try
		begin tran
		delete ExecutiveOrder where PresidentId = @PresidentId
		delete President where PresidentId = @PresidentId
		commit
	end try
	begin catch
		rollback;
		throw
	end catch

	finished:
	return @return
end
go
