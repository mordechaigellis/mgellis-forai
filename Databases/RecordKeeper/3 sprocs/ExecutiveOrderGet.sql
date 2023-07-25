create or alter procedure dbo.ExecutiveOrderGet(
	@ExecutiveOrderId int = 0,
	@PresidentId int = 0,
	@All bit = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All,0), @ExecutiveOrderId = isnull(@ExecutiveOrderId,0)

	select e.ExecutiveOrderId, e.PresidentId, e.OrderNumber, e.PageNum, e.YearIssued, e.OrderName, e.Reference, e.UpheldByCourt, e.DateInserted
	from ExecutiveOrder e
	where ExecutiveOrderId = @ExecutiveOrderId
	or @All = 1
	or e.PresidentId = @PresidentId

	return @return
end
go

--select * from ExecutiveOrder
--exec ExecutiveOrderGet @PresidentId = 1137