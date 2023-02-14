create or alter procedure dbo.PresidentDelete(
	@PresidentId int
)
as
begin
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
end
go
