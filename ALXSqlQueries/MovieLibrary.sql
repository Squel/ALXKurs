create database MovieLibrary
go

use MovieLibrary


create table MPA_Ratings
(
 Id int not null primary key identity,
 Rating varchar(5),
 RatingMeaning varchar(100),
 RatingExplanation varchar(500)
)

create table Directors
(
Id int not null primary key identity,
FirstName nvarchar(50),
LastName nvarchar(100)
)

create table Writers
(
Id int not null primary key identity,
FirstName nvarchar(50),
LastName nvarchar(100)
)

create table Stars
(
Id int not null primary key identity,
FirstName nvarchar(50),
LastName nvarchar(100)
)

go

create table Movie
(
 Id int not null primary key identity,
 Title nvarchar(500),
 Genre nvarchar(50),
 YearOfRelease int,
 MPARatingId int foreign key references MPA_Ratings(Id),
 DirectorId int foreign key references Directors(Id),
 WriterId int foreign key references Writers(Id),
 StarId int foreign key references Stars(Id),

)




use MovieLibrary
go

insert into MPA_Ratings(Rating, RatingMeaning, RatingExplanation)
values('G', 'General Audiences', 'All ages admitted. Nothing that would offend parents for viewing by children.')
insert into MPA_Ratings(Rating, RatingMeaning, RatingExplanation)
values('PG', 'Parental Guidance Suggested', 'Some material may not be suitable for children. Parents urged to give "parental guidance". May contain some material parents might not like for their young children')
insert into MPA_Ratings(Rating, RatingMeaning, RatingExplanation)
values('PG-13', 'Parents Strongly Cautioned', 'Some material may be inappropriate for children under 13. Parents are urged to be cautious. Some material may be inappropriate for pre-teenagers.')
insert into MPA_Ratings(Rating, RatingMeaning, RatingExplanation)
values('R', 'Restricted', 'Under 17 requires accompanying parent or adult guardian. Contains some adult material. Parents are urged to learn more about the film before taking their young children with them.')
insert into MPA_Ratings(Rating, RatingMeaning, RatingExplanation)
values('NC-17', 'Adults Only', 'No One 17 and Under Admitted. Clearly adult. Children are not admitted.')
go


insert into Directors(FirstName, LastName) values('Steven', 'Spielberg')
insert into Directors(FirstName, LastName) values('Quentit', 'Tarantino')
insert into Directors(FirstName, LastName) values('Ridley', 'Scott')
insert into Directors(FirstName, LastName) values('Christopher', 'Nolan')
insert into Directors(FirstName, LastName) values('Stanisław', 'Bareja')
insert into Directors(FirstName, LastName) values('Juliusz', 'Machulski')
insert into Directors(FirstName, LastName) values('Tim', 'Burton')
insert into Directors(FirstName, LastName) values('Chris', 'Columbus')
go

insert into Writers(FirstName, LastName) values('Steve', 'Kloves')
insert into Writers(FirstName, LastName) values('Juliusz', 'Machulski')
insert into Writers(FirstName, LastName) values('Linda', 'Woolverton')
insert into Writers(FirstName, LastName) values('John', 'Logan')
insert into Writers(FirstName, LastName) values('Lawrence', 'Kasdan')
insert into Writers(FirstName, LastName) values('Caroline', 'Thompson')
go

insert into Stars(FirstName, LastName) values('Daniel', 'Radcliffe')
insert into Stars(FirstName, LastName) values('Jan', 'Machulski')
insert into Stars(FirstName, LastName) values('Mia', 'Wasikowska')
insert into Stars(FirstName, LastName) values('Russel', 'Crowe')
insert into Stars(FirstName, LastName) values('Harrison', 'Ford')
insert into Stars(FirstName, LastName) values('Johnny', 'Depp')
go

insert into Movie(Title, Genre, YearOfRelease, MPARatingId, DirectorId, WriterId, StarId)
values('Harry Potter and the Chamber Of Secrets','Fantasy',2002, 1, 8, 1, 1)
insert into Movie(Title, Genre, YearOfRelease, MPARatingId, DirectorId, WriterId, StarId)
values('Vabank','Comedy',1981, 3, 6, 2, 2)
insert into Movie(Title, Genre, YearOfRelease, MPARatingId, DirectorId, WriterId, StarId)
values('Edward Scissorhands','Drama',1990, 3, 7, 6, 6)
insert into Movie(Title, Genre, YearOfRelease, MPARatingId, DirectorId, WriterId, StarId)
values('Indiana Jones and the Raiders of the Lost Ark','Adventure',1981, 2, 2, 5, 5)
insert into Movie(Title, Genre, YearOfRelease, MPARatingId, DirectorId, WriterId, StarId)
values('Gladiator','Drama',2000, 4, 3, 4, 4)
insert into Movie(Title, Genre, YearOfRelease, MPARatingId, DirectorId, WriterId, StarId)
values('Alice in Wonderland','Fantasy',2010, 2, 7, 3, 3)
go

select * from Movie
select * from Stars
select * from Directors
select * from MPA_Ratings
select * from Writers

select Movie.Title, Movie.Genre, Movie.YearOfRelease, MPA_Ratings.Rating, Directors.FirstName, Directors.LastName, 
Writers.FirstName, Writers.LastName,
Stars.FirstName, Stars.LastName
from Movie
inner join MPA_Ratings on Movie.MPARatingId=MPA_Ratings.Id
inner join Directors on Movie.DirectorId=Directors.Id
inner join Writers on Movie.WriterId=Writers.Id
inner join Stars on Movie.StarId=Stars.Id

