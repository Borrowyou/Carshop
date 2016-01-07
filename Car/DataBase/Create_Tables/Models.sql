Create Table Models
(
	MODEL_ID INT NOT NULL PRIMARY KEY,
	MODEL_NAME varchar(255),
	YEAR_MANUF INT,
	YEAR_STOP INT,
	CAR_ID INT
	 CONSTRAINT FK_CARS FOREIGN KEY (CAR_ID) REFERENCES CARS(CAR_ID)
)