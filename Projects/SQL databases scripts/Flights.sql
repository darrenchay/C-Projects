CREATE TABLE FlightPassengers (
	CustomerID INT IDENTITY(1,1) PRIMARY KEY,
	CustomerName varchar(255) NOT NULL,
	FlightNo varchar(255) NOT NULL,
	FlightDate DATETIME NOT NULL,
	Destination varchar(255) NOT NULL,
	);

Create Table Flights (
	FlightNo varchar(255) NOT NULL PRIMARY KEY,
	Aircraft varchar(255) NOT NULL,
	FLightPath varchar(255) NOT NULL,
	FlightDate DATETIME NOT NULL,
	SeatsFirstClass int NOT NULL,
	SeatsBusiness int NOT NULL,
	SeatsEconomy int NOT NULL,
	FaresFirstClass Decimal(20,2) NOT NULL,
	FaresBusiness Decimal(20,2) NOT NULL,
	FaresEconomy Decimal(20,2) NOT NULL,

	);

Create Table FlightsByDay (
	FlightNo varchar(255) NOT NULL PRIMARY KEY,
	Aircraft varchar(255) NOT NULL,
	FlightDate DATETIME NOT NULL,
	SeatsTakenFirstClass int,
	SeatsTakenBusiness int,
	SeatsTakenEconomy int,
	TotalRevenueOnFlight Decimal(20,2)
	);

ALTER TABLE FlightPassengers
ADD FOREIGN KEY (FlightNo) References Flights(FlightNo)

ALTER TABLE FlightsByDay
ADD FOREIGN KEY (FlightNo) References Flights(FlightNo)	