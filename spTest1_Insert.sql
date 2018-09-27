
CREATE PROCEDURE dbo.spTest1_Insert
	@Dates varchar(50),
    @PriceOpen varchar(50),
    @PriceHigh varchar(50),
    @PriceLow varchar(50),
    @PriceClose varchar(50),
    @Volume varchar(50),
    @MarketCap  varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO dbo.Test1(Dates, PriceOpen, PriceHigh, PriceLow, PriceClose, Volume, MarketCap)
	VALUES (@Dates, @PriceOpen, @PriceHigh, @PriceLow, @PriceClose, @Volume, @MarketCap);
END
GO
