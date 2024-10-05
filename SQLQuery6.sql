 use LocationVoitureBD;
 create table Voiture(NumPlaque varchar(50) not null Primary Key,Marque varchar(50) not null, Modele varchar(50),Statut varchar(50),Prix int);
 create table Clients (clid int not null Primary key ,clnom varchar (50) not null,cladresse varchar(50) not null, clphone varchar(50) not null,clpermis varchar (50) not null);
 create table Location (loID int not null primary key ,
 voiture varchar (50) not null ,client int not null 
 ,datelocation date not null,
 dateretour date not null, cout int not null,
 statut varchar(50) not null,
 foreign key(voiture) references voiture (NumPlaque),
 foreign key (Client) references clients (clid));
 
 create table cnx (nom varchar (50) not null primary key ,password varchar (50) not null);
 insert into cnx values ('houda','2002MAZ');
 select *from cnx;
 INSERT INTO Voiture 
VALUES ('ABC123', 'Toyota', 'Corolla', 'Disponible', 50);
 select* from voiture;
 select* from Location;
 select* from Clients ;
 