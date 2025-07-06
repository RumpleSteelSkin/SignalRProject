USE SRP_DB


GO
CREATE TRIGGER IncreaseOrderTotalPrice
ON OrderDetails
AFTER INSERT
AS
DECLARE @OrderID INT
DECLARE @OrderPrice DECIMAL
SELECT @OrderID = OrderID FROM INSERTED
SELECT @OrderPrice = TotalPrice FROM INSERTED
UPDATE Orders SET TotalPrice = TotalPrice + @OrderPrice WHERE Id = @OrderID


GO
CREATE TRIGGER DecraseOrderTotalPrice
ON OrderDetails
AFTER DELETE
AS
DECLARE @OrderID INT
DECLARE @OrderPrice DECIMAL
SELECT @OrderID = OrderID FROM DELETED
SELECT @OrderPrice = TotalPrice FROM DELETED
UPDATE Orders SET TotalPrice = TotalPrice - @OrderPrice WHERE Id = @OrderID


GO
CREATE TRIGGER SumMoneyCases
ON Orders
AFTER UPDATE
AS
DECLARE @Description NVARCHAR(MAX)
DECLARE @TotalPrice DECIMAL(18,2)
SELECT @Description = Description FROM INSERTED
SELECT @TotalPrice = TotalPrice FROM INSERTED
IF(@Description ='Hesap Kapatıldı')
BEGIN
UPDATE MoneyCases SET TotalAmount = TotalAmount + @TotalPrice
END
