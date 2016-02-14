Create Table Parts
(
	Part_ID int not null Primary key,
	part_name varchar(255),
	part_price float,
	part_details varchar(255),
	part_manuf varchar(255),
	Car_ID int,
	Model_ID int,
	CATEGORY_ID INT NOT NULL,
	IMG VARBINARY(MAX)
	constraint FK_Cars Foreign key (Car_ID) references Cars(Car_ID),
	 constraint FK_Models Foreign key(Model_ID) references Models(Model_ID)
)