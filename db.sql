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

create table Region(
	Id integer primary key identity(1, 1),
	RegionName varchar(100) not null
);

create table Team(
	Id integer primary key identity(1, 1),
	CountryCode varchar(3) not null,
	CountryName varchar(100) not null,
	RegionId integer not null foreign key references Region(Id),
	FlagContent varbinary(max)
);

create table TournamentParticipation(
	TeamId integer not null foreign key references Team(Id),
	TournamentId integer not null foreign key references Tournament(Id),
	constraint pk_tournament_participation primary key (TeamId, TournamentId)
);

create table Player(
	Id integer primary key identity(1, 1),
	FirstName varchar(100) not null,
	LastName varchar(100) not null,
	Position varchar(50) not null,
	ShirtNumber integer not null,
	DateOfBirth datetime not null
);

create table TeamMember(
	PlayerId integer not null foreign key references Player(Id),
	TeamId integer not null foreign key references Team(Id),
	constraint pk_team_member primary key(PlayerId, TeamId)
);
