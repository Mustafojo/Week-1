create table Students
(
	Id serial primary key,
	Name varchar,
	Age int,
	GroupId int references on delete cascade Groups(Id)
);

create table Groups
(
	Id serial primary key,
	Name varchar
);

create table Cources
(
	Id serial primary key,
	Name varchar
);

create table CourceGroup
(
	CourceId int references Cources(Id),
	GroupId int references Groups(Id)
);

select * from Students

select s.Id,s.Name,s.Age,g.Id as GroupId,g.Name 
from Students as s 
join Groups as g on g.Id = s.GroupId

select s.Id as StudentId,g.Id as GroupId,g.Name 
from Groups as g 
join Students as s on s.Id = g.StudentId



insert into Students(Name,Age,GroupId)
              values('Privet',21,3),
			        ('Maruf',15,3),
                    ('Mumtoz',17,3),
					('Samir',16,4),
					('Ismoil',23,4),
					('Akmal',15,4),
			        ('Mustafo',16,1),
			        ('Barotov',15,1),
					('Salom',10,1),
					('Yusuf',15,1),
					('Davron',16,2),
				    ('Hello',15,2),
					('Hi',16,2)

insert into Groups(Name,StudentId)
            values('.Net 11',1),
			      ('C# 12',2),
				  ('C++ October',3),
				  ('Html november',4)
				  
insert into Cources(Name)
             values('C#'),
				   ('C++'),
				   ('Html/Css'),
				   ('.Net')
				   
insert into CourceGroup(CourceId,GroupId)
                 values(1,2),
				       (2,3),
					   (3,4),
					   (4,1)
			
			
Alter table Students
rename column Name  to StudentName

Alter table Groups
add column StudentId int references Students(Id)







