create table Animal
(ID int identity(1,1) Primary Key,
Species varchar(max) not null,
Name varchar(max) not null,
Gender varchar(6) not null,
Age int,
Breed varchar(max),
Size varchar(6),
Personality_Type varchar(max),
Special_Needs bit,
Food_Requirments varchar(max),
Spayed_or_Neutered bit,
Recieved_Shots bit,
Adoption_Price float not null,
Category varchar(max) not null
);

create table Rooms
(ID int identity(1,1) Primary Key,
Room_Number int not null, 
Is_Available bit not null,
Current_Animal int Foreign Key (Current_Animal) references dbo.Animal(ID)
);

create table Billing
(ID int identity(1,1) Primary key,
Name_On_Card varchar(max) not null,
Card_Number int not null,
Expiration varchar(5) not null,
CVC int not null,
Billing_Address varchar(max) not null
);

create table Adopter
(ID int identity(1,1) Primary Key,
First_Name varchar(max) not null, 
Middle_Initial varchar(1),
Last_Name varchar(max) not null,
Street_Address varchar(max) not null,
Email varchar(max),
Phone int,
Billing_Info int foreign key(Billing_Info) references dbo.Billing(ID),
Personality_Profile varchar(max) not null,
Small_Children bit,
Animals bit,
Number_Of_Animals int,
Type_Of_Animals varchar(max),
Animals_Interested_In_Adopting int Foreign Key (Animals_Interested_In_Adopting) references dbo.Animal(ID)
);

Alter table Adopter alter column Phone varchar(15);