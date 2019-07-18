CREATE TABLE Inventory(
	InventoryID int NOT NULL PRIMARY KEY,
	InventoryName varchar(255) NOT NULL,
	Quantity int NOT NULL,
	BuyingPrice decimal(20,2) NOT NULL,
	SellingPrice decimal(20,2) NOT NULL,
	MinQty int DEFAULT 20,
	);

CREATE TABLE TransactionsByDay(
	TransactionID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	TimeSold DATETIME NOT NULL,
	InventoryID int NOT NULL,
	InventoryName varchar(255) NOT NULL,
	QtySold int NOT NULL,
	OrderID int NOT NULL,
	FOREIGN KEY (inventoryID) references Inventory(InventoryID)
	);

/*INSERT INTO Inventory (InventoryID,	InventoryName,	Quantity,	BuyingPrice,	SellingPrice,	MinQty)
	values(04, 'Sprite 0.5L', 20, 25, 35.00, 5);
INSERT INTO TransactionsByDay (TimeSold, InventoryID, InventoryName, QtySold, OrderID)
	VALUES('2019-06-11 11:42:00', 03, 'Fanta 0.5L', 1, 012)
SELECT * FROM Inventory
	where InventoryID = 01;
Select * from TransactionsByDay
	where TransactionID = 01;*/