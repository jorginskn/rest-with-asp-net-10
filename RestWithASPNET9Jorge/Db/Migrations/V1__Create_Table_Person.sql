CREATE TABLE dbo.person(
	[id] bigint not null IDENTITY,
	[first_name] varchar(80) NOT NULL,
	[last_name] varchar(80) not null,
	[address] varchar(100) not null,
	[gender] varchar(6) not null ,
	PRIMARY KEY ([id])
)