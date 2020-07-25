create database ictskills;
go
use ictskills;
go
create table Tournament(
	Id integer primary key identity(1, 1),
	Name varchar(100) not null,
	StartDate datetime not null,
	EndDate datetime not null
);
go
create table Region(
	Id integer primary key identity(1, 1),
	RegionName varchar(100) not null
);
go
create table Team(
	Id integer primary key identity(1, 1),
	CountryCode varchar(3) not null,
	CountryName varchar(100) not null,
	RegionId integer not null foreign key references Region(Id),
	FlagContent varbinary(max)
);
go
create table TournamentParticipation(
	Id integer primary key identity (1, 1),
	TeamId integer not null foreign key references Team(Id),
	TournamentId integer not null foreign key references Tournament(Id),
	GroupNumber integer null,
	GroupLetter varchar(1) null
);
go
create table Player(
	Id integer primary key identity(1, 1),
	FirstName varchar(100) not null,
	LastName varchar(100) not null,
	Position varchar(50) not null,
	ShirtNumber integer not null,
	DateOfBirth datetime not null,
	TeamId integer foreign key references Team(Id)
);
go
create table [Match](
	Id integer primary key identity(1, 1),
	StageCode varchar(3) not null,
	TeamA integer not null foreign key references TournamentParticipation(Id),
	TeamB integer not null foreign key references TournamentParticipation(Id)
);
go
create table MatchParticipation(
	Id integer primary key identity(1, 1),
	PlayerId integer not null foreign key references Player(Id),
	MatchId integer not null foreign key references [Match](Id),
	Position varchar(50) null
);
go
create table MatchEvents(
	Id integer primary key identity(1, 1),
	MatchId integer not null foreign key references Match(Id),
	MatchMinute integer not null,
	TeamA bit not null,
	EventType varchar(10) not null,
	AdditionalInformation varchar(200) not null
);
