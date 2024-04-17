USE [RecordKeeperDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER   proc [dbo].[PartyUpdate](
@PartyId int  output,
@PartyName varchar (35),
@YearStart smallint ,
@ColorId int,
@Message varchar(500) = '' output
)
as
begin
	select @PartyId = isnull(@PartyId,0), @ColorId = nullif(@ColorId,0)

	if @PartyId = 0
	begin
		insert party(PartyName, YearStart, ColorId)
		values(@PartyName, @YearStart, @ColorId)
		
		select @PartyId = SCOPE_IDENTITY()
	end
	else
	begin
		update party
		set
		PartyName = @PartyName, 
		YearStart = @YearStart, 
		ColorId = @ColorId
		where PartyId = @PartyId
	end

end