create table Animals
(ID int identity(1,1) Primary Key,
Unique_ID varchar(6) not null,
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
Category varchar(max) not null,
);

create table Room
(ID int identity(1,1) Primary Key,
Room_Number int not null, 
Available bit not null,
);

create table Adopters
(ID int identity(1,1) Primary Key,
First_Name varchar(max) not null, 
Middle_Initial varchar(1),
Last_Name varchar(max) not null,
Street_Address varchar(max) not null,
Email varchar(max),
Phone int,
Billing_Info varchar(max),
Personality_Profile varchar(max) not null,
Small_Children bit,
Animals bit,
Number_Of_Animals int,
Type_Of_Animals varchar(max),
);